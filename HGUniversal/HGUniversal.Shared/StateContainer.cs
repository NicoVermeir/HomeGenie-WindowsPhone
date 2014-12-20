using System;
using HGUniversal.Model;

namespace HGUniversal
{
    public static class StateContainer
    {
        public static event EventHandler ConnectionUpdated;
        public static Connection CurrentConnection { get; set; }

        public static void AnnounceConnectionUpdated()
        {
            if (ConnectionUpdated != null) ConnectionUpdated(null, EventArgs.Empty);
        }
    }
}
