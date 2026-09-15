using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TeamQuizApp
{
    internal class UiUpdater
    {
        private readonly Label _questionLabel;
        private readonly Button[] _buttons;
        private readonly ListBox _log;

        public UiUpdater(Label questionLabel, Button[] buttons, ListBox log)
        {
            _questionLabel = questionLabel;
            _buttons = buttons;
            _log = log;
        }

        public void ShowQuestion(Question q)
        {
            _questionLabel.Text = q.Text;
            for (int i = 0; i < 4; i++)
            {
                _buttons[i].Text = q.Choices[i];
            }
        }

        public void LogResult(string msg)
        {
            _log.Items.Add(msg);
        }
    }
}
