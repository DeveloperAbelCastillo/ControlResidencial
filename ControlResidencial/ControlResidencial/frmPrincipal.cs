using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ControlResidencial
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form frmHijo
        , Form frmPadre
        , FormWindowState frmState = FormWindowState.Maximized
        , FormStartPosition frmPosition = FormStartPosition.CenterScreen)
        {
            try
            {
                bool cargado = false;
                foreach (Form llamado in frmPadre.MdiChildren)
                {
                    if (llamado.Text == frmHijo.Text)
                    {
                        cargado = true;
                        llamado.BringToFront();
                        return;
                    }
                }
                if (!cargado)
                {
                    frmHijo.MdiParent = frmPadre;
                    frmHijo.WindowState = frmState;
                    frmHijo.StartPosition = frmPosition;
                    frmHijo.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemsMenu_Click(object sender, EventArgs e)
        {
            AccordionControlElement item = (AccordionControlElement)sender;
            Form formulario = (Form)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("ControlResidencial.formas" + "." + item.Name);
                        
            if (formulario == null)
                return;

            AbrirForm(formulario, this);            
        }
    }    
}
