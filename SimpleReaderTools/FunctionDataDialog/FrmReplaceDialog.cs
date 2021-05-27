using SimpleReaderTools.Core.InterFace;
using SimpleReaderTools.Core.Utilities;
using System;
using System.Windows.Forms;

namespace SimpleReaderTools.FunctionDataDialog
{
    public partial class FrmReplace : Form
    {
        private IFormFunctions _fFunction;
        public FrmReplace(IFormFunctions fFunction)
        {
            _fFunction = fFunction;
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var contentsBox = _fFunction.GetContentsBox();
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                contentsBox.Text = Replace(contentsBox.Text, txtFind.Text, txtReplaceWith.Text
                    , cbkMatchCase.Checked, cbkRExpression.Checked);
                var sst = _fFunction.GetWinWorkingStatus();

                var status = string.Format("case {0} {1}", cbkMatchCase.Checked ? "sensitive" : "un-sensitive"
                    , cbkRExpression.Checked ? "regular expression" : "mode");
                sst.Text = $"Replace '{txtFind.Text}' with '{txtReplaceWith.Text}' in {status}.";
            }
        }

        private string Replace(string text, string find, string replacement, bool mcase, bool regularEx)
        {
            string result = text;

            if (regularEx)
            {
                result = StringOperations.RegularReplace(result, find, replacement, mcase);
            }
            else
            {
                result = StringOperations.CommonReplace(result, find, replacement, mcase);
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}