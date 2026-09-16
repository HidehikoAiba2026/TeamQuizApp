using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp
{
    public class ScoreManager
    {
        /*******************************************/
        /*               プロパティ                */
        /*      クラスの外部から書き換え可能       */
        /*******************************************/
        public int CorrectCount { get; private set; }
        public int TotalCount { get; private set; }

        /*******************************************/
        /*              　メソッド　               */
        /*          外部から呼び出し可能           */
        /*******************************************/
        // クイズが1問解かれるたびに呼び出され、成績をカウントアップ
        public void Record(bool isCorrect)
        {
            TotalCount++;
            if (isCorrect) CorrectCount++;
        }

        // 現在の「正解数 / 合計問題数」と「正答率（％）」を計算し、
        // 画面に表示
        public string GetResult()
        {
            if (TotalCount == 0) return "正解数: 0 / 0 (正解数 0.0%) ";
            return $"正解数： {CorrectCount} / {TotalCount} (正答率{((double)CorrectCount / TotalCount * 100):F1};)%";
        }
    }
}

