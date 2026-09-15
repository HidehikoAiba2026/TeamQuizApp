using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp
{
    /*******************************************/
    /*      　　Questionクラスの定義  　　     */
    /*******************************************/
    public class Question
    {
        /*******************************************/
        /*               プロパティ                */
        /*      クラスの外部から書き換え可能       */
        /*******************************************/
        public string Text { get; set; } = "";
        public string[] Choices { get; set; } = new string[4];
        public int CorrectIndex { get; set; }
    }


    /*******************************************/
    /*      QuestionLoaderクラスの定義 　     */
    /*******************************************/
    internal class QuestionLoader
    {
        /*******************************************/
        /*           　　フィールド  　            */
        /*******************************************/
        // Question型リスト変数(_questions)のインスタンス化
        // Question型は、QuestionLoader.csで定義
        private readonly List<Question> _questions = new List<Question>();

        // Random型変数(_rand)のインスタンス化
        // Random型は、標準定義
        private readonly Random _rand = new Random();

        /********************************************/
        /*  コンストラクター(と呼ばれるメソッド)    */
        /*  QuestionLoaderクラスの初期化            */
        /*  CSVファイルからクイズの問題データを読み */
        /*  込み、_questionsに格納する              */
        /********************************************/
        public QuestionLoader(string path = "questions.csv")
        {
            string csvPath = Path.Combine(AppContext.BaseDirectory, path);

            // CSVファイルの中身をすべて読み込み、1行ずつループ処理
            foreach (string line in File.ReadAllLines(csvPath))
            {
                // 行の先頭が "question" で始まっていたら、それはデータの見出し
                // （ヘッダー行）とみなしてスキップ
                if (line.StartsWith("question")) continue;

                // 1行の文字列を、(,)で区切ってstring型配列(cols)に格納
                string[] cols = line.Split(',');

                // (,)で区切ったデータを Question型に格納し、リスト(_questions)に追加
                _questions.Add(new Question
                {
                    // 1列目を問題文にする
                    Text = cols[0],

                    // 2〜5列目を4つの選択肢にする
                    Choices = new[] { cols[1], cols[2], cols[3], cols[4] },

                    // 6列目を数値に変換して正解の番号にする
                    CorrectIndex = int.Parse(cols[5])
                });
            }
        }

        /*******************************************/
        /*           　　メソッド　  　            */
        /*    public なので外部から呼び出し可能    */
        /*******************************************/
        public Question GetRandomQuestion()
        {
            // 乱数を生成
            int idx = _rand.Next(_questions.Count);

            // ランダムなidx番号を、呼び出し元に返す
            return _questions[idx];
        }
    }
}
