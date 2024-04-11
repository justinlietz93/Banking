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

    public partial class frmWithdrawal : Form
    {
        private ScreenMode screenMode;

        public frmWithdrawal(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;
            this.Text = screenMode.ToString() + " Withdrawal";
        }
    }
}
