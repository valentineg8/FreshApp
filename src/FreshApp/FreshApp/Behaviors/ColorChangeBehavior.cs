using System;
using Xamarin.Forms;

namespace FreshApp.Behaviors
{
    public class ColorChangeBehavior : Behavior<VisualElement>
    {
        public static readonly BindableProperty ColorProperty =
        BindableProperty.Create(nameof(Color), typeof(Color), typeof(ColorChangeBehavior), null, propertyChanged: ColorChanged);
        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public VisualElement AssociatedObject { get; private set; }
        protected override void OnAttachedTo(VisualElement bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
        }
        static void ColorChanged(BindableObject view, object oldValue, object newValue)
        {
            var control = view as ColorChangeBehavior;
            control.AssociatedObject.ColorTo((Color)oldValue, (Color)newValue, c => control.AssociatedObject.BackgroundColor = c, 200, Easing.Linear);;
        }
    }
}
