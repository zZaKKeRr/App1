using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

public class MainPage : ContentPage
{
    public MainPage()
    {
        var stackLayout = new StackLayout
        {
            Padding = new Thickness(0, 20, 0, 0),
            Children = {
new BoxView { Color = Color.Green, Margin = new Thickness (20) },
new BoxView { Color = Color.Blue, Margin = new Thickness (10, 25) },
new BoxView { Color = Color.Red, Margin = new Thickness (0, 20, 15, 5) }
}
        };
        Content = stackLayout;
    }
}