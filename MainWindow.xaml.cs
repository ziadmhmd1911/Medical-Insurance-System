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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace ZIASystem
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Controllers.Login login = new Controllers.Login(ssn_txt.Text, password_txt.Password);
            int log = login.loging();
            if (log == 0)
            {
                Views.AdminWindow adminWindow = new Views.AdminWindow();
                this.Close();
                adminWindow.ShowDialog();
            }
            else if (log == 1)
            {
                Views.EmployerWindow employerWindow = new Views.EmployerWindow();
                this.Close();
                employerWindow.ShowDialog();
            }
        }
    }
}
