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
    public partial class CutCopyPastControl : CcomponentsBase
    {
        //[Browsable(true)]// to display the property in the Properties dialog
        //public string AX { get; set; }
        [Browsable(true)]
        public TextBox TxtContents { get; set; }
        public event EventHandler EventClearContent;
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
            RunProcess(sender, e, (s, ea) => {
                TxtContents.Select();
                TxtContents.SelectAll();
            });
        }

        private void BtnCopySel_Click(object sender, EventArgs e)
        {
            RunProcess(sender, e, (s, ea) => {
                TxtContents.Copy();
                TxtContents.Select();
            });
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            RunProcess(sender, e, (s, ea) => {
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                    TxtContents.Paste();
                }

                TxtContents.Select();
            });
        }

        public void SellectAll(object sender, EventArgs e)
        {
            RunProcess(sender, e, (s, ea) => { btnSelALL_Click(s, ea); });
        }
        public void CopySelected(object sender, EventArgs e)
        {
            RunProcess(sender, e, (s, ea) => { BtnCopySel_Click(s, ea); });
        }
        public void Paste(object sender, EventArgs e)
        {
            RunProcess(sender, e, (s, ea) => { btnPaste_Click(s, ea); });
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            RunProcess(sender, e, (s, ea) => { EventClearContent.Invoke(s, ea); });
        }
    }
}
