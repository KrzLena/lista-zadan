namespace zadanie
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text?.Trim() ?? "";
            string password = PasswordEntry.Text ?? "";

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageLabel.Text = "Uzupełnij wszystkie pola.";
                return;
            }

            if (email == "admin@zsm.pl" && password == "1234")
            {
                await DisplayAlert("Sukces", "Zalogowano pomyślnie!", "OK");
                await Navigation.PopAsync(); 
            }
            else
            {
                MessageLabel.Text = "Nieprawidłowy e-mail lub hasło.";
            }
        }
    }
}
