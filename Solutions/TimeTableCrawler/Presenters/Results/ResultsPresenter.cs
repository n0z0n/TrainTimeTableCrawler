namespace TimeTableCrawler.Presenters.Results
{
    using System.Windows.Forms;

    using TimeTableCrawler.Commons;
    using TimeTableCrawler.Models.Results;
    using TimeTableCrawler.View.Results;
    using TimeTableCrawler.ViewModel.Results;

    public class ResultsPresenter : IPresenter
    {
        private readonly ResultsModel model;

        private readonly ResultsView view;

        private readonly ResultsViewModel viewModel;

        public ResultsPresenter()
        {
            this.view = new ResultsView();
            this.model = new ResultsModel();
            this.viewModel = new ResultsViewModel();
        }

        public ModelBase Model
        {
            get
            {
                return this.model;
            }
        }

        public UserControl View
        {
            get
            {
                return this.view;
            }
        }

        public ViewModelBase ViewModel
        {
            get
            {
                return this.viewModel;
            }
        }
    }
}