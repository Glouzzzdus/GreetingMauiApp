using GreetingLib;

namespace GreetingMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGreetingButtonClicked(object sender, EventArgs e)
        {
            var name = nameEntry.Text?.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                WarningLabel.Text = "Please enter a name!";
                WarningLabel.IsVisible = true;
            }
            else
            {
                var greeting = GreetingGenerator.GenerateGreeting(name);
                var greetingPage = new Views.GreetingPage(greeting);
                Navigation.PushAsync(greetingPage);
            }
        }

    }
}

