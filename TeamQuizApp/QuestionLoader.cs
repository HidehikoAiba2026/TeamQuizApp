using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp
{
    public class Question
    {
        public string Text { get; set; } = "";
        public string[] Choices { get; set; } = new string[4];
        public int CorrectIndex { get; set; } 
    }
    internal class QuestionLoader
    {
        private readonly List<Question> _questions = new List<Question>();
        private readonly Random _rand = new Random();

        public QuestionLoader(string path = "questions.csv")
        {
            string csvPath = Path.Combine(AppContext.BaseDirectory, path);
            foreach(var line in File.ReadAllLines(csvPath))
            {
                if (line.StartsWith("question")) continue;
                var cols = line.Split(',');
                _questions.Add(new Question
                {
                    Text = cols[0],
                    Choices = new[] { cols[1], cols[2], cols[3], cols[4] },
                    CorrectIndex = int.Parse(cols[5])
                });
            }
        }
        public Question GetRandomQuestion()
        {
            int idx = _rand.Next(_questions.Count);
            return _questions[idx];
        }
    }
}
