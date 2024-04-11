using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKL.Banking.UI
{
    public enum ScreenMode
    {
        Add = 0,
        Edit
    }

    public partial class frmDeposit : Form
    {
        private ScreenMode screenMode;

        public frmDeposit(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;
            this.Text = screenMode.ToString() + " Deposit";
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {

        }
    }
}
