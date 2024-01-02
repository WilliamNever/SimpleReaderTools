using SimpleReaderTools.BaseClasses;
using SimpleReaderTools.Core.Models;
using SimpleReaderTools.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.FunctionDataDialog
{
    public partial class FrmRandomGenerator : FormBase
    {
        private IEnumerable<DrDownItem> DownItems;
        private Regex NumRegex = new Regex(@"^[\d]+$");
        private Color txtBackColor;
        private Color txtForeColor;
        public FrmRandomGenerator()
        {
            InitializeComponent();

            txtBackColor = txtLength.BackColor;
            txtForeColor = txtLength.ForeColor;

            DownItems = DrDownItem.GetDefaultItems();
            cmbPattern.Items.AddRange(DownItems.ToArray());
            cmbPattern.DisplayMember = "Name";
            cmbPattern.SelectedIndex = 0;

            txtCcpComp.EventClearContent += TxtCcpComp_EventClearContent;
        }

        private void TxtCcpComp_EventClearContent(object sender, EventArgs e)
        {
            txtContent.Text = string.Empty;
        }

        private void cmbPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sitem = (sender as ComboBox).SelectedItem as DrDownItem;
            bool isEnabled = sitem.Id == DrDownItem.CustomId;
            txtCharactersSeeds.Enabled = isEnabled;
            btnClear.Enabled = isEnabled;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCharactersSeeds.Text = string.Empty;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var isv = ValidateChildren(ValidationConstraints.Enabled);
            //var isv = Validate(true);
            if (isv)
            {
                string seeds;
                var sitem = cmbPattern.SelectedItem as DrDownItem;
                seeds = sitem.Content;
                if (sitem.Id == DrDownItem.CustomId)
                {
                    seeds = txtCharactersSeeds.Text;
                }
                var sop = new StringOperations();
                for (int i = 0; i < int.Parse(txtNumber.Text); i++)
                {
                    txtContent.Text += sop.RandomStrings(seeds, int.Parse(txtLength.Text));
                    txtContent.Text += Environment.NewLine;
                }
                txtContent.Text += Environment.NewLine;
            }
        }

        private void txtControl_Validating(object sender, CancelEventArgs e)
        {
            var txtControl = sender as TextBox;
            if (txtControl != null)
            {
                string txt = txtControl.Text;
                if (NumRegex.IsMatch(txt))
                {
                    txtControl.BackColor = txtBackColor;
                    txtControl.ForeColor = txtForeColor;
                }
                else
                {
                    txtControl.BackColor = Color.Red;
                    txtControl.ForeColor = Color.White;
                    e.Cancel = true;
                }
            }
        }

        private void txtNullOrEmpty_Validating(object sender, CancelEventArgs e)
        {
            var txtControl = sender as TextBox;
            if (txtControl != null)
            {
                string txt = txtControl.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    txtControl.BackColor = txtBackColor;
                    txtControl.ForeColor = txtForeColor;
                }
                else
                {
                    txtControl.BackColor = Color.Red;
                    txtControl.ForeColor = Color.White;
                    e.Cancel = true;
                }
            }
        }
    }

    public class DrDownItem : ListItemModel<string>
    {
        public static int CustomId { get => 999; }
        public static IEnumerable<DrDownItem> GetDefaultItems()
        {
            return new List<DrDownItem> {
                new DrDownItem{ Id=1, Name="A-Z", Order=1, Content=           "ABCDEFGHIJKLMNOPQRSTUVWXYZ" },
                new DrDownItem{ Id=2, Name="a-z", Order=2, Content=           "abcdefghijklmnopqrstuvwxyz" },
                new DrDownItem{ Id = 3, Name="A-Z a-z", Order=3, Content=       "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" },
                new DrDownItem{ Id = 4, Name="A-Z a-z 0-9", Order=4, Content=   "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" },
                new DrDownItem{ Id = 5, Name="0-9", Order=4, Content=   "0123456789" },

                new DrDownItem{ Id = 999, Name="Custom", Order=999, Description="Custom the characters Seed" }
            }.OrderBy(x => x.Order).ToList();
        }
    }
}
