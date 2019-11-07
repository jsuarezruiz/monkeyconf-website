using MonkeyConf.Models;
using MonkeyConf.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonkeyConf.ViewModels
{
    public class HomeViewModel : BindableObject
    {
        ObservableCollection<TimeTrackInfo> _schedule;

        public HomeViewModel()
        {
            LoadSchedule();
        }

        public ObservableCollection<TimeTrackInfo> Schedule
        {
            get { return _schedule; }
            set
            {
                _schedule = value;
                OnPropertyChanged();
            }
        }

        public ICommand TicketCommand => new Command(ExecuteTicket);
        public ICommand SponsorCommand => new Command<string>(ExecuteSponsor);
        public ICommand CallForPaperCommand => new Command(ExecuteCallForPaper);

        void ExecuteTicket()
        {
            Device.OpenUri(new Uri("https://www.koliseo.com/jsuarezruiz/monkey-conf-2019#/"));
        }

        void ExecuteSponsor(string sponsorUrl)
        {
            Device.OpenUri(new Uri(sponsorUrl));
        }

        void ExecuteCallForPaper()
        {
            Device.OpenUri(new Uri("https://www.koliseo.com/jsuarezruiz/monkey-conf-2019/r4p/5678082530738176#/talks"));
        }

        void LoadSchedule()
        {
            var eventSchedule = ScheduleService.Instance.GetEventSchedule();
            Schedule = new ObservableCollection<TimeTrackInfo>(eventSchedule[0].Info);
        }
    }
}