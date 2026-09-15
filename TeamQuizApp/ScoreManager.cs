using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp
{
    public class ScoreManager
    {
        public int CorrectCount { get; private set; }
        public int TotalCount { get; private set; }

        public void Record(bool isCorrect)
        {
            TotalCount++;
            if (isCorrect) CorrectCount++;
        }

        public string GetResult()
        {
            if (TotalCount == 0) return "正解数: 0 / 0 (正解数 0.0%) ";
            return $"正解数： {CorrectCount} / {TotalCount} (正答率{((double)CorrectCount / TotalCount * 100):F1};)%";
        }
    }
}

