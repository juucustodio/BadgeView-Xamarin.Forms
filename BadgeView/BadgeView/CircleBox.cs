using Xamarin.Forms;

namespace BadgeView
{
    public class CircleBox : BoxView
    {

        // Corner radius property.
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create("CornerRadius", typeof(double), typeof(CircleBox), 0.0);

        // Get and set the corner radius.
        public double CornerRadius
        {
            get { return (double) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
    }
}
