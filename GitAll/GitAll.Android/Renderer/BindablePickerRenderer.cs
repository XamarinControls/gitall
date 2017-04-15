using Android.Views;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

using Android.Graphics.Drawables;

using GitAll.Droid.Renderer;
using GitAll.Forms.Controls;

[assembly: ExportRenderer(typeof(BindablePicker), typeof(BindablePickerRenderer))]
namespace GitAll.Droid.Renderer
{
    public class BindablePickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);
                gd.SetCornerRadius(15); // increase or decrease to changes the corner look
                Control.SetBackgroundDrawable(gd);

                bool alignmentRight = bool.Parse((e.NewElement as BindablePicker).AlignmentRight.ToString());

                if (alignmentRight == true)
                {
                    Control.Gravity = GravityFlags.Right;
                }
                
            }
        }
    }
}