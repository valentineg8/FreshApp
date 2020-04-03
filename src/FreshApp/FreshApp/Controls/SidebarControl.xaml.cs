using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using FreshApp.Models;
using Xamarin.Forms;

namespace FreshApp.Controls
{
    public partial class SidebarControl : ContentView
    {
        bool IsMenuOpen;
        public static readonly BindableProperty CurrentCategoryChangedCommandProperty = BindableProperty.Create(nameof(CurrentCategoryChangedCommand), typeof(ICommand), typeof(SidebarControl), null);
        public static readonly BindableProperty CategoriesProperty = BindableProperty.Create(nameof(Categories), typeof(IEnumerable<Category>), typeof(SidebarControl), null);
        public static readonly BindableProperty CategorySelectedProperty = BindableProperty.Create(nameof(CategorySelected), typeof(Category), typeof(SidebarControl), null, BindingMode.TwoWay, propertyChanged: CurrentItemChange);
        public IEnumerable<Category> Categories
        {
            get { return (IEnumerable<Category>)GetValue(CategoriesProperty); }
            set { SetValue(CategoriesProperty, value); }
        }
        public ICommand CurrentCategoryChangedCommand
        {
            get { return (ICommand)GetValue(CurrentCategoryChangedCommandProperty); }
            set { SetValue(CurrentCategoryChangedCommandProperty, value); }
        }
        public Category CategorySelected
        {
            get { return (Category)GetValue(CategorySelectedProperty); }
            set { SetValue(CategorySelectedProperty, value); }
        }

        static void CurrentItemChange(object bindable, object oldValue, object newValue)
        {
            var control = (SidebarControl)bindable;
            var categories = control.FindByName("categoriesContainer") as FlexLayout;
            foreach (StackLayout stackLayout in categories.Children)
            {
                var label = stackLayout.FindByName<Label>("categoryTitle");
                if (((Category)newValue).Title == label.Text)
                {
                    control.MoveActiveIndicator(stackLayout);
                }
            }
        }

        public SidebarControl()
        {
            InitializeComponent();
        }

        void Category_Clicked(object sender, EventArgs e)
        {
            var label = ((StackLayout)sender).FindByName<Label>("categoryTitle");
            CategorySelected = Categories.FirstOrDefault(c => c.Title == label.Text);
            if (CurrentCategoryChangedCommand != null)
                if (CurrentCategoryChangedCommand.CanExecute(CategorySelected))
                    CurrentCategoryChangedCommand.Execute(CategorySelected);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            //Fix for Indicator
            foreach (StackLayout stackLayout in categoriesContainer.Children)
            {
                var label = stackLayout.FindByName<Label>("categoryTitle");
                if (CategorySelected.Title == label.Text)
                {
                    MoveActiveIndicator(stackLayout);
                }
            }
        }

        void MoveActiveIndicator(StackLayout target)
        {
            var parent = target.Parent as FlexLayout;
            sectionIndicator.TranslateTo(0, target.Y + parent.Y, 300, Easing.SpringOut);
        }

        void  Toggle_Menu(System.Object sender, System.EventArgs e)
        {
            Animation animateSection;
            if (IsMenuOpen)
                animateSection = new Animation(d => menuContainer.WidthRequest = d, 300, 80);
            else
                animateSection = new Animation(d => menuContainer.WidthRequest = d, 80, 300);
            animateSection.Commit(menuContainer, "MoreLikeSectionToggleAnimation", 16, 450, Easing.SpringIn);
            IsMenuOpen = !IsMenuOpen;
        }

        void SwipeGestureRecognizer_Swiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            Animation animateSection;
            if (IsMenuOpen)
                animateSection = new Animation(d => menuContainer.WidthRequest = d, 300, 80);
            else
                animateSection = new Animation(d => menuContainer.WidthRequest = d, 80, 300);
            animateSection.Commit(menuContainer, "MoreLikeSectionToggleAnimation", 16, 450, Easing.SpringIn);
            IsMenuOpen = !IsMenuOpen;
        }
    }
}
