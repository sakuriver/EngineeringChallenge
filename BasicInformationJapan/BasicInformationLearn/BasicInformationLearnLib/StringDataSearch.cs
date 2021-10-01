using System;
using System.Collections.Generic;

namespace BasicInformationLearnLib
{
    /// <summary>
    /// 文字列のデータ検索のアルゴリズム関係の対応をするクラス
    /// 基本情報技術者試験の午後問の問８に該当
    /// </summary>
    public class StringDataSearch
    {


        /// <summary>
        /// 検索対象文字列
        /// </summary>
        private List<char> searchText { get; set; }


        /// <summary>
        /// 検索文字列側
        /// </summary>
        private List<char> pat;

        public List<char> GenerateBitMask()
        {
            return new List<char>();
        }
    }
}
