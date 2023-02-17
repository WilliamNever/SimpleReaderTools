using Newtonsoft.Json;
using SimpleReaderTools.BaseClasses;
using SimpleReaderTools.Core.Enums;
using SimpleReaderTools.Core.InterFace;
using SimpleReaderTools.Core.Utilities;
using System;
using System.Windows.Forms;

namespace SimpleReaderTools.FunctionDataDialog
{
    public partial class FrmShowCharNumber : FormBase
    {
        private IFormFunctions _fFunction;
        private string WindowName;
        public FrmShowCharNumber(IFormFunctions fFunction, string winName)
        {
            WindowName = winName;
            _fFunction = fFunction;
            InitializeComponent();
            Text = $"{Text}[{WindowName}]";
            SetDefaultFontForTxtContent(txtMessageInformation);
            SetWrap(txtMessageInformation, chbAutoWrap.Checked);
            ctrlCutCopyPast.EventClearContent += (object sender, EventArgs e) => { txtMessageInformation.Text = ""; };
        }

        private void btnShowCharNumber_Click(object sender, EventArgs e)
        {
            int begin = 'A';
            txtMessageInformation.Text = $"Char \t No. \t ASCII \r\n";
            txtMessageInformation.Text += $"----------------------------------------------------\r\n";
            for (int i = 0; i < 26; i++)
            {
                txtMessageInformation.Text += $"{(char)(begin + i)} \t {i + 1} \t {begin + i} \r\n";
            }
            txtMessageInformation.Text += $"----------------------------------------------------\r\n";
            txtMessageInformation.Text += $"Char \t No. \t ASCII \r\n";
            txtMessageInformation.Text += $"----------------------------------------------------\r\n";
            begin = 'a';
            for (int i = 0; i < 26; i++)
            {
                txtMessageInformation.Text += $"{(char)(begin + i)} \t {i + 1} \t {begin + i} \r\n";
            }
            txtMessageInformation.Text += $"----------------------------------------------------\r\n";
            txtMessageInformation.Text += $"Char \t No. \t ASCII \r\n";
            txtMessageInformation.Text += $"----------------------------------------------------\r\n";
            begin = '0';
            for (int i = 0; i < 10; i++)
            {
                txtMessageInformation.Text += $"{(char)(begin + i)} \t {i + 1} \t {begin + i} \r\n";
            }
        }

        private void tsmiFunctions_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CloseAllMenu();
            switch (e.ClickedItem.Name)
            {
                case "tsmCopyFromMain":
                    txtMessageInformation.Text = _fFunction.GetContentsBox().Text;
                    break;
                case "tsmCopyToMain":
                    _fFunction.CopyTextToForm(txtMessageInformation.Text, false, Text);
                    break;
                case "tsmiCopyClose":
                    _fFunction.CopyTextToForm(txtMessageInformation.Text, false, Text);
                    Close();
                    break;
                case "tsmAppToForm":
                    _fFunction.CopyTextToForm(txtMessageInformation.Text, true, Text);
                    break;
                case "tsmAppAndClose":
                    _fFunction.CopyTextToForm(txtMessageInformation.Text, true, Text);
                    Close();
                    break;
                case "tsmClose":
                    Close();
                    break;

                case "tsmShowFormattedJson":
                    txtMessageInformation.Text = GetFormattedString(txtMessageInformation.Text, EnStringType.Json, true);
                    break;
                case "tsmShowNoFormattedJson":
                    txtMessageInformation.Text = GetFormattedString(txtMessageInformation.Text, EnStringType.Json, false);
                    break;
                case "tsmOrderJsonProperties":
                    txtMessageInformation.Text = OrderByFormatStringProperties(txtMessageInformation.Text, EnStringType.Json, true);
                    break;

                case "tsmShowFormattedXml":
                    txtMessageInformation.Text = GetFormattedString(txtMessageInformation.Text, EnStringType.Xml, true);
                    break;
                case "tsmShowNoFormattedXml":
                    txtMessageInformation.Text = GetFormattedString(txtMessageInformation.Text, EnStringType.Xml, false);
                    break;
                case "tsmOrderXmlNodes":
                    txtMessageInformation.Text = OrderByFormatStringProperties(txtMessageInformation.Text, EnStringType.Xml, true);
                    break;

                case "tsmSetWinName":
                    var setValueDialog = new FrmSetValueDialog
                    {
                        SetValue = Text
                    };
                    if (setValueDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        Text = setValueDialog.SetValue;
                    }
                    break;
            }
        }

        private string OrderByFormatStringProperties(string text, EnStringType stringType, bool isFormatted)
        {
            string result = text;
            try
            {
                switch (stringType)
                {
                    case EnStringType.Json:
                        result = JsonOperations.JsonPropertiesOrder(result, isFormatted ? Formatting.Indented : Formatting.None);
                        break;
                    case EnStringType.Xml:
                        result = XMLOperations.GetOrderedNodesXmlString(result, isFormatted);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, $"{stringType} Convert Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private string GetFormattedString(string text, EnStringType stringType, bool isFormatted)
        {
            string result = text;
            try
            {
                switch (stringType)
                {
                    case EnStringType.Json:
                        result = JsonOperations.GetFormattedJson(result, isFormatted ? Formatting.Indented : Formatting.None);
                        break;
                    case EnStringType.Xml:
                        result = XMLOperations.GetXmlString(result, isFormatted);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, $"{stringType} Convert Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void CloseAllMenu()
        {
            foreach (var item in MSMainMenu.Items)
            {
                if (item is ToolStripMenuItem tmp)
                {
                    tmp.DropDown.Close();
                }
            }
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            txtMessageInformation.Text = $"Type \t\t\t Min \t\t\t Max \r\n";
            txtMessageInformation.Text += $"--------------------------------------------------------------------------------------------------------\r\n";
            txtMessageInformation.Text += $"SByte\t\t{sbyte.MinValue.ToString("N0")}\t\t{sbyte.MaxValue.ToString("N0")} [0x{sbyte.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"Byte\t\t{byte.MinValue.ToString("N0")} [0x{byte.MinValue.ToString("X")}]\t\t" +
                $"{byte.MaxValue.ToString("N0")} [0x{byte.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"Short\t\t{short.MinValue.ToString("N0")}\t\t{short.MaxValue.ToString("N0")} [0x{short.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"UShort\t\t{ushort.MinValue.ToString("N0")} [0x{ushort.MinValue.ToString("X")}]\t\t" +
                $"{ushort.MaxValue.ToString("N0")} [0x{ushort.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"Int\t\t{int.MinValue.ToString("N0")}\t\t{int.MaxValue.ToString("N0")} [0x{int.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"UInt\t\t{uint.MinValue.ToString("N0")} [0x{uint.MinValue.ToString("X")}]\t\t" +
                $"{uint.MaxValue.ToString("N0")} [0x{uint.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"Long\t\t{long.MinValue.ToString("N0")}\t\t{long.MaxValue.ToString("N0")} [0x{long.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"ULong\t\t{ulong.MinValue.ToString("N0")} [0x{ulong.MinValue.ToString("X")}]\t\t" +
                $"{ulong.MaxValue.ToString("N0")} [0x{ulong.MaxValue.ToString("X")}]  \r\n";
            txtMessageInformation.Text += $"Decimal\t\t{decimal.MinValue.ToString("N")}\t\t{decimal.MaxValue.ToString("N")}  \r\n";
            txtMessageInformation.Text += "\r\n";
            txtMessageInformation.Text += "\r\n";
            txtMessageInformation.Text += $"DateTime\t\t{DateTime.MinValue.ToString()}\t\t{DateTime.MaxValue.ToString()}\r\n";
        }

        private void btnGeneralNewGuid_Click(object sender, EventArgs e)
        {
            txtMessageInformation.Text += Guid.NewGuid().ToString();
            txtMessageInformation.Text += "\r\n";
        }

        #region Font pick Section
        private void btnFontDefault_Click(object sender, EventArgs e)
        {
            SetDefaultFontForTxtContent(txtMessageInformation);
        }

        private void chbAutoWrap_CheckedChanged(object sender, EventArgs e)
        {
            SetWrap(txtMessageInformation, chbAutoWrap.Checked);
        }

        private void btnFontSmall_Click(object sender, EventArgs e)
        {
            var size = txtMessageInformation.Font.Size;
            SetFontSizeInTextContent(--size, txtMessageInformation);
        }

        private void btnFontBig_Click(object sender, EventArgs e)
        {
            var size = txtMessageInformation.Font.Size;
            SetFontSizeInTextContent(++size, txtMessageInformation);
        }

        private void btnPickFont_Click(object sender, EventArgs e)
        {
            SetDefaultFont(txtMessageInformation);
        }
        #endregion
    }
}
