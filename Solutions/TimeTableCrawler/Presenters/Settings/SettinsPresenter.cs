namespace TimeTableCrawler.Presenters.Settings
{
    using System.Windows.Forms;

    using TimeTableCrawler.Commons;
    using TimeTableCrawler.Models.Settings;
    using TimeTableCrawler.View.Settings;
    using TimeTableCrawler.ViewModel.Settings;

    public class SettinsPresenter : IPresenter
    {
        private readonly SettingModel model;

        private readonly SettingView view;

        private readonly SettingViewModel viewModel;

        public SettinsPresenter()
        {
            this.view = new SettingView();
            this.model = new SettingModel();
            this.viewModel = new SettingViewModel();
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