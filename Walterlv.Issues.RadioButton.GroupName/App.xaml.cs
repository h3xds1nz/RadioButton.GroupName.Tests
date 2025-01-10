using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Walterlv.Issues
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var button = new Button
            {
                Content = "new window",
            };
            button.Click += Button_Click;
            new Window
            {
                Content = button,
                Width = 200,
                Height = 160,
            }.Show();
        }

        int counter = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    if ((counter & 1) == 0)
            new MainWindow().Show();
            //else
            //    new MainWindow2().Show();

            counter++;
        }
    }
}
