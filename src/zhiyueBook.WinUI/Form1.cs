using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RiziFrame.Utility.Db;
using zhiyueBook.Model;
using zhiyueBook.DAL;

namespace zhiyueBook.WinUI
{
    public partial class Form1 : Form
    {
        DbProvider dbProvider = new DbProvider ();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(dbProvider.TypeName + '\n'+
                dbProvider.ConnectionString);

            switch (dbProvider.ConnectionString.ToLower())
            {
                case "oledb":
                    OleDbHelper.SetConn(dbProvider.ConnectionString);
                    MessageBox.Show("access");
                    OleDbHelper.TestConn();
                    break;
                default:
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbHelper.SetConn(dbProvider.ConnectionString);
            TjjyService srv = new TjjyService ();
            //List<Tjjy> list = srv.Query();
            //MessageBox.Show(list.Count().ToString());



        }
    }
}
