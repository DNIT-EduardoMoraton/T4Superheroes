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
        List<Superheroe> list;
        int listIndex;
        Superheroe currentHeroe;
        String navStr;
        public MainWindow()
        {
            list = Superheroe.GetSamples();
            InitializeComponent();
            navStr = listIndex + 1 + "/" + list.Count();
            listIndex = 0;
            currentHeroe = list[listIndex];
            mainDockPanel.DataContext = currentHeroe;
        }

        private void prevArrowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            manageList(-1);
        }

        private void NextArrowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            manageList(1);
        }

        private void manageList(int op)
        {
            int listsize = list.Count();
            int i = listIndex;
            i += op;
            if (i < 0)
                i = 0;
            else if (i > list.Count() - 1)
                i = list.Count() - 1;

            listIndex = i;
            currentHeroe.Nombre = list[listIndex].Nombre;
            currentHeroe.Imagen = list[listIndex].Imagen;
            currentHeroe.Xmen = list[listIndex].Xmen;
            currentHeroe.Heroe = list[listIndex].Heroe;
            currentHeroe.Vengador = list[listIndex].Vengador;
            navStr = listIndex + 1 + "/" + list.Count();
            currentSlideIndicatortextBlock.Text = navStr;

        }
    }
}
