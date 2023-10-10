namespace GreetingMauiApp.Views
{
    public partial class GreetingPage : ContentPage
    {
        public GreetingPage(string greeting)
        {
            InitializeComponent();
            GreetingLabel.Text = greeting;
        }

        private void OnOkButtonClicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
