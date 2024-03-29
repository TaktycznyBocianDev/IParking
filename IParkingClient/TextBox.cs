﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParkingClient
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        /// <summary>
        /// Totally not my class:https://stackoverflow.com/questions/9844650/how-to-know-when-the-user-is-done-typing-on-c-sharp-windows-form-textbox
        /// It helps validate email - trigger validaion after the email is wrote.
        /// </summary>

        private System.Timers.Timer timer;

        public TextBox()
        {
            this.timer = new System.Timers.Timer(2000);
            this.timer.Elapsed += timer_Elapsed;
        }

        public TimeSpan TextChangedCompleteDelay
        {
            get { return TimeSpan.FromMilliseconds(this.timer.Interval); }
            set { this.timer.Interval = value.TotalMilliseconds; }
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs args)
        {
            this.timer.Stop();
            this.BeginInvoke(new MethodInvoker(this.OnTextChangedComplete));
        }

        public event EventHandler<EventArgs> TextChangedComplete;

        protected void OnTextChangedComplete()
        {
            if (this.TextChangedComplete != null)
                this.TextChangedComplete(this, new EventArgs());
        }

        protected override void OnTextChanged(EventArgs args)
        {
            if (!this.timer.Enabled)
                this.timer.Start();
            else
            {
                this.timer.Stop();
                this.timer.Start();
            }

            base.OnTextChanged(args);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.timer != null)
                    this.timer.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
