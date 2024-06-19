using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public enum StatusType
    {
        OK,
        ERROR,
        INFO,
        WARNING
    }

    internal class StatusLabel
    {
        public StatusLabel(ToolStripStatusLabel Sts)
        {
            Label = Sts;
        }
        public ToolStripStatusLabel Label {  get; private set; }
        public void Set(string msg, StatusType status)
        {
            switch(status)
            {
                case StatusType.OK:
                    Label.Text = msg;
                    Label.ForeColor = Color.Green;
                    break;
                case StatusType.WARNING:
                case StatusType.ERROR:
                    Label.Text = msg;
                    Label.ForeColor = Color.Red;
                    break;
                case StatusType.INFO:
                    Label.Text = msg;
                    Label.ForeColor = Color.MediumBlue;
                    break;
            }
        }
    }
}
