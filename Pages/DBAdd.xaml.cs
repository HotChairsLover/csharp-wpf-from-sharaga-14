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
    /// Логика взаимодействия для DBAdd.xaml
    /// </summary>
    public partial class DBAdd : Page
    {
        public MainWindow mainWindow;
        public bool isChange = false;
        public DBAdd(MainWindow _mainWindow, bool change)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            isChange = change;
        }

        private void Done(object sender, EventArgs e)
        {
            mainWindow.frame.Navigate(new Pages.DataBaseView(mainWindow));
        }

        private void Cancel(object sender, EventArgs e)
        {
            mainWindow.frame.Navigate(new Pages.DataBaseView(mainWindow));
        }
    }
}
