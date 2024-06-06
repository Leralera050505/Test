using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using  Demkaaaa.DB;
using Demkaaaa.HelpClass;
using Demkaaaa.Windows;
using static Demkaaaa.HelpClass.EFClass;


namespace Demkaaaa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TbName.Text)  )
            {
                string[] FIO = TbName.Text.Split(' ');
                string firstname = FIO[0];
                string lastname = FIO[1];
                string patronymic = FIO[2];

                Worker worker = new Worker();
                worker = Contexts.Worker.Where (i => i.FirstName == firstname
                && i.LastName == lastname
                && i.Patronymic == patronymic).FirstOrDefault();
                
                if (worker != null )
                {
                    UserClass.Worker = worker;
                    Menu1Window menu1Window = new Menu1Window();
                    menu1Window.Show();
                    this.Close();
                }
                
            }
        }
    }
}
