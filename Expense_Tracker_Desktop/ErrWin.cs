using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Expense_Tracker_Desktop
{
    public partial class ErrWin : Form
    {
        private double _timer = 6;
        public ErrWin(string msg)
        {
            InitializeComponent();
            lblErrorMsg.Text = msg;

            this.Opacity = 0.75;
            fadeTimer.Tick += fadeTimer_Tick;

            fadeTimer.Start();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (_timer > 0)
            {
                _timer-= 0.5;
            }

            else
            {
                this.Opacity -= 0.03;

                if (this.Opacity <= 0)
                {
                    fadeTimer.Stop();
                    this.Close();
                }
            }

        }
        private void ToastForm_Load(object sender, EventArgs e)
        {

        }

        public static void Show(string message, Form sender)
        {
            var toast = new ErrWin(message);

            toast.StartPosition = FormStartPosition.Manual;
            toast.Location = new Point(
                sender.Location.X + sender.Width - toast.Width - 20,
                sender.Location.Y + sender.Height - toast.Height - 20
                );

            toast.Show(sender);
        }

        private void lblErrorMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
