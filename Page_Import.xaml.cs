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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Warehouser_WPF
{
    /// <summary>
    /// Page_Import.xaml の相互作用ロジック
    /// </summary>
    public partial class Page_Import : Page
    {
        public Page_Import()
        {
            InitializeComponent();
        }

        private void Import_Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (App.win_Start != null && App.win_Start.win_Main != null)
                App.win_Start.win_Main.Main_Frame.GoBack();
        }
    }
}
