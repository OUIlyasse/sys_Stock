using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g_Stock.Master
{
    public partial class frmL : Form
    {
        #region Codes

        public virtual void openForm()
        {
        }

        public virtual void Delete_Data()
        {
        }

        public virtual void Verify_Buttons(bool status)
        {
            if (status)
            {
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnSupprimer.Enabled = true;
            }
        }

        public virtual void getData()
        {
        }

        #endregion Codes

        public frmL()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void frmL_Activated(object sender, EventArgs e)
        {
            getData();
        }

        private void frmL_Load(object sender, EventArgs e)
        {
            Verify_Buttons(true);
        }
    }
}