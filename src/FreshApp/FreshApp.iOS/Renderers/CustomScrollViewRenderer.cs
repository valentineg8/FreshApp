using System;
using CoreGraphics;
using FreshApp.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(ScrollView), typeof(CustomScrollViewRenderer))]
namespace FreshApp.iOS.Renderers
{
    public class CustomScrollViewRenderer : ScrollViewRenderer
    {

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            this.Scrolled += PreventingTopBounce;

            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
                this.ContentInsetAdjustmentBehavior = UIScrollViewContentInsetAdjustmentBehavior.Never;
        }

        private void PreventingTopBounce(object sender, EventArgs e)
        {
            if (this.ContentOffset.Y < 0)
                this.SetContentOffset(new CGPoint(this.ContentOffset.X, 0), false);
        }
    }
}
