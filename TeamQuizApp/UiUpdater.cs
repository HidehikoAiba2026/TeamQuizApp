using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TeamQuizApp
{
    /*******************************************/
    /*      　　UiUpdaterクラスの定義  　     */
    /*******************************************/
    internal class UiUpdater
    {
        /*******************************************/
        /*      　　　　フィールド　 　　 　　     */
        /*******************************************/
        private readonly Label _questionLabel;
        private readonly Button[] _buttons;
        private readonly ListBox _log;

        /*******************************************/
        /*      　　　コンストラクター 　 　　     */
        /*******************************************/
        public UiUpdater(Label questionLabel, Button[] buttons, ListBox log)
        {
            _questionLabel = questionLabel;
            _buttons = buttons;
            _log = log;
        }

        /*******************************************/
        /*               メソッド                  */
        /*******************************************/
        // 引数で受け取った問題データ(q)を、実際の画面に反映
        public void ShowQuestion(Question q)
        {
            _questionLabel.Text = q.Text;
            for (int i = 0; i < 4; i++)
            {
                _buttons[i].Text = q.Choices[i];
            }
        }

        /*******************************************/
        /*               メソッド                  */
        /*******************************************/
        // 結果を、画面のリストボックスに追加
        public void LogResult(string msg)
        {
            _log.Items.Add(msg);
        }
    }
}
