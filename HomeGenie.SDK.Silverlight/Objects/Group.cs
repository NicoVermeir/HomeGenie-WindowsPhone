using System.Collections.Generic;

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
        public IList<Module> Modules { get; set; }

        public Group()
        {
            Modules = new List<Module>();
        }
    }
}
