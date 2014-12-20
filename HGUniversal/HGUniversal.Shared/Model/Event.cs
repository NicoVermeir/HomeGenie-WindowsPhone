using System;

namespace HGUniversal.Model
{
    public class Event
    {
        public String Domain { get; set; }
        public String Source { get; set; }
        public String Description { get; set; }
        public String Property { get; set; }
        public String Value { get; set; }
        public DateTime Timestamp { get; set; }
        public Double UnixTimestamp { get; set; }
    }
}
