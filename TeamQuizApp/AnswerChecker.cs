using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp
{
    // 選んだボタンが正解かどうかを判定するクラス
    public class AnswerChecker
    {
        public bool CheckAnswer(Question q, int selectedIndex)
        {
            return q.CorrectIndex == selectedIndex;
        }
    }
}
