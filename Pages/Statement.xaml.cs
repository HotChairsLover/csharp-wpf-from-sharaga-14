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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public MainWindow mainWindow;
        public Statement(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 550;
            mainWindow.Width = 800;
        }

        private void NextPage(object sender, EventArgs e)
        {
            mainWindow.frame.Navigate(new Speciality(mainWindow));                          
        }

        private void OpenChat(object sender, EventArgs e)
        {
            mainWindow.frame.NavigationService.Navigate(new ChatUser(mainWindow, 1));
        }

        private void OpenProfile(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new Login(mainWindow));
        }
    }
}
