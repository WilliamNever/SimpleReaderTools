﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.Components
{
    public partial class CcomponentsBase : UserControl
    {
        public CcomponentsBase()
        {
            InitializeComponent();
        }
        protected virtual async Task RunProcessAsync(object sender, EventArgs e, Func<object, EventArgs, Task> func)
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
                    MessageBox.Show(this, $"Action {controlSender.Text} - {Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        protected virtual void RunProcess(object sender, EventArgs e, Action<object, EventArgs> func)
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
