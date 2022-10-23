using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Warehouser_WPF
{
    /// <summary>
    /// Win_Main.xaml の相互作用ロジック
    /// </summary>
    public partial class Win_Main : Window
    {
        public Win_Main()
        {
            InitializeComponent();
            Main_Frame.Content = new Page_Main();
        }

        private void Class_Win_Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
