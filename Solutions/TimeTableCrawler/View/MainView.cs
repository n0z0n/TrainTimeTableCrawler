namespace TimeTableCrawler.View
{
    using System.Windows.Forms;

    public partial class MainView : Form
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        public void SetResultsView(UserControl resultsView)
        {
            this.tableLayoutPanel.Controls.Add(resultsView, 0, 1);
        }

        public void SetSettingsView(UserControl settingsView)
        {
            this.tableLayoutPanel.Controls.Add(settingsView, 0, 0);
        }
    }
}