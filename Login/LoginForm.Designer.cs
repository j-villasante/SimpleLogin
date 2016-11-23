namespace Login
{
    partial class LoginForm
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
            this.butLogin = new System.Windows.Forms.Button();
            this.tboUsuario = new System.Windows.Forms.TextBox();
            this.tboPassword = new System.Windows.Forms.TextBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labLoginMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butLogin
            // 
            this.butLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.Location = new System.Drawing.Point(77, 219);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(131, 30);
            this.butLogin.TabIndex = 0;
            this.butLogin.Text = "Iniciar sesión";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tboUsuario
            // 
            this.tboUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboUsuario.Location = new System.Drawing.Point(57, 61);
            this.tboUsuario.Name = "tboUsuario";
            this.tboUsuario.Size = new System.Drawing.Size(181, 26);
            this.tboUsuario.TabIndex = 1;
            this.tboUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onEnterPressed);
            // 
            // tboPassword
            // 
            this.tboPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboPassword.Location = new System.Drawing.Point(57, 129);
            this.tboPassword.Name = "tboPassword";
            this.tboPassword.PasswordChar = '•';
            this.tboPassword.Size = new System.Drawing.Size(181, 26);
            this.tboPassword.TabIndex = 2;
            this.tboPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onEnterPressed);
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuario.Location = new System.Drawing.Point(53, 38);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(64, 20);
            this.labUsuario.TabIndex = 3;
            this.labUsuario.Text = "Usuario";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(53, 106);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(92, 20);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "Contraseña";
            // 
            // labLoginMessage
            // 
            this.labLoginMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labLoginMessage.ForeColor = System.Drawing.Color.Red;
            this.labLoginMessage.Location = new System.Drawing.Point(12, 170);
            this.labLoginMessage.Name = "labLoginMessage";
            this.labLoginMessage.Size = new System.Drawing.Size(260, 25);
            this.labLoginMessage.TabIndex = 5;
            this.labLoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labLoginMessage.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labLoginMessage);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.tboPassword);
            this.Controls.Add(this.tboUsuario);
            this.Controls.Add(this.butLogin);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox tboUsuario;
        private System.Windows.Forms.TextBox tboPassword;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labLoginMessage;
    }
}

