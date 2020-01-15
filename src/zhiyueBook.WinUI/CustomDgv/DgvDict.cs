using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace zhiyueBook.WinUI.CustomDgv
{
    public partial class DgvDict : DataGridView
    {
        public DgvDict()
        {
            InitializeComponent();
        }

        public DgvDict(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
