using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ReleaseApp.Effects;

[assembly: ResolutionGroupName(ReleaseApp.Effects.UnderlineLabelEffect.EffectNamespace)]
[assembly: ExportEffect(typeof(UnderlineLabelEffect), nameof(UnderlineLabelEffect))]
namespace ReleaseApp.Droid.Effects
{
    public class UnderlineLabelEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            SetUnderline(true);
        }
        protected override void OnDetached()
        {
            SetUnderline(false);
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if(args.PropertyName == Label.TextProperty.PropertyName || args.PropertyName == Label.FormattedTextProperty.PropertyName)
            {
                SetUnderline(true);
            }
        }
        
        private void SetUnderline(bool underline)
        {
            try
            {
                var textView = Control as TextView;
                if (underline)
                {
                    textView.PaintFlags |= PaintFlags.UnderlineText;
                }
                else
                {
                    textView.PaintFlags &= ~PaintFlags.UnderlineText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot underline Label. Error: ", ex.Message);
            }
        }
    }
}