    partial class ModificaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaUsuario));
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaRolesUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminarRolSeleccionado = new System.Windows.Forms.Button();
            this.btn_agregarUsuario = new System.Windows.Forms.Button();
            this.listaRoles = new System.Windows.Forms.ListBox();
            this.btn_habilitar_rol = new System.Windows.Forms.Button();
            this.topbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
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
            this.topbar.Size = new System.Drawing.Size(860, 49);
            this.topbar.TabIndex = 1;
            // 
            // minimizingLabel
            // 
            this.minimizingLabel.AutoSize = true;
            this.minimizingLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizingLabel.ForeColor = System.Drawing.Color.White;
            this.minimizingLabel.Location = new System.Drawing.Point(791, 12);
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
            this.titleLabel.Size = new System.Drawing.Size(253, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Modificación de usuario";
            // 
            // closingLabel
            // 
            this.closingLabel.AutoSize = true;
            this.closingLabel.BackColor = System.Drawing.Color.Transparent;
            this.closingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingLabel.ForeColor = System.Drawing.Color.White;
            this.closingLabel.Location = new System.Drawing.Point(823, 12);
            this.closingLabel.Name = "closingLabel";
            this.closingLabel.Size = new System.Drawing.Size(26, 25);
            this.closingLabel.TabIndex = 2;
            this.closingLabel.Text = "X";
            this.closingLabel.Click += new System.EventHandler(this.closingLabel_Click);
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
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidepanel.Controls.Add(this.label17);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 362);
            this.sidepanel.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 55);
            this.label17.MaximumSize = new System.Drawing.Size(190, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 51);
            this.label17.TabIndex = 50;
            this.label17.Text = "Panel para modificación de usuarios - solo accesible a administradores.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(315, 80);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(247, 20);
            this.username.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(315, 114);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(247, 20);
            this.password.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rol";
            // 
            // listaRolesUsuario
            // 
            this.listaRolesUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaRolesUsuario.FormattingEnabled = true;
            this.listaRolesUsuario.Location = new System.Drawing.Point(245, 150);
            this.listaRolesUsuario.Name = "listaRolesUsuario";
            this.listaRolesUsuario.Size = new System.Drawing.Size(317, 21);
            this.listaRolesUsuario.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(206, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Datos de usuario";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightPink;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(568, 55);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(481, 67);
            this.btn_limpiar.TabIndex = 49;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(568, 288);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(481, 67);
            this.btn_guardar.TabIndex = 48;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminarRolSeleccionado
            // 
            this.btn_eliminarRolSeleccionado.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_eliminarRolSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarRolSeleccionado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarRolSeleccionado.Location = new System.Drawing.Point(384, 177);
            this.btn_eliminarRolSeleccionado.Name = "btn_eliminarRolSeleccionado";
            this.btn_eliminarRolSeleccionado.Size = new System.Drawing.Size(178, 30);
            this.btn_eliminarRolSeleccionado.TabIndex = 77;
            this.btn_eliminarRolSeleccionado.Text = "Eliminar Rol elegido";
            this.btn_eliminarRolSeleccionado.UseVisualStyleBackColor = false;
            this.btn_eliminarRolSeleccionado.Click += new System.EventHandler(this.btn_eliminarRolSeleccionado_Click);
            // 
            // btn_agregarUsuario
            // 
            this.btn_agregarUsuario.BackColor = System.Drawing.Color.Gold;
            this.btn_agregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUsuario.Location = new System.Drawing.Point(210, 177);
            this.btn_agregarUsuario.Name = "btn_agregarUsuario";
            this.btn_agregarUsuario.Size = new System.Drawing.Size(168, 30);
            this.btn_agregarUsuario.TabIndex = 76;
            this.btn_agregarUsuario.Text = "Agregar Rol";
            this.btn_agregarUsuario.UseVisualStyleBackColor = false;
            this.btn_agregarUsuario.Click += new System.EventHandler(this.btn_agregarRol_Click);
            // 
            // listaRoles
            // 
            this.listaRoles.FormattingEnabled = true;
            this.listaRoles.Location = new System.Drawing.Point(210, 213);
            this.listaRoles.Name = "listaRoles";
            this.listaRoles.Size = new System.Drawing.Size(352, 95);
            this.listaRoles.TabIndex = 75;
            // 
            // btn_habilitar_rol
            // 
            this.btn_habilitar_rol.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_habilitar_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_habilitar_rol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitar_rol.Location = new System.Drawing.Point(210, 314);
            this.btn_habilitar_rol.Name = "btn_habilitar_rol";
            this.btn_habilitar_rol.Size = new System.Drawing.Size(352, 41);
            this.btn_habilitar_rol.TabIndex = 78;
            this.btn_habilitar_rol.Text = "Volver a habilitar usuario";
            this.btn_habilitar_rol.UseVisualStyleBackColor = false;
            this.btn_habilitar_rol.Click += new System.EventHandler(this.btn_habilitar_rol_Click);
            // 
            // ModificaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1060, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btn_habilitar_rol);
            this.Controls.Add(this.btn_eliminarRolSeleccionado);
            this.Controls.Add(this.btn_agregarUsuario);
            this.Controls.Add(this.listaRoles);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listaRolesUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaUsuario";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.ModificaUsuario_Load);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label closingLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label minimizingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox listaRolesUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_eliminarRolSeleccionado;
        private System.Windows.Forms.Button btn_agregarUsuario;
        private System.Windows.Forms.ListBox listaRoles;
        private System.Windows.Forms.Button btn_habilitar_rol;

    }