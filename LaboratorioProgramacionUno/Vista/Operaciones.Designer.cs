
namespace LaboratorioProgramacionUno
{
    partial class Operaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.PanelProductos = new System.Windows.Forms.Panel();
            this.LblPrecioProducto = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblNameUser = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtPrecioProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblTotalSinIva = new System.Windows.Forms.Label();
            this.LblIvaAgregar = new System.Windows.Forms.Label();
            this.TotalIvaDescuento = new System.Windows.Forms.Label();
            this.LblTotalPago = new System.Windows.Forms.Label();
            this.LblNameProducto = new System.Windows.Forms.Label();
            this.LblValorSinIva = new System.Windows.Forms.Label();
            this.LblValorIvaAgregar = new System.Windows.Forms.Label();
            this.LblValorSinDescuentoIvaIncluido = new System.Windows.Forms.Label();
            this.LblValorTotalPago = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTotales = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.PanelProductos.SuspendLayout();
            this.PanelTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCION,
            this.REGLA});
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // LblIva
            // 
            resources.ApplyResources(this.LblIva, "LblIva");
            this.LblIva.Name = "LblIva";
            // 
            // LblNombreProducto
            // 
            resources.ApplyResources(this.LblNombreProducto, "LblNombreProducto");
            this.LblNombreProducto.Name = "LblNombreProducto";
            // 
            // PanelProductos
            // 
            resources.ApplyResources(this.PanelProductos, "PanelProductos");
            this.PanelProductos.Controls.Add(this.button1);
            this.PanelProductos.Controls.Add(this.TxtCantidad);
            this.PanelProductos.Controls.Add(this.TxtPrecioProducto);
            this.PanelProductos.Controls.Add(this.TxtNombreProducto);
            this.PanelProductos.Controls.Add(this.TxtIVA);
            this.PanelProductos.Controls.Add(this.LblCantidad);
            this.PanelProductos.Controls.Add(this.LblPrecioProducto);
            this.PanelProductos.Controls.Add(this.LblIva);
            this.PanelProductos.Controls.Add(this.LblNombreProducto);
            this.PanelProductos.Name = "PanelProductos";
            // 
            // LblPrecioProducto
            // 
            resources.ApplyResources(this.LblPrecioProducto, "LblPrecioProducto");
            this.LblPrecioProducto.Name = "LblPrecioProducto";
            // 
            // LblCantidad
            // 
            resources.ApplyResources(this.LblCantidad, "LblCantidad");
            this.LblCantidad.Name = "LblCantidad";
            // 
            // LblUser
            // 
            resources.ApplyResources(this.LblUser, "LblUser");
            this.LblUser.Name = "LblUser";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // LblNameUser
            // 
            resources.ApplyResources(this.LblNameUser, "LblNameUser");
            this.LblNameUser.Name = "LblNameUser";
            // 
            // TxtIVA
            // 
            resources.ApplyResources(this.TxtIVA, "TxtIVA");
            this.TxtIVA.Name = "TxtIVA";
            // 
            // TxtNombreProducto
            // 
            resources.ApplyResources(this.TxtNombreProducto, "TxtNombreProducto");
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            // 
            // TxtPrecioProducto
            // 
            resources.ApplyResources(this.TxtPrecioProducto, "TxtPrecioProducto");
            this.TxtPrecioProducto.Name = "TxtPrecioProducto";
            // 
            // TxtCantidad
            // 
            resources.ApplyResources(this.TxtCantidad, "TxtCantidad");
            this.TxtCantidad.Name = "TxtCantidad";
            // 
            // LblProducto
            // 
            resources.ApplyResources(this.LblProducto, "LblProducto");
            this.LblProducto.Name = "LblProducto";
            // 
            // LblTotalSinIva
            // 
            resources.ApplyResources(this.LblTotalSinIva, "LblTotalSinIva");
            this.LblTotalSinIva.Name = "LblTotalSinIva";
            // 
            // LblIvaAgregar
            // 
            resources.ApplyResources(this.LblIvaAgregar, "LblIvaAgregar");
            this.LblIvaAgregar.Name = "LblIvaAgregar";
            this.LblIvaAgregar.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalIvaDescuento
            // 
            resources.ApplyResources(this.TotalIvaDescuento, "TotalIvaDescuento");
            this.TotalIvaDescuento.Name = "TotalIvaDescuento";
            // 
            // LblTotalPago
            // 
            resources.ApplyResources(this.LblTotalPago, "LblTotalPago");
            this.LblTotalPago.Name = "LblTotalPago";
            // 
            // LblNameProducto
            // 
            resources.ApplyResources(this.LblNameProducto, "LblNameProducto");
            this.LblNameProducto.Name = "LblNameProducto";
            // 
            // LblValorSinIva
            // 
            resources.ApplyResources(this.LblValorSinIva, "LblValorSinIva");
            this.LblValorSinIva.Name = "LblValorSinIva";
            // 
            // LblValorIvaAgregar
            // 
            resources.ApplyResources(this.LblValorIvaAgregar, "LblValorIvaAgregar");
            this.LblValorIvaAgregar.Name = "LblValorIvaAgregar";
            // 
            // LblValorSinDescuentoIvaIncluido
            // 
            resources.ApplyResources(this.LblValorSinDescuentoIvaIncluido, "LblValorSinDescuentoIvaIncluido");
            this.LblValorSinDescuentoIvaIncluido.Name = "LblValorSinDescuentoIvaIncluido";
            // 
            // LblValorTotalPago
            // 
            resources.ApplyResources(this.LblValorTotalPago, "LblValorTotalPago");
            this.LblValorTotalPago.Name = "LblValorTotalPago";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ACCION
            // 
            resources.ApplyResources(this.ACCION, "ACCION");
            this.ACCION.Name = "ACCION";
            // 
            // REGLA
            // 
            resources.ApplyResources(this.REGLA, "REGLA");
            this.REGLA.Name = "REGLA";
            // 
            // PanelTotales
            // 
            resources.ApplyResources(this.PanelTotales, "PanelTotales");
            this.PanelTotales.Controls.Add(this.LblProducto);
            this.PanelTotales.Controls.Add(this.LblValorTotalPago);
            this.PanelTotales.Controls.Add(this.LblNameProducto);
            this.PanelTotales.Controls.Add(this.LblValorSinDescuentoIvaIncluido);
            this.PanelTotales.Controls.Add(this.LblTotalSinIva);
            this.PanelTotales.Controls.Add(this.LblValorIvaAgregar);
            this.PanelTotales.Controls.Add(this.LblIvaAgregar);
            this.PanelTotales.Controls.Add(this.LblValorSinIva);
            this.PanelTotales.Controls.Add(this.TotalIvaDescuento);
            this.PanelTotales.Controls.Add(this.LblTotalPago);
            this.PanelTotales.Name = "PanelTotales";
            // 
            // Operaciones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTotales);
            this.Controls.Add(this.LblNameUser);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.PanelProductos);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.PanelProductos.ResumeLayout(false);
            this.PanelProductos.PerformLayout();
            this.PanelTotales.ResumeLayout(false);
            this.PanelTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Panel PanelProductos;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblPrecioProducto;
        private System.Windows.Forms.Label LblUser;
        public System.Windows.Forms.Label LblNameUser;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecioProducto;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblTotalSinIva;
        private System.Windows.Forms.Label LblIvaAgregar;
        private System.Windows.Forms.Label TotalIvaDescuento;
        private System.Windows.Forms.Label LblTotalPago;
        private System.Windows.Forms.Label LblNameProducto;
        private System.Windows.Forms.Label LblValorSinIva;
        private System.Windows.Forms.Label LblValorIvaAgregar;
        private System.Windows.Forms.Label LblValorSinDescuentoIvaIncluido;
        private System.Windows.Forms.Label LblValorTotalPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGLA;
        private System.Windows.Forms.Panel PanelTotales;
    }
}

