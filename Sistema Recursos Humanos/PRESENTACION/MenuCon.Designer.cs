namespace Sistema_Recursos_Humanos
{
    partial class MenuConsul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuConsul));
            this.BtnCandidatos = new FontAwesome.Sharp.IconButton();
            this.btnExperiencia = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcargauser = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCandidatos
            // 
            this.BtnCandidatos.BackColor = System.Drawing.Color.White;
            this.BtnCandidatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BtnCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCandidatos.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCandidatos.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.BtnCandidatos.IconColor = System.Drawing.Color.Black;
            this.BtnCandidatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCandidatos.IconSize = 90;
            this.BtnCandidatos.Location = new System.Drawing.Point(109, 105);
            this.BtnCandidatos.Name = "BtnCandidatos";
            this.BtnCandidatos.Size = new System.Drawing.Size(266, 160);
            this.BtnCandidatos.TabIndex = 0;
            this.BtnCandidatos.Text = "Candidatos";
            this.BtnCandidatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCandidatos.UseVisualStyleBackColor = false;
            this.BtnCandidatos.Click += new System.EventHandler(this.BtnCandidatos_Click);
            // 
            // btnExperiencia
            // 
            this.btnExperiencia.BackColor = System.Drawing.Color.White;
            this.btnExperiencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExperiencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnExperiencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExperiencia.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnExperiencia.IconColor = System.Drawing.Color.Black;
            this.btnExperiencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExperiencia.IconSize = 90;
            this.btnExperiencia.Location = new System.Drawing.Point(425, 105);
            this.btnExperiencia.Name = "btnExperiencia";
            this.btnExperiencia.Size = new System.Drawing.Size(266, 160);
            this.btnExperiencia.TabIndex = 1;
            this.btnExperiencia.Text = "Experiencia Laboral";
            this.btnExperiencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExperiencia.UseVisualStyleBackColor = false;
            this.btnExperiencia.Click += new System.EventHandler(this.btnExperiencia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.lblcargauser);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 42);
            this.panel1.TabIndex = 2;
            // 
            // lblcargauser
            // 
            this.lblcargauser.AutoSize = true;
            this.lblcargauser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargauser.Location = new System.Drawing.Point(342, 9);
            this.lblcargauser.Name = "lblcargauser";
            this.lblcargauser.Size = new System.Drawing.Size(0, 29);
            this.lblcargauser.TabIndex = 1;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(197, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(417, 29);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Sistema De Reclutamiento Unapec";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Snow;
            this.lblHora.Location = new System.Drawing.Point(301, 289);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(125, 55);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "label";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Snow;
            this.lblfecha.Location = new System.Drawing.Point(258, 344);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(84, 37);
            this.lblfecha.TabIndex = 12;
            this.lblfecha.Text = "label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuConsul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(788, 427);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExperiencia);
            this.Controls.Add(this.BtnCandidatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 483);
            this.MinimumSize = new System.Drawing.Size(810, 483);
            this.Name = "MenuConsul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuConsul_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnCandidatos;
        private FontAwesome.Sharp.IconButton btnExperiencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcargauser;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timer1;
    }
}