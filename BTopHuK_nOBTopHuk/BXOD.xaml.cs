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

namespace BTopHuK_nOBTopHuk
{
    /// <summary>
    /// Логика взаимодействия для BXOD.xaml
    /// </summary>
    public partial class BXOD : Window
    {
        public BXOD()
        {
            InitializeComponent();
        }

        private void Addor_Click(object sender, RoutedEventArgs e)
        {
            MainWindow bobo = new MainWindow();
            bobo.Show();
            this.Close();
        }
    }
}
