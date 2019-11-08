using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleOfInputOutputDirection
{
    public partial class Form1 : Form
    {
        DBx c_DB;
        private SimpleUser c_CurrentUser;
        Memento c_Memento;

        public Form1()
        {
            InitializeComponent();
            c_DB = new DBx();
            c_DB.ConnectionString = "Password=p@$$w0rd;Persist Security Info=True;User ID=sa;Initial Catalog=DBx;Data Source=10.28.32.122";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                c_CurrentUser = c_DB.NewUser(FirstNameTextBox.Text, LastNameTextBox.Text, short.Parse(AgeTextBox.Text), StatusTextBox.Text);
      
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            bindingSource1.DataSource = c_CurrentUser;

            c_Memento = new Memento(c_CurrentUser);
            c_Memento.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                c_DB.UpdateUser(c_CurrentUser);
            }
            catch (Exception ex)
            {
                c_Memento.Restore();
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
