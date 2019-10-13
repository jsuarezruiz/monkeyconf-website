using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonkeyConf.ViewModels
{
    public class HomeViewModel : BindableObject
    {
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
    }
}