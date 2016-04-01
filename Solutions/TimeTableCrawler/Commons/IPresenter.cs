namespace TimeTableCrawler.Commons
{
    using System.Windows.Forms;

    public interface IPresenter
    {
        ModelBase Model { get; }

        UserControl View { get; }

        ViewModelBase ViewModel { get; }
    }
}