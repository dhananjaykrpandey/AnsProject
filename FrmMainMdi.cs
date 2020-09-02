using AnsProject.MasterForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace AnsProject
{
    public partial class FrmMainMdi :RadRibbonForm
    {
        public FrmMainMdi()
        {
            InitializeComponent();
        }

        private void RdRbtnMainClasses_Click(object sender, EventArgs e)
        {
            FrmMainClasses frmMainClasses = new FrmMainClasses();
            frmMainClasses.Show();
        }
    }
}
