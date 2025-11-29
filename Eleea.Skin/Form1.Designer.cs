namespace Eleea.Skin
{
    partial class FrmTienda
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
            this.components = new System.ComponentModel.Container();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pcLupa = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.Location = new System.Drawing.Point(2, 111);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1535, 786);
            this.pnlContenido.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pictureBox4);
            this.pnlContenedor.Controls.Add(this.pcLupa);
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Controls.Add(this.lblCategorias);
            this.pnlContenedor.Controls.Add(this.lblTienda);
            this.pnlContenedor.Controls.Add(this.lblInicio);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.txtBuscar);
            this.pnlContenedor.Location = new System.Drawing.Point(2, 1);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1535, 111);
            this.pnlContenedor.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(1228, 55);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 34);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Eleea.Skin.Properties.Resources.usuario;
            this.pictureBox4.Location = new System.Drawing.Point(1405, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pcLupa
            // 
            this.pcLupa.Image = global::Eleea.Skin.Properties.Resources.lupa;
            this.pcLupa.Location = new System.Drawing.Point(1257, 41);
            this.pcLupa.Name = "pcLupa";
            this.pcLupa.Size = new System.Drawing.Size(39, 39);
            this.pcLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLupa.TabIndex = 13;
            this.pcLupa.TabStop = false;
            this.pcLupa.Click += new System.EventHandler(this.pcLupa_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Eleea.Skin.Properties.Resources.carrito_de_compras;
            this.pictureBox2.Location = new System.Drawing.Point(1326, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lblCategorias
            // 
            this.lblCategorias.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(304, 52);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(115, 28);
            this.lblCategorias.TabIndex = 11;
            this.lblCategorias.Text = "CATEGORIAS";
            // 
            // lblTienda
            // 
            this.lblTienda.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.Location = new System.Drawing.Point(182, 52);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(80, 28);
            this.lblTienda.TabIndex = 10;
            this.lblTienda.Text = "TIENDA";
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(78, 52);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 28);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "INICIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Classy Vogue", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "ELEEA SKIN";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 897);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlContenido);
            this.Name = "FrmTienda";
            this.Text = "Eleea Skin";
            this.Load += new System.EventHandler(this.FrmTienda_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pcLupa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Timer timer1;
    }
}

