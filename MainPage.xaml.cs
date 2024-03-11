// MainPage.xaml.cs
using voicemanagementexplains.Platforms.Android;
// Diğer using direktifleri...

namespace voicemanagementexplains
{
    public partial class MainPage : ContentPage
    {
        private VoiceCommandHandler voiceCommandHandler;

        public MainPage()
        {
            InitializeComponent();
            // MyRegisterButton'ı VoiceCommandHandler'a parametre olarak geçirin
            voiceCommandHandler = new VoiceCommandHandler(MyRegisterButton);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Sesli komutları dinlemek için voiceCommandHandler'ı kullanın
            var cancellationToken = new CancellationToken(); // Uygun bir CancellationToken sağlayın
            voiceCommandHandler.InitializeAsync(cancellationToken);
        }

        private void MyRegisterButton_Clicked(object sender, EventArgs e)
        {
            // Kayıt olma işlemini gerçekleştirin
        }
    }
}