using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicInformationLearn48;

namespace BasicInformationLearnTest
{
    /// <summary>
    /// 基本情報技術者試験に出てくるスタブやテストを書いてみる
    /// テストコード
    /// ここでは、ターン制のバトル結果について各プログラムを記載する
    /// </summary>
    [TestClass]
    public class TurnBattleTest
    {
        [TestMethod, TestCategory("戦闘パート")]
        public void InGameFirstTurnTest()
        {
            // 戦闘突入フェーズ
            var battleField = new BattleField();
            var beforeTurn = battleField.GetTurn();
            while (battleField.IsPlayerWin() == false) {
                battleField.ExecTurn();
                // 戦闘結果時のアニメーションが入ったりする
                Assert.IsTrue(beforeTurn <= battleField.GetTurn());
                beforeTurn = battleField.GetTurn();
            }

            // 1ターンでは瞬殺できないようにしてある
            Assert.IsTrue(battleField.GetTurn() > 1);
        }

        [TestMethod, TestCategory("ダンジョンパート")]
        public void MapGameStartTest()
        { }
    }
}
