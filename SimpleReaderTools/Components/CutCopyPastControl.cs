using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.Components
{
    public partial class CutCopyPastControl : UserControl
    {
        //[Browsable(true)]// to display the property in the Properties dialog
        //public string AX { get; set; }
        [Browsable(true)]
        public TextBox TxtContents { get; set; }
        public CutCopyPastControl()
        {
            InitializeComponent();
        }
        public void SetTextBox(TextBox txtContents)
        {
            TxtContents = txtContents;
        }
        private void btnSelALL_Click(object sender, EventArgs e)
        {
            TxtContents.Select();
            TxtContents.SelectAll();
        }

        private void BtnCopySel_Click(object sender, EventArgs e)
        {
            TxtContents.Copy();
            TxtContents.Select();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                TxtContents.Paste();
            }

            TxtContents.Select();
        }

        public void SellectAll(object sender, EventArgs e)
        {
            btnSelALL_Click(sender, e);
        }
        public void CopySelected(object sender, EventArgs e)
        {
            BtnCopySel_Click(sender, e);
        }
        public void Paste(object sender, EventArgs e)
        {
            btnPaste_Click(sender, e);
        }
    }
}
