using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Warehouser_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal Win_Start? win_Start = null;
        private void Hiro_We_Go(object sender, StartupEventArgs e)
        {
            win_Start = new();
            win_Start.Show();
        }

    }
}
