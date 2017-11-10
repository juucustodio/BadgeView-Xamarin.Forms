using System;
using Xamarin.Forms;

namespace BadgeView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BadgeNotifications.Text = "2";
        }

        private void AddNotification(object sender, EventArgs e)
        {
            if (BadgeNotifications.Text != "99+" && int.Parse(BadgeNotifications.Text) < 99 )
                BadgeNotifications.Text = (int.Parse(BadgeNotifications.Text)+1).ToString();
            else
            {
                BadgeNotifications.Text = "99+";
            }
        }
    }
}
