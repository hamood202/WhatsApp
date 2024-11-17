using System.Collections.ObjectModel;

namespace WhatsApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Chat> Chats { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Chats = new ObservableCollection<Chat>
            {
                new Chat { Name = "أحمد", LastMessage = "مرحبا، كيف حالك", Time = "12:45 PM", Avatar = "profile_image.jpg" },
                new Chat { Name = "سارة", LastMessage = "أراك لاحقاً!", Time = "11:30 AM", Avatar = "profile_image.jpg" },
                // أضف المزيد من المحادثات هنا
            };

            BindingContext = this;
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // تنفيذ البحث
        }

        private void OnMenuClicked(object sender, EventArgs e)
        {
            // عرض القائمة
        }

        private void OnNewChatClicked(object sender, EventArgs e)
        {
            // بدء محادثة جديدة
        }
    }

    public class Chat
    {
        public string Name { get; set; }
        public string LastMessage { get; set; }
        public string Time { get; set; }
        public string Avatar { get; set; }
    }
}
