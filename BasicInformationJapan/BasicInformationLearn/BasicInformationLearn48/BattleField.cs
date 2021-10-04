using System;
using System.Collections.Generic;

namespace BasicInformationLearn48
{
    public class BattleField
    {

        private List<GameCharacter> playerCharacters;

        private List<GameCharacter> cpuCharacters;

        private int turn;

        /// <summary>
        /// 3 vs 3戦闘フィールドがスタブとして生成される
        /// </summary>
        public BattleField()
        {
            // プレイヤーのパーティ情報
            playerCharacters = new List<GameCharacter>();
            playerCharacters.Add(new GameCharacter());
            playerCharacters.Add(new GameCharacter());
            playerCharacters.Add(new GameCharacter());

            // cpu側の情報
            cpuCharacters = new List<GameCharacter>();
            cpuCharacters.Add(new GameCharacter());
            cpuCharacters.Add(new GameCharacter());
            cpuCharacters.Add(new GameCharacter());

            turn = 1;
        }

        public int GetTurn()
        {
            return turn;
        }

        /// <summary>
        /// プレイヤーの勝利判定
        /// </summary>
        /// <returns></returns>
        public bool IsPlayerWin()
        {

            var cpuLiveCount = 0;
            foreach (var cpuCharacter in cpuCharacters)
            {
                if (cpuCharacter.IsDead() == false)
                {
                    cpuLiveCount += 1;
                }
            }
            return playerCharacters.Count > 0 && cpuLiveCount <= 0;
        }

        ///
        /// ターン実行処理
        ///
        public void ExecTurn()
        {
            // スタブなので、実行パターンを固定化する
            // プレイヤー→CPU順番で行動
            foreach (var playerCharacter in playerCharacters)
            {
                // 死亡しているキャラクターの場合は、行動をスキップする
                if (playerCharacter.IsDead())
                {
                    continue;
                }
                for (int i = 0; i < cpuCharacters.Count; i++)
                {
                    // 既にやられている敵は、行動させない
                    if (cpuCharacters[i].IsDead())
                    {
                        continue;
                    }

                    // RPGの100%命中率判定で1回攻撃したらプレイヤーに移動
                    cpuCharacters[i].IsHit(playerCharacter.GetAttack());
                    break;
                }
            }

            // 全滅していたら終了
            if (IsPlayerWin())
            {
                return;
            }


            foreach (var cpuCharacter in cpuCharacters)
            {
                if (cpuCharacter.IsDead())
                {
                    continue;
                }
                for (var i = 0; i < playerCharacters.Count; i++)
                {
                    if (playerCharacters[i].IsDead())
                    {
                        continue;
                    }

                    playerCharacters[i].IsHit(cpuCharacter.GetAttack());
                    break;
                }
            }

            // 両方が行動完了したらターンを進める
            turn++;
        }


    }

    public class GameCharacter
    {

        private int hp;

        /// <summary>
        /// スタブは３回攻撃すると必ず倒されるキャラクターとして用意
        /// </summary>
        public GameCharacter()
        {
            hp = GetAttack() * 3;
        }

        /// <summary>
        /// 攻撃力を取得
        /// スタブで実装されている
        /// </summary>
        /// <returns></returns>
        public int GetAttack()
        {
            return 10;
        }

        public bool IsDead()
        {
            return hp <= 0;
        }

        public void IsHit(int damage)
        {
            hp -= damage;
        }

    }

}
