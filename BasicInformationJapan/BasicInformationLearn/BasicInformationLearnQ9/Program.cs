using System;
using System.Threading;
using System.Collections.Generic;
namespace BasicInformationLearnQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> dataList = new List<List<int>>();
            // 初期の配列状態を表す
            dataList.Add(new List<int>() { 0, 1, 1, 1, 1, 1, 1, 0 });
            dataList.Add(new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 });
            dataList.Add(new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 });
            dataList.Add(new List<int>() { 0, 1, 1, 1, 1, 0, 0, 0 });
            dataList.Add(new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 });
            dataList.Add(new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 });
            dataList.Add(new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 });
            dataList.Add(new List<int>() { 0, 1, 0, 0, 0, 0, 0, 0 });

            // 初期状態の描画をする
            foreach (var dataRow in dataList) {
                foreach (var dataCeil in dataRow) {
                    Console.Write("|" + dataCeil.ToString() + "|");
                }
                Console.Write("\r\n");
                // ちょっとわかりやすくアニメーション
                Thread.Sleep(1000);
            }
            // 方向切り替えアクション
            Thread.Sleep(2000);
            Console.Write("\r\n");
            Console.Write("\r\n");

            List<List<int>> dataAfterList = new List<List<int>>();

            for (var i = 0; i < dataList.Count; i++)
            {
               dataAfterList.Add(new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0 });
            }

            for (var i = 0; i < dataList.Count; i++) {
                for (var j = 0; j < dataList[i].Count; j++) {
                    dataAfterList[j][dataList.Count - (i + 1)] = dataList[i][j];
                }
            }

            for (var i = 0; i < dataList.Count; i++)
            {
                for (var j = 0; j < dataList[i].Count; j++)
                {
                    Console.Write("|" + dataAfterList[i][j] + "|");
                }
                Console.Write("\r\n");
                Thread.Sleep(1000);
            }
        }
    }
}
