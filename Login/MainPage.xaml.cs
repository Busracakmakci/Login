namespace Login
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string nickName = nickNameEntry.Text;

            if (IsValidWalletInfo(nickName))
            {
                DisplayAlert("Başarılı", $"Giriş başarılı: {nickName}", "Tamam");
            }
            else
            {
                DisplayAlert("Hata", "Geçersiz.", "Tekrar Dene");
            }
        }

        private bool IsValidWalletInfo(string walletInfo)
        {
            // Basit bir doğrulama, burada gerçek bir doğrulama uygulanmalıdır
            return !string.IsNullOrWhiteSpace(walletInfo) && walletInfo.Length > 10;
        }
    }
 }


