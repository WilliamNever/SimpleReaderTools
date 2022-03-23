using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.FunctionDataDialog
{
    public partial class FrmSetValueDialog : Form
    {
        public FrmSetValueDialog()
        {
            InitializeComponent();
        }
        public string SetValue { 
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }
    }
}
