namespace ControlResidencial
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BancosIngresos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BancosEgresos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ConciliacionIngresos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ConciliacionEgresos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ResidenciasRegistrar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ResidenciasConsultar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ResidenciasActualizar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ResidenciasEliminar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MantenimientoOrdenesCompra = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement14 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportesConciliacionIngresos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportesConciliacioEgresos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportesGastos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportesMorosos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement4,
            this.accordionControlElement7,
            this.accordionControlElement8,
            this.accordionControlElement14});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(168, 395);
            this.accordionControl1.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BancosIngresos,
            this.BancosEgresos});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Bancos";
            // 
            // BancosIngresos
            // 
            this.BancosIngresos.Name = "BancosIngresos";
            this.BancosIngresos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BancosIngresos.Text = "Ingresos";
            this.BancosIngresos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // BancosEgresos
            // 
            this.BancosEgresos.Name = "BancosEgresos";
            this.BancosEgresos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BancosEgresos.Text = "Egresos";
            this.BancosEgresos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ConciliacionIngresos,
            this.ConciliacionEgresos});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Conciliación";
            // 
            // ConciliacionIngresos
            // 
            this.ConciliacionIngresos.Name = "ConciliacionIngresos";
            this.ConciliacionIngresos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ConciliacionIngresos.Text = "Ingresos";
            this.ConciliacionIngresos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ConciliacionEgresos
            // 
            this.ConciliacionEgresos.Name = "ConciliacionEgresos";
            this.ConciliacionEgresos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ConciliacionEgresos.Text = "Egresos";
            this.ConciliacionEgresos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ResidenciasRegistrar,
            this.ResidenciasConsultar,
            this.ResidenciasActualizar,
            this.ResidenciasEliminar});
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Residencias";
            // 
            // ResidenciasRegistrar
            // 
            this.ResidenciasRegistrar.Name = "ResidenciasRegistrar";
            this.ResidenciasRegistrar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ResidenciasRegistrar.Text = "Registrar";
            this.ResidenciasRegistrar.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ResidenciasConsultar
            // 
            this.ResidenciasConsultar.Name = "ResidenciasConsultar";
            this.ResidenciasConsultar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ResidenciasConsultar.Text = "Consultar";
            this.ResidenciasConsultar.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ResidenciasActualizar
            // 
            this.ResidenciasActualizar.Name = "ResidenciasActualizar";
            this.ResidenciasActualizar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ResidenciasActualizar.Text = "Actualizar";
            this.ResidenciasActualizar.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ResidenciasEliminar
            // 
            this.ResidenciasEliminar.Name = "ResidenciasEliminar";
            this.ResidenciasEliminar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ResidenciasEliminar.Text = "Eliminar";
            this.ResidenciasEliminar.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MantenimientoOrdenesCompra});
            this.accordionControlElement8.Expanded = true;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Text = "Mantenimiento";
            // 
            // MantenimientoOrdenesCompra
            // 
            this.MantenimientoOrdenesCompra.Name = "MantenimientoOrdenesCompra";
            this.MantenimientoOrdenesCompra.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.MantenimientoOrdenesCompra.Text = "Ordenes de compra";
            this.MantenimientoOrdenesCompra.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // accordionControlElement14
            // 
            this.accordionControlElement14.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ReportesConciliacionIngresos,
            this.ReportesConciliacioEgresos,
            this.ReportesGastos,
            this.ReportesMorosos});
            this.accordionControlElement14.Expanded = true;
            this.accordionControlElement14.Name = "accordionControlElement14";
            this.accordionControlElement14.Text = "Reportes";
            // 
            // ReportesConciliacionIngresos
            // 
            this.ReportesConciliacionIngresos.Name = "ReportesConciliacionIngresos";
            this.ReportesConciliacionIngresos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportesConciliacionIngresos.Text = "Conciliacion de Ingresos";
            this.ReportesConciliacionIngresos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ReportesConciliacioEgresos
            // 
            this.ReportesConciliacioEgresos.Name = "ReportesConciliacioEgresos";
            this.ReportesConciliacioEgresos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportesConciliacioEgresos.Text = "Conciliacion de egresos";
            this.ReportesConciliacioEgresos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ReportesGastos
            // 
            this.ReportesGastos.Name = "ReportesGastos";
            this.ReportesGastos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportesGastos.Text = "Gastos";
            this.ReportesGastos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // ReportesMorosos
            // 
            this.ReportesMorosos.Name = "ReportesMorosos";
            this.ReportesMorosos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportesMorosos.Text = "Morosos";
            this.ReportesMorosos.Click += new System.EventHandler(this.itemsMenu_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 395);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Control Residencial";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BancosIngresos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BancosEgresos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ConciliacionIngresos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ConciliacionEgresos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ResidenciasRegistrar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ResidenciasConsultar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ResidenciasActualizar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ResidenciasEliminar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MantenimientoOrdenesCompra;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement14;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportesConciliacionIngresos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportesConciliacioEgresos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportesGastos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportesMorosos;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

