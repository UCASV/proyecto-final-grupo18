
namespace project
{
    partial class FormContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio de contraseña";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 135);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 7);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.Silver;
            this.linkpass.Location = new System.Drawing.Point(187, 484);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(63, 17);
            this.linkpass.TabIndex = 12;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Regresar";
            this.linkpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpass_LinkClicked);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogin.Location = new System.Drawing.Point(81, 425);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(287, 41);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "Confirmar";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(66, 104);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(287, 25);
            this.txtuser.TabIndex = 13;
            this.txtuser.Text = "USUARIO";
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(65, 199);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(288, 7);
            this.progressBar2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(66, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 25);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Pregunta de seguridad";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(65, 256);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(288, 7);
            this.progressBar3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(65, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 25);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Respuesta";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(65, 321);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(288, 7);
            this.progressBar4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(65, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 25);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Nueva contraseña";
            // 
            // FormContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(442, 535);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContraseña";
            this.Text = "FormContraseña";
            this.Load += new System.EventHandler(this.FormContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.TextBox textBox3;
    }
}