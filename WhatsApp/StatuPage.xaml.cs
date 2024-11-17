using System.Collections.ObjectModel;

namespace WhatsApp;

public partial class StatuPage : ContentPage
{
    public ObservableCollection<FriendStatus> FriendStatuses { get; set; }
    public StatuPage()
	{
		InitializeComponent();

        // بيانات الحالات الخاصة بالأصدقاء
            FriendStatuses = new ObservableCollection<FriendStatus>
            {
                new FriendStatus { Name = "أحمد", Time = "قبل 10 دقائق", ProfileImage = "profile_image.jpg" },
                new FriendStatus { Name = "سارة", Time = "قبل ساعة", ProfileImage = "profile_image.jpg" },
                new FriendStatus { Name = "خالد", Time = "اليوم 09:30", ProfileImage = "profile_image.jpg" }
                // أضف المزيد من الحالات هنا حسب الحاجة
            };

        BindingContext = this;
    }
    public async void OnStatusTapped(object sender, EventArgs e)
    {
        try
        {
            // استخدم FilePicker لفتح نافذة اختيار الملفات
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "اختر صورة",
                FileTypes = FilePickerFileType.Images
            });

            if (result != null)
            {
                // يمكنك الآن التعامل مع الصورة المختارة. مثلاً، يمكنك عرضها في Image.
                var stream = await result.OpenReadAsync();
                // قم بتحديث صورة الحالة هنا
            }
        }
        catch (Exception ex)
        {
            // التعامل مع أي أخطاء محتملة هنا
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
// نموذج بيانات للحالة
 public class FriendStatus
{
    public string Name { get; set; }
    public string Time { get; set; }
    public string ProfileImage { get; set; }
}
