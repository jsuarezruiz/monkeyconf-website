using MonkeyConf.Models;
using System.Collections.Generic;

namespace MonkeyConf.Services
{
    public class ScheduleService
    {
        static ScheduleService _instance;

        public static ScheduleService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScheduleService();
                return _instance;
            }
        }

        public List<Schedule> GetEventSchedule()
        {
            return new List<Schedule>
            {
                // TODO:
            };
        }
    }
}