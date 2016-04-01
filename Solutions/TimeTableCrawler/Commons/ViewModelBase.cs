namespace TimeTableCrawler.Commons
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using TimeTableCrawler.Annotations;

    public class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Error { get; private set; }

        public string this[string columnName]
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}