using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace T4Superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        List<Superheroe> list;
        int listIndex;

        private String navStr;

        public String NavStr
        {
            get { return navStr; }
            set { navStr = value; NotifyPropertyChanged("NavStr"); }
        }

        private Superheroe currentHeroe;

        public Superheroe CurrentHeroe
        {
            get { return currentHeroe; }
            set { currentHeroe = value; NotifyPropertyChanged("CurrentHeroe"); }
        }

        public MainWindowVM()
        {
            list = Superheroe.GetSamples();
            listIndex = 0;
            NavStr = listIndex + 1 + "/" + list.Count;
            currentHeroe = list[0];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void manageList(int op)
        {
            int listsize = list.Count();
            int i = listIndex;
            i += op;

            if (i < 0)
                i = 0;
            else if (i > list.Count() - 1)
                i = list.Count() - 1;

            listIndex = i;
            CurrentHeroe = list[listIndex];
            NavStr = listIndex + 1 + "/" + list.Count(); // MAL la vista modelo no puede acceder a la vista, "Revisar"

        }
    }
}
