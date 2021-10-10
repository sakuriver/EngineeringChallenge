#include "DxLib.h"

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
    // �E�B���h�E���[�h�ɐݒ�
    ChangeWindowMode(TRUE);

    // DX���C�u��������������
    if (DxLib_Init() < 0) {
        //�G���[�Ȃ�I������
        return -1;
    }

    //�`���𗠉�ʂɂ���
    SetDrawScreen(DX_SCREEN_BACK);

    // ��ʃ��[�h�̕ύX
    SetGraphMode(800, 600, 32);

    int gameMode = 0;

    int characterCount = 0;
    // while(����ʂ�\��ʂɔ��f, ���b�Z�[�W����, ��ʃN���A)
    while (ScreenFlip() == 0 && ProcessMessage() == 0 && ClearDrawScreen() == 0) {
        DrawFormatString(30, 0, GetColor(255, 0, 0), "��{���`�������W�N");
        if (characterCount % 30 <= 15) {
            LoadGraphScreen(400, 50, "tool_character_1.png", TRUE);
        }
        else {
            LoadGraphScreen(400, 50, "tool_character_2.png", TRUE);
        }
        characterCount++;
        if (characterCount > 1000) {
            characterCount = 0;
        }
        switch (gameMode)
        {
            case 0:
                DrawFormatString(30, 100, GetColor(255, 255, 255), "���[�h���͉�ʂł�");
                DrawFormatString(30, 120, GetColor(255, 255, 255), "1.�p�b�N�f�[�^�ǂݍ��݌v��");
                DrawFormatString(30, 180, GetColor(255, 255, 255), "Enter�L�[�������Ă�");
                break;
            case 1:
                LoadGraphScreen(530, 100, "controller.png", TRUE);

                DrawFormatString(30, 100, GetColor(255, 255, 255), "�f�[�^���[�h�v�����");
                DrawFormatString(30, 120, GetColor(255, 255, 255), "�f�[�^�ǂݍ��݊��� 100 byte �ł�");
                break;
            default:
                break;
        }

        DrawFormatString(30, 300, GetColor(255, 255, 255), "ESC�L�[�ŏI�����܂�");


        if (CheckHitKey(KEY_INPUT_ESCAPE) != 0) {
            DrawFormatString(30, 350, GetColor(0, 255, 0), "�܂����Ăˁ[��");
            Sleep(5000);
            break;
        }

        if (CheckHitKey(KEY_INPUT_RETURN)) {
            gameMode = 1;
            DrawFormatString(30, 100, GetColor(255, 255, 255), "�`�������W�R�[�i�[�ֈړ����ł�");
            Sleep(1500);
            DrawFormatString(30, 100, GetColor(255, 255, 255), "�ړ��������܂���");
            Sleep(1000);

        }

    }

    DxLib_End();    // DX���C�u�����I������
    return 0;
}