partial class RendicionComisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RendicionComisiones));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closingLabel = new System.Windows.Forms.Label();
            this.listadoComprasNoRendidas = new System.Windows.Forms.DataGridView();
            this.btn_verSinRendir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.agregar_a_rendir = new System.Windows.Forms.Button();
            this.nroComprasAAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listadoComprasARendir = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.totalVendedores = new System.Windows.Forms.Label();
            this.totalComisiones = new System.Windows.Forms.Label();
            this.rendirElegidas = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoComprasNoRendidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoComprasARendir)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidepanel.Controls.Add(this.label17);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 617);
            this.sidepanel.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 56);
            this.label17.MaximumSize = new System.Drawing.Size(190, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 119);
            this.label17.TabIndex = 51;
            this.label17.Text = "El botón \"fijar n. de compra(s) a rendir\" agrega secuencialmente las compras que " +
    "el administrador desee en base al número escrito en el cuadro de arriba.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 49);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 24);
            this.title.TabIndex = 2;
            this.title.Text = "PalcoNet FRBA";
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.topbar.Controls.Add(this.minimizingLabel);
            this.topbar.Controls.Add(this.titleLabel);
            this.topbar.Controls.Add(this.closingLabel);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(200, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1251, 49);
            this.topbar.TabIndex = 1;
            // 
            // minimizingLabel
            // 
            this.minimizingLabel.AutoSize = true;
            this.minimizingLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizingLabel.ForeColor = System.Drawing.Color.White;
            this.minimizingLabel.Location = new System.Drawing.Point(1181, 12);
            this.minimizingLabel.Name = "minimizingLabel";
            this.minimizingLabel.Size = new System.Drawing.Size(34, 25);
            this.minimizingLabel.TabIndex = 4;
            this.minimizingLabel.Text = "__";
            this.minimizingLabel.Click += new System.EventHandler(this.minimizingLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(6, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Generar rendición de comisiones";
            // 
            // closingLabel
            // 
            this.closingLabel.AutoSize = true;
            this.closingLabel.BackColor = System.Drawing.Color.Transparent;
            this.closingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingLabel.ForeColor = System.Drawing.Color.White;
            this.closingLabel.Location = new System.Drawing.Point(1213, 12);
            this.closingLabel.Name = "closingLabel";
            this.closingLabel.Size = new System.Drawing.Size(26, 25);
            this.closingLabel.TabIndex = 2;
            this.closingLabel.Text = "X";
            this.closingLabel.Click += new System.EventHandler(this.closingLabel_Click);
            // 
            // listadoComprasNoRendidas
            // 
            this.listadoComprasNoRendidas.AllowUserToAddRows = false;
            this.listadoComprasNoRendidas.AllowUserToDeleteRows = false;
            this.listadoComprasNoRendidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoComprasNoRendidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listadoComprasNoRendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoComprasNoRendidas.Location = new System.Drawing.Point(210, 56);
            this.listadoComprasNoRendidas.MultiSelect = false;
            this.listadoComprasNoRendidas.Name = "listadoComprasNoRendidas";
            this.listadoComprasNoRendidas.ReadOnly = true;
            this.listadoComprasNoRendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoComprasNoRendidas.Size = new System.Drawing.Size(742, 476);
            this.listadoComprasNoRendidas.TabIndex = 10;
            // 
            // btn_verSinRendir
            // 
            this.btn_verSinRendir.BackColor = System.Drawing.Color.LightGreen;
            this.btn_verSinRendir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verSinRendir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verSinRendir.Location = new System.Drawing.Point(210, 538);
            this.btn_verSinRendir.Name = "btn_verSinRendir";
            this.btn_verSinRendir.Size = new System.Drawing.Size(742, 67);
            this.btn_verSinRendir.TabIndex = 13;
            this.btn_verSinRendir.Text = "Ver compras sin rendir";
            this.btn_verSinRendir.UseVisualStyleBackColor = false;
            this.btn_verSinRendir.Click += new System.EventHandler(this.btn_verSinRendir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightPink;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(958, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(481, 43);
            this.btn_limpiar.TabIndex = 51;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // agregar_a_rendir
            // 
            this.agregar_a_rendir.BackColor = System.Drawing.Color.LightCyan;
            this.agregar_a_rendir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_a_rendir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_a_rendir.Location = new System.Drawing.Point(958, 188);
            this.agregar_a_rendir.Name = "agregar_a_rendir";
            this.agregar_a_rendir.Size = new System.Drawing.Size(481, 44);
            this.agregar_a_rendir.TabIndex = 52;
            this.agregar_a_rendir.Text = "Fijar n. de compra(s) a rendir";
            this.agregar_a_rendir.UseVisualStyleBackColor = false;
            this.agregar_a_rendir.Click += new System.EventHandler(this.agregar_a_rendir_Click);
            // 
            // nroComprasAAgregar
            // 
            this.nroComprasAAgregar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroComprasAAgregar.Location = new System.Drawing.Point(958, 129);
            this.nroComprasAAgregar.MaxLength = 50;
            this.nroComprasAAgregar.Multiline = true;
            this.nroComprasAAgregar.Name = "nroComprasAAgregar";
            this.nroComprasAAgregar.Size = new System.Drawing.Size(481, 53);
            this.nroComprasAAgregar.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(958, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Número de compras p/ rendir:";
            // 
            // listadoComprasARendir
            // 
            this.listadoComprasARendir.AllowUserToAddRows = false;
            this.listadoComprasARendir.AllowUserToDeleteRows = false;
            this.listadoComprasARendir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoComprasARendir.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listadoComprasARendir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoComprasARendir.Location = new System.Drawing.Point(958, 238);
            this.listadoComprasARendir.MultiSelect = false;
            this.listadoComprasARendir.Name = "listadoComprasARendir";
            this.listadoComprasARendir.ReadOnly = true;
            this.listadoComprasARendir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoComprasARendir.Size = new System.Drawing.Size(481, 193);
            this.listadoComprasARendir.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(958, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Importe total a rendir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(958, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Importe total de comisiones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(958, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Importe total a vendedores:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(1419, 436);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(20, 21);
            this.total.TabIndex = 68;
            this.total.Text = "--";
            // 
            // totalVendedores
            // 
            this.totalVendedores.AutoSize = true;
            this.totalVendedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVendedores.Location = new System.Drawing.Point(1419, 457);
            this.totalVendedores.Name = "totalVendedores";
            this.totalVendedores.Size = new System.Drawing.Size(20, 21);
            this.totalVendedores.TabIndex = 69;
            this.totalVendedores.Text = "--";
            // 
            // totalComisiones
            // 
            this.totalComisiones.AutoSize = true;
            this.totalComisiones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalComisiones.Location = new System.Drawing.Point(1419, 490);
            this.totalComisiones.Name = "totalComisiones";
            this.totalComisiones.Size = new System.Drawing.Size(20, 21);
            this.totalComisiones.TabIndex = 70;
            this.totalComisiones.Text = "--";
            // 
            // rendirElegidas
            // 
            this.rendirElegidas.BackColor = System.Drawing.Color.Gold;
            this.rendirElegidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rendirElegidas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendirElegidas.Location = new System.Drawing.Point(962, 538);
            this.rendirElegidas.Name = "rendirElegidas";
            this.rendirElegidas.Size = new System.Drawing.Size(477, 67);
            this.rendirElegidas.TabIndex = 71;
            this.rendirElegidas.Text = "Rendir compra(s) elegida(s)";
            this.rendirElegidas.UseVisualStyleBackColor = false;
            this.rendirElegidas.Click += new System.EventHandler(this.rendirElegidas_Click);
            // 
            // RendicionComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1451, 617);
            this.ControlBox = false;
            this.Controls.Add(this.rendirElegidas);
            this.Controls.Add(this.totalComisiones);
            this.Controls.Add(this.totalVendedores);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listadoComprasARendir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nroComprasAAgregar);
            this.Controls.Add(this.agregar_a_rendir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_verSinRendir);
            this.Controls.Add(this.listadoComprasNoRendidas);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RendicionComisiones";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.RendicionComisiones_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoComprasNoRendidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoComprasARendir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closingLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label minimizingLabel;
        private System.Windows.Forms.DataGridView listadoComprasNoRendidas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_verSinRendir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button agregar_a_rendir;
        private System.Windows.Forms.TextBox nroComprasAAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listadoComprasARendir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label totalVendedores;
        private System.Windows.Forms.Label totalComisiones;
        private System.Windows.Forms.Button rendirElegidas;

    }