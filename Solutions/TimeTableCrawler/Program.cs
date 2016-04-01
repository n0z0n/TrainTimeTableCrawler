namespace TimeTableCrawler
{
    using System;
    using System.Windows.Forms;

    using TimeTableCrawler.Presenters;

    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainPresenter = new MainPresenter();
            Application.Run(mainPresenter.View);
        }
    }
}