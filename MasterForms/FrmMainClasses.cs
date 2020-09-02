using AnsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace AnsProject.MasterForms
{
    public partial class FrmMainClasses : RadForm
    {
        BindingSource bindingSource = new BindingSource();
        public FrmMainClasses()
        {
            InitializeComponent();
        }

        private void FrmMainClasses_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AnsProjectDbContext())
                {
                    var getmainclasse = db.MainClassesses.ToList();
                    bindingSource.DataSource = getmainclasse;
                    radBindingNavigator1.BindingSource = bindingSource;
                    radDataEntry1.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
