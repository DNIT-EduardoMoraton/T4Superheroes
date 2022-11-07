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

namespace T4Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm;
        public MainWindow()
        {
            vm = new MainWindowVM();
            this.DataContext = vm;
        }

        private void prevArrowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            vm.manageList(-1);
        }

        private void NextArrowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            vm.manageList(1);
        }


    }
}
