using System.Collections.Generic;

namespace MonkeyConf.Models
{
    public class Schedule
    {
        public string Title { get; set; }
        public List<TimeTrackInfo> Info { get; set; }
    }
}