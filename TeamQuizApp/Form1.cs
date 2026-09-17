namespace TeamQuizApp
{
    public partial class Form1 : Form
    {
        /*******************************************/
        /*               フィールド                */
        /*******************************************/

        // QuestionLoader型の変数(loader)定義
        // questionLoader.csで定義されている
        // private readonlyは、クラス内で使用できる変数で、読み込みのみ可能な変数の意味
        private readonly QuestionLoader loader;

        // AnswerChecker型の変数(checker)定義
        // AnswerChecker.csで定義
        private readonly AnswerChecker checker;

        // ScoreManager型の変数(score)定義
        // ScoreManager.csで定義
        private readonly ScoreManager score;

        // UiUpdater型の変数(ui)定義
        // UiUpdater.csで定義
        private readonly UiUpdater ui;

        // Question型の変数(current)定義
        // questionLoader.csで定義
        private Question current;

        /*******************************************/
        /*   コンストラクター(と呼ばれるメソッド)  */
        /*   Form1の初期化                         */
        /*******************************************/
        public Form1()
        {
            // VisualStudioが自動生成する
            // 追加したコントロールのインスタンス化
            InitializeComponent();

            // フィールドで定義した変数のインスタンス化
            loader = new QuestionLoader();
            checker = new AnswerChecker();
            score = new ScoreManager();
            ui = new UiUpdater(questionLabel,
                new[] { answerButton1, answerButton2, answerButton3, answerButton4 },
                logListBox);

            // Form1class内部で使用できるメソッド
            LoadNextQuestion();
        }

        /*******************************************/
        /*   イベントハンドラ(と呼ばれるメソッド)  */
        /* 4つの回答ボタンをクリックすると呼ばれる */
        /*******************************************/
        private void answerButton_Click(object sender, EventArgs e)
        {
            // クリックされたオブジェクト（sender）を Button 型に変換
            // Button?（ヌル許容型）は、ボタン以外のものが原因で動いた場合は null になる
            Button? btn = sender as Button;

            // クリックされたボタンが、1〜4番目のうち何番目のボタンか（0〜3のインデックス番号）を調査
            int index = Array.IndexOf(new[] { answerButton1, answerButton2, answerButton3, answerButton4 }, btn);

            // 正誤判定を行う(checker.CheckerAnswer()メソッドの呼び出し)
            // 正解なら true、不正解なら false を変数 result に代入
            bool result = checker.CheckAnswer(current, index);

            // score.Record()メソッドを実行し、正誤結果（result）を記録
            score.Record(result);

            // 三項演算子
            // trueなら「正解！」、falseなら「不正解...」を表示
            ui.LogResult(result ? "正解！" : "不正解...");

            // 現在の累計スコアを取得し、画面に続けて表示
            // score.GetResult()メソッドを実行
            ui.LogResult(score.GetResult());

            // 次の問題を表示
            LoadNextQuestion();
        }

        /*******************************************/
        /*                メソッド                 */
        /*******************************************/
        // 問題を乱数で表示
        private void LoadNextQuestion()
        {
            // Question型変数(current)にQuestionLoader型変数loader
            // のメソッドGetRandomQuestion()を実行した結果(乱数)を代入
            current = loader.GetRandomQuestion();

            // UiUpdater型変数uiのメソッドShowQuestionを実行
            // 次の問題文が表示される
            ui.ShowQuestion(current);
        }
    }
}
