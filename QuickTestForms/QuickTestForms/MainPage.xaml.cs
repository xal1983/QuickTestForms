using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace QuickTestForms
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    int x;
    void Button_Clicked(object sender, EventArgs e)
    {
      lblResult.Text = $"Button clicked {++x} times.{Environment.NewLine}Two lines.";
      if (Device.OS == TargetPlatform.iOS)
        iosLabel.Text = lblResult.Text;

      
    }
  }
}
