using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicInformationLearn48;

namespace BasicInformationLearnTest
{
    /// <summary>
    /// ��{���Z�p�Ҏ����ɏo�Ă���X�^�u��e�X�g�������Ă݂�
    /// �e�X�g�R�[�h
    /// �����ł́A�^�[�����̃o�g�����ʂɂ��Ċe�v���O�������L�ڂ���
    /// </summary>
    [TestClass]
    public class TurnBattleTest
    {
        [TestMethod, TestCategory("�퓬�p�[�g")]
        public void InGameFirstTurnTest()
        {
            // �퓬�˓��t�F�[�Y
            var battleField = new BattleField();
            var beforeTurn = battleField.GetTurn();
            while (battleField.IsPlayerWin() == false) {
                battleField.ExecTurn();
                // �퓬���ʎ��̃A�j���[�V�������������肷��
                Assert.IsTrue(beforeTurn <= battleField.GetTurn());
                beforeTurn = battleField.GetTurn();
            }

            // 1�^�[���ł͏u�E�ł��Ȃ��悤�ɂ��Ă���
            Assert.IsTrue(battleField.GetTurn() > 1);
        }

        [TestMethod, TestCategory("�_���W�����p�[�g")]
        public void MapGameStartTest()
        { }
    }
}
