using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Pomodoro
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "Simple Pomodoro App";
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            var currentPosition = Tb1.SelectionStart - 1;
            var text = ((TextBox)sender).Text;

            var regex = new Regex("^[0-9]*$");

            if(!regex.IsMatch(text))
            {
                var foundChar = Regex.Match(Tb1.Text, @"[^0-9]*$");
                if (foundChar.Success)
                {
                    Tb1.Text = Tb1.Text.Remove(foundChar.Index, 1);
                }
                Tb1.Select(currentPosition, 0);
            }
        }
    }
}
