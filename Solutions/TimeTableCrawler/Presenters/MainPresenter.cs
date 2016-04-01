namespace TimeTableCrawler.Presenters
{
    using System.Windows.Forms;

    using TimeTableCrawler.Models;
    using TimeTableCrawler.Presenters.Results;
    using TimeTableCrawler.Presenters.Settings;
    using TimeTableCrawler.View;
    using TimeTableCrawler.ViewModel;

    public class MainPresenter
    {
        private readonly ResultsPresenter resultsPresenter;

        private readonly SettinsPresenter settingPresenter;

        private readonly MainView view;

        private MainModel model;

        private MainViewModel viewModel;

        public MainPresenter()
        {
            this.view = new MainView();
            this.viewModel = new MainViewModel();
            this.model = new MainModel();

            this.settingPresenter = new SettinsPresenter();
            this.resultsPresenter = new ResultsPresenter();

            this.view.SetSettingsView(this.settingPresenter.View);
            this.view.SetResultsView(this.resultsPresenter.View);
        }

        public Form View
        {
            get
            {
                return this.view;
            }
        }
    }
}