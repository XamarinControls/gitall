using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using GitAll.Forms.Controls;
using GitAll.iOS.Renderer;

[assembly: ExportRenderer(typeof(BindablePicker), typeof(BindablePickerRenderer))]
namespace GitAll.iOS.Renderer
{
    public class BindablePickerRenderer : PickerRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;
				Control.TextColor = UIColor.White;

                bool alignmentRight = bool.Parse((e.NewElement as BindablePicker).AlignmentRight.ToString());

                if (alignmentRight == true)
                {
                    Control.TextAlignment = UITextAlignment.Right;
                }                    
            }
        }
    }
}
