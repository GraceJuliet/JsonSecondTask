using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTaskTwo.Models
{
    public class Medical : INotifyPropertyChanged
    {
        private string sectionHeader;
        public string SectionHeader
        {
            get
            {
                return sectionHeader;
            }
            set
            {
                sectionHeader = value;
                OnPropertyChanged("SectionHeader");
            }
        }

        private string title;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private string format;

        public string Format
        {
            get
            {
                return Format;
            }
            set
            {
                Format = value;
                OnPropertyChanged("Format");
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                OnPropertyChanged("Name");
            }
        }

        private string values;
        public string Values
        {
            get
            {
                return values;
            }
            set
            {
                values = value;
                OnPropertyChanged("Values");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
