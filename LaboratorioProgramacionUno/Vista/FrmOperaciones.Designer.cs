
namespace LaboratorioProgramacionUno.Vista
{
    partial class FrmOperaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTIva = new System.Windows.Forms.Label();
            this.LblIvaAgre = new System.Windows.Forms.Label();
            this.LblTSinDescuento = new System.Windows.Forms.Label();
            this.LblTPagar = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblUs = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtProduc = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(49, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio del producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total sin iva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Iva a agregar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total sin descuento conIva incluido ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total a pagar";
            // 
            // LblTIva
            // 
            this.LblTIva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTIva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTIva.Location = new System.Drawing.Point(650, 313);
            this.LblTIva.Name = "LblTIva";
            this.LblTIva.Size = new System.Drawing.Size(49, 16);
            this.LblTIva.TabIndex = 9;
            this.LblTIva.Click += new System.EventHandler(this.label9_Click);
            // 
            // LblIvaAgre
            // 
            this.LblIvaAgre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIvaAgre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIvaAgre.Location = new System.Drawing.Point(650, 345);
            this.LblIvaAgre.Name = "LblIvaAgre";
            this.LblIvaAgre.Size = new System.Drawing.Size(49, 13);
            this.LblIvaAgre.TabIndex = 10;
            this.LblIvaAgre.Click += new System.EventHandler(this.label10_Click);
            // 
            // LblTSinDescuento
            // 
            this.LblTSinDescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTSinDescuento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTSinDescuento.Location = new System.Drawing.Point(650, 375);
            this.LblTSinDescuento.Name = "LblTSinDescuento";
            this.LblTSinDescuento.Size = new System.Drawing.Size(49, 13);
            this.LblTSinDescuento.TabIndex = 11;
            // 
            // LblTPagar
            // 
            this.LblTPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTPagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTPagar.Location = new System.Drawing.Point(650, 404);
            this.LblTPagar.Name = "LblTPagar";
            this.LblTPagar.Size = new System.Drawing.Size(49, 14);
            this.LblTPagar.TabIndex = 12;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(650, 262);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(0, 20);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(463, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Producto ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(317, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Tabla de descuento ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(676, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "usuario actual ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // LblUs
            // 
            this.LblUs.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUs.Location = new System.Drawing.Point(676, 43);
            this.LblUs.Name = "LblUs";
            this.LblUs.Size = new System.Drawing.Size(76, 25);
            this.LblUs.TabIndex = 17;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(115, 438);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(115, 32);
            this.BtnCalc.TabIndex = 18;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(204, 311);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(100, 20);
            this.TxtIva.TabIndex = 19;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(204, 402);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 20;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(204, 373);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 21;
            // 
            // TxtProduc
            // 
            this.TxtProduc.Location = new System.Drawing.Point(204, 343);
            this.TxtProduc.Name = "TxtProduc";
            this.TxtProduc.Size = new System.Drawing.Size(100, 20);
            this.TxtProduc.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Datos";
            this.Column1.Name = "Column1";
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(887, 482);
            this.Controls.Add(this.TxtProduc);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblUs);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblTPagar);
            this.Controls.Add(this.LblTSinDescuento);
            this.Controls.Add(this.LblIvaAgre);
            this.Controls.Add(this.LblTIva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOperaciones_FormClosing);
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTIva;
        private System.Windows.Forms.Label LblIvaAgre;
        private System.Windows.Forms.Label LblTSinDescuento;
        private System.Windows.Forms.Label LblTPagar;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblUs;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}