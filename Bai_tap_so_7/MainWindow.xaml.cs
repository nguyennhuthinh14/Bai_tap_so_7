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

namespace Bai_tap_so_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOk_click(object sender, RoutedEventArgs e)
        {
            HinhCN hcn = new HinhCN(4, 3);
            hcn.Chuvi();
            hcn.Dientich();
            HinhVuong hv = new HinhVuong(3);
            hv.Chuvi();
            hv.Dientich();
            HinhTron ht = new HinhTron(3);
            ht.Chuvi();
            ht.Dientich();
            MessageBox.Show("Chu vi HinhCN: " + hcn.Chuvi.ToString()
                + "\nDien Tich HinhCN: " + hcn.Dientich.ToString() + "\n"
                + "\nChu vi HinhVuong: " + hv.Chuvi.ToString()
                + "\nDien Tich HinhVuong: " + hv.Dientich.ToString() + "\n"
                + "\nChu vi HinhTron: " + ht.Chuvi.ToString();
                + "\nDien Tich HinhTron: " + ht.Dientich.ToString());           
        }
    }
}
