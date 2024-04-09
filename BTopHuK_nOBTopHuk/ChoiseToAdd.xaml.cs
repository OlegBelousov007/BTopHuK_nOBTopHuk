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
    /// Логика взаимодействия для ChoiseToAdd.xaml
    /// </summary>
    public partial class ChoiseToAdd : Window
    {
        Razdel razdel;
        public ChoiseToAdd(Razdel razdel)
        {
            InitializeComponent();
            this.razdel = razdel;
        }

        private void CreateRaz_Click(object sender, RoutedEventArgs e)
        {
            razdel.Name = Totot.Text ;
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            razdel.IdIcon = "4";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            razdel.IdIcon = "7";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            razdel.IdIcon = "5";
        }
    }
}
