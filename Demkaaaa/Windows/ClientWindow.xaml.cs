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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
            listCl.ItemsSource = Contexts.WV_Order.ToList();
        }
    }
}
