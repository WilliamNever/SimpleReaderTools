using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.Components
{
    public abstract class CcomponentsBase : UserControl
    {
        protected async Task RunProcessAsync(object sender, EventArgs e, Func<object, EventArgs, Task> func)
        {
            try
            {
                await func.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                var controlSender = sender as Control;
                if (controlSender != null)
                {
                    MessageBox.Show(this, $"Control {controlSender.Text} - {Environment.NewLine}{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        protected void RunProcess(object sender, EventArgs e, Action<object, EventArgs> func)
        {
            try
            {
                func.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                var controlSender = sender as Control;
                if (controlSender != null)
                {
                    MessageBox.Show(this, $"Action {controlSender.Text} - {Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
