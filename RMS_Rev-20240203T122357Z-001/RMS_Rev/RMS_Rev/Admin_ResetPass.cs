using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Rev
{
    public partial class Admin_ResetPass : Form
    {
        public Admin_ResetPass()
        {
        }

        public Admin_ResetPass(string username)
        {
            InitializeComponent();
        }

        public string NewPassword { get; internal set; }
        public string ConfirmPassword { get; internal set; }
    }
}
