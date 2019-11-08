using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExampleOfInputOutputDirection
{
    public class SimpleUser
        :INotifyPropertyChanged
    {
        private int c_ID;

        public int ID
        {
            get { return c_ID; }
            set
            {
                c_ID = value;
                ReportPropertyChanged("ID");
            }
        }

        private string c_FirstName;

        public string FirstName
        {
            get { return c_FirstName; }
            set
            {
                c_FirstName = value;
                ReportPropertyChanged("FirstName");
            }
        }

        private string c_LastName;

        public string LastName
        {
            get { return c_LastName; }
            set
            {
                c_LastName = value;
                ReportPropertyChanged("LastName");
            }
        }

        private short c_Age;

        public short Age
        {
            get { return c_Age; }
            set
            {
                c_Age = value;
                ReportPropertyChanged("Age");
            }
        }

        private string c_Status;

        public string Status
        {
            get { return c_Status; }
            set
            {
                c_Status = value;
                ReportPropertyChanged("Status");
            }
        }

        private DateTime c_LastUpdate;
        
        public DateTime LastUpdate
        {
            get { return c_LastUpdate; }
            set
            {
                c_LastUpdate = value;
                ReportPropertyChanged("LastUpdate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void ReportPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
