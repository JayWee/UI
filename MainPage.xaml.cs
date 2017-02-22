using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Toggle.Toggled += Toggle_Toggled;
            Slider1.ValueChanged += Slider1_ValueChanged;
            button1.Click += Button1_Click;
        }

        int NumButtonKlicks = 0;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NumButtonKlicks++;
            string NumButtonKlicksstr = Convert.ToString(NumButtonKlicks);
            BlockButton.Text = "Button wurde " + NumButtonKlicksstr + " mal gedrückt";
        }

        private void Slider1_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string Value = Convert.ToString(e.NewValue);
            BlockSlider.Text = Value;
        }

        private void Toggle_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggel = sender as ToggleSwitch;
            if (Toggle != null)
            {
                if (Toggle.IsOn == true)
                {
                    BlockToggle.Text = "Toggle On";
                }
                else
                {
                    BlockToggle.Text = "Toggle Off";
                }
            }
        }
    }
}
