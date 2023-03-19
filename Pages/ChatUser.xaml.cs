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
    /// Логика взаимодействия для ChatUser.xaml
    /// </summary>
    public partial class ChatUser : Page
    {
        public int pageNumber;
        public MainWindow mainWindow;
        public ChatUser(MainWindow _mainWindow, int _pageNumber)
        {
            InitializeComponent();
            pageNumber = _pageNumber;
            mainWindow = _mainWindow;
        }

        private void GoBack(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                mainWindow.frame.NavigationService.Navigate(new Statement(mainWindow));
            }
            else if (pageNumber == 2)
            {
                mainWindow.frame.NavigationService.Navigate(new Speciality(mainWindow));
            }
            else if (pageNumber == 3)
            {
                mainWindow.frame.NavigationService.Navigate(new Scans(mainWindow));
            }
            else if (pageNumber == 4)
            {
                mainWindow.frame.NavigationService.Navigate(new Contacts(mainWindow));
            }
            else if (pageNumber == 5)
            {
                mainWindow.frame.NavigationService.Navigate(new Profile(mainWindow));
            }
        }
    }
}
