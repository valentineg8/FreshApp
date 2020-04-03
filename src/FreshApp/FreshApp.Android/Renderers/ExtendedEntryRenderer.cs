using System;
using Android.Content;
using FreshApp.Controls;
using FreshApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace FreshApp.Droid.Renderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        public ExtendedEntryRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var view = (ExtendedEntry)Element;


                if (!view.HasBorder)
                {
                    Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            }
        }
    }
}
