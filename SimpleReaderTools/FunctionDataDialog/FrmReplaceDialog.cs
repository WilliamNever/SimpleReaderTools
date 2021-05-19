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
using SimpleReaderTools.InterFace;
using SimpleReaderTools.Utilities;

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
                contentsBox.Text = Replace(contentsBox.Text, txtFind.Text, txtReplaceWith.Text
                    , cbkMatchCase.Checked, cbkRExpression.Checked);
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