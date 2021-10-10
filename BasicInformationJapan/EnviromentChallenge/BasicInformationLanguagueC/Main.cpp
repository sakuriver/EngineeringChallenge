#include "DxLib.h"

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
    // ウィンドウモードに設定
    ChangeWindowMode(TRUE);

    // DXライブラリ初期化処理
    if (DxLib_Init() < 0) {
        //エラーなら終了する
        return -1;
    }

    //描画先を裏画面にする
    SetDrawScreen(DX_SCREEN_BACK);

    // 画面モードの変更
    SetGraphMode(800, 600, 32);

    int gameMode = 0;

    int characterCount = 0;
    // while(裏画面を表画面に反映, メッセージ処理, 画面クリア)
    while (ScreenFlip() == 0 && ProcessMessage() == 0 && ClearDrawScreen() == 0) {
        DrawFormatString(30, 0, GetColor(255, 0, 0), "基本情報チャレンジ君");
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
                DrawFormatString(30, 100, GetColor(255, 255, 255), "モード入力画面です");
                DrawFormatString(30, 120, GetColor(255, 255, 255), "1.パックデータ読み込み計測");
                DrawFormatString(30, 180, GetColor(255, 255, 255), "Enterキーを押してね");
                break;
            case 1:
                LoadGraphScreen(530, 100, "controller.png", TRUE);

                DrawFormatString(30, 100, GetColor(255, 255, 255), "データロード計測画面");
                DrawFormatString(30, 120, GetColor(255, 255, 255), "データ読み込み完了 100 byte です");
                break;
            default:
                break;
        }

        DrawFormatString(30, 300, GetColor(255, 255, 255), "ESCキーで終了します");


        if (CheckHitKey(KEY_INPUT_ESCAPE) != 0) {
            DrawFormatString(30, 350, GetColor(0, 255, 0), "またきてねー☆");
            Sleep(5000);
            break;
        }

        if (CheckHitKey(KEY_INPUT_RETURN)) {
            gameMode = 1;
            DrawFormatString(30, 100, GetColor(255, 255, 255), "チャレンジコーナーへ移動中です");
            Sleep(1500);
            DrawFormatString(30, 100, GetColor(255, 255, 255), "移動完了しました");
            Sleep(1000);

        }

    }

    DxLib_End();    // DXライブラリ終了処理
    return 0;
}