using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleOfInputOutputDirection
{
    public class Memento
    {
        SimpleUser c_Backup;
        SimpleUser c_Source;

        public Memento(SimpleUser source)
        {
            c_Source = source;
            c_Backup = new SimpleUser();
        }

        public void Save()
        {
            c_Backup.ID = c_Source.ID;
            c_Backup.FirstName = c_Source.FirstName;
            c_Backup.LastName = c_Source.LastName;
            c_Backup.Age = c_Source.Age;
            c_Backup.Status = c_Source.Status;
            c_Backup.LastUpdate = c_Source.LastUpdate;
        }

        public void Restore()
        {
            c_Source.ID = c_Backup.ID;
            c_Source.FirstName = c_Backup.FirstName;
            c_Source.LastName = c_Backup.LastName;
            c_Source.Age = c_Backup.Age;
            c_Source.Status = c_Backup.Status;
            c_Source.LastUpdate = c_Backup.LastUpdate;
        }
    }
}
