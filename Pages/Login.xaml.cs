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

namespace SomeName.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public MainWindow mainWindow;
        public Login(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            if (login.Text == "1")
            {
                mainWindow.frame.Navigate(new DataBaseView(mainWindow));                
            }
            else
            {
                mainWindow.frame.Navigate(new Profile(mainWindow));
            }
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new Register(mainWindow));       
        }
    }
}
