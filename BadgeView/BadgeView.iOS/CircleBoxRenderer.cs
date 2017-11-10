using Xamarin.Forms;
using BadgeView.iOS;
using BadgeView;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(CircleBox), typeof(CircleBoxRenderer))]
namespace BadgeView.iOS
{
    public class CircleBoxRenderer : BoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Element != null)
            {
                Layer.MasksToBounds = true;
                UpdateCornerRadius(Element as CircleBox);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CircleBox.CornerRadiusProperty.PropertyName)
            {
                UpdateCornerRadius(Element as CircleBox);
            }
        }

        void UpdateCornerRadius(CircleBox box)
        {
            Layer.CornerRadius = (float)box.CornerRadius;
        }
    }
}