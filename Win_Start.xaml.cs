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
    /// Win_Start.xaml の相互作用ロジック
    /// </summary>
    public partial class Win_Start : Window
    {
        public Win_Start()
        {
            InitializeComponent();
            new System.Threading.Thread(() =>
            {

            }).Start();
        }

        private void Win_Load()
        {

        }
    }
}
