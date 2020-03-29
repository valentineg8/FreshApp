using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FreshApp.Controls
{
    public partial class SidebarControl : ContentView
    {
        public SidebarControl()
        {
            InitializeComponent();
        }
        void Button_Clicked(object sender, EventArgs e)
        {
            var target = sender as Button;
            var parent = target.Parent as FlexLayout;
            var height = target.Height - sectionIndicator.Height;
            var newBound = new Rectangle(sectionIndicator.Bounds.X, parent.Y + target.Y + (height / 2), sectionIndicator.Bounds.Width, sectionIndicator.Bounds.Height);
            sectionIndicator.LayoutTo(newBound, 100, Easing.Linear);
        }
    }
}
