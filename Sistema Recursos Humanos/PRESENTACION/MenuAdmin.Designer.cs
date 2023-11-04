namespace Sistema_Recursos_Humanos
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.BtnPuestos = new FontAwesome.Sharp.IconButton();
            this.btnseleccion = new FontAwesome.Sharp.IconButton();
            this.btnCompetencias = new FontAwesome.Sharp.IconButton();
            this.btnIdiomas = new FontAwesome.Sharp.IconButton();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnCapacitaciones = new FontAwesome.Sharp.IconButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.timermenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 28);
            this.panel1.TabIndex = 3;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(306, 3);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(167, 25);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Sistema RRHH";
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // BtnPuestos
            // 
            this.BtnPuestos.BackColor = System.Drawing.Color.White;
            this.BtnPuestos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BtnPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPuestos.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPuestos.IconChar = FontAwesome.Sharp.IconChar.Bullseye;
            this.BtnPuestos.IconColor = System.Drawing.Color.Black;
            this.BtnPuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPuestos.IconSize = 90;
            this.BtnPuestos.Location = new System.Drawing.Point(17, 120);
            this.BtnPuestos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPuestos.Name = "BtnPuestos";
            this.BtnPuestos.Size = new System.Drawing.Size(124, 117);
            this.BtnPuestos.TabIndex = 4;
            this.BtnPuestos.Text = "Puestos";
            this.BtnPuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPuestos.UseVisualStyleBackColor = false;
            this.BtnPuestos.Click += new System.EventHandler(this.BtnPuestos_Click);
            // 
            // btnseleccion
            // 
            this.btnseleccion.BackColor = System.Drawing.Color.White;
            this.btnseleccion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnseleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnseleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseleccion.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccion.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnseleccion.IconColor = System.Drawing.Color.Black;
            this.btnseleccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnseleccion.IconSize = 90;
            this.btnseleccion.Location = new System.Drawing.Point(177, 45);
            this.btnseleccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(130, 118);
            this.btnseleccion.TabIndex = 5;
            this.btnseleccion.Text = "Selección  ";
            this.btnseleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnseleccion.UseVisualStyleBackColor = false;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btnCompetencias
            // 
            this.btnCompetencias.BackColor = System.Drawing.Color.White;
            this.btnCompetencias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompetencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnCompetencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetencias.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetencias.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.btnCompetencias.IconColor = System.Drawing.Color.Black;
            this.btnCompetencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompetencias.IconSize = 90;
            this.btnCompetencias.Location = new System.Drawing.Point(177, 204);
            this.btnCompetencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompetencias.Name = "btnCompetencias";
            this.btnCompetencias.Size = new System.Drawing.Size(130, 126);
            this.btnCompetencias.TabIndex = 6;
            this.btnCompetencias.Text = "Competencias";
            this.btnCompetencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompetencias.UseVisualStyleBackColor = false;
            this.btnCompetencias.Click += new System.EventHandler(this.btnCompetencias_Click);
            // 
            // btnIdiomas
            // 
            this.btnIdiomas.BackColor = System.Drawing.Color.White;
            this.btnIdiomas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIdiomas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdiomas.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdiomas.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnIdiomas.IconColor = System.Drawing.Color.Black;
            this.btnIdiomas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIdiomas.IconSize = 90;
            this.btnIdiomas.Location = new System.Drawing.Point(455, 204);
            this.btnIdiomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIdiomas.Name = "btnIdiomas";
            this.btnIdiomas.Size = new System.Drawing.Size(134, 113);
            this.btnIdiomas.TabIndex = 7;
            this.btnIdiomas.Text = "Idiomas";
            this.btnIdiomas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIdiomas.UseVisualStyleBackColor = false;
            this.btnIdiomas.Click += new System.EventHandler(this.btnIdiomas_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.White;
            this.btnEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 90;
            this.btnEmpleado.Location = new System.Drawing.Point(455, 45);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(130, 118);
            this.btnEmpleado.TabIndex = 8;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCapacitaciones
            // 
            this.btnCapacitaciones.BackColor = System.Drawing.Color.White;
            this.btnCapacitaciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCapacitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnCapacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacitaciones.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCapacitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacitaciones.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnCapacitaciones.IconColor = System.Drawing.Color.Black;
            this.btnCapacitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapacitaciones.IconSize = 90;
            this.btnCapacitaciones.Location = new System.Drawing.Point(621, 109);
            this.btnCapacitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapacitaciones.Name = "btnCapacitaciones";
            this.btnCapacitaciones.Size = new System.Drawing.Size(133, 128);
            this.btnCapacitaciones.TabIndex = 9;
            this.btnCapacitaciones.Text = "Capacitaciones";
            this.btnCapacitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCapacitaciones.UseVisualStyleBackColor = false;
            this.btnCapacitaciones.Click += new System.EventHandler(this.btnCapacitaciones_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Snow;
            this.lblHora.Location = new System.Drawing.Point(10, 30);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 31);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "label";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Snow;
            this.lblfecha.Location = new System.Drawing.Point(12, 67);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(42, 20);
            this.lblfecha.TabIndex = 11;
            this.lblfecha.Text = "label";
            // 
            // timermenu
            // 
            this.timermenu.Enabled = true;
            this.timermenu.Tick += new System.EventHandler(this.timermenu_Tick);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(777, 341);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnCapacitaciones);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnIdiomas);
            this.Controls.Add(this.btnCompetencias);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.BtnPuestos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(793, 380);
            this.MinimumSize = new System.Drawing.Size(793, 380);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuAdmin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBienvenido;
        private FontAwesome.Sharp.IconButton BtnPuestos;
        private FontAwesome.Sharp.IconButton btnseleccion;
        private FontAwesome.Sharp.IconButton btnCompetencias;
        private FontAwesome.Sharp.IconButton btnIdiomas;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private FontAwesome.Sharp.IconButton btnCapacitaciones;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timermenu;
    }
}