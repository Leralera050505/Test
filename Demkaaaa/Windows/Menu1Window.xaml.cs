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
using Demkaaaa.DB;
using Demkaaaa.Windows;
using static Demkaaaa.HelpClass.EFClass;
using Demkaaaa.HelpClass;

namespace Demkaaaa.Windows
{
    /// <summary>
    /// Логика взаимодействия для Menu1Window.xaml
    /// </summary>
    public partial class Menu1Window : Window
    {
        public Menu1Window()
        {
            InitializeComponent();
            
            if (UserClass.Worker.IdPost == 1)
            {
                btnds.Visibility = Visibility.Collapsed;
            }
            if (UserClass.Worker.IdPost == 2)
            {
                btndsf.Visibility = Visibility.Collapsed;
                btnds.Visibility = Visibility.Collapsed;
            }
            if (UserClass.Worker.IdPost == 3)
            {
                btndsf.Visibility = Visibility.Collapsed;
                btnds.Visibility = Visibility.Collapsed;
                btndsfw.Visibility = Visibility.Collapsed;
            }
            if (UserClass.Worker.IdPost == 4)
            {
              
                btndsfw.Visibility = Visibility.Collapsed;
                btndss.Visibility = Visibility.Collapsed;
            }
            
        }

        private void btnds_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
            this.Close();
        }
    }
}
