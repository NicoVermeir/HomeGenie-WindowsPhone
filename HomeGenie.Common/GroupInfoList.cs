using System.Collections.Generic;

namespace HomeGenie.Common
{
    public class GroupInfoList<T> : List<T>
    {
        public string Key { get; set; }


        public new IEnumerator<T> GetEnumerator()
        {
            return base.GetEnumerator();
        }
    }
}