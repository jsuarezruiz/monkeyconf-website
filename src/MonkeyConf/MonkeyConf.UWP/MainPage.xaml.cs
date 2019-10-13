namespace MonkeyConf.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadApplication(new MonkeyConf.App());
        }
    }
}