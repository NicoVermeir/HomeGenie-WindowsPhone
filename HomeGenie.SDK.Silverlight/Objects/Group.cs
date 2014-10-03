using System.Collections.ObjectModel;

namespace HomeGenie.SDK.Objects
{
    public class Group
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //
        public ObservableCollection<Module> Modules { get; set; }

        //
        public Group()
        {
            Modules = new ObservableCollection<Module>();
        }
    }
}
