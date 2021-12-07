namespace PL1G06.Minesweeper.Winform.Views
{
	partial class ViewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelLembrarPassword = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonNovaConta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxUsername.Location = new System.Drawing.Point(108, 132);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(385, 34);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPassword.Location = new System.Drawing.Point(108, 174);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(385, 34);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // linkLabelLembrarPassword
            // 
            this.linkLabelLembrarPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLembrarPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLembrarPassword.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelLembrarPassword.Location = new System.Drawing.Point(184, 270);
            this.linkLabelLembrarPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLembrarPassword.Name = "linkLabelLembrarPassword";
            this.linkLabelLembrarPassword.Size = new System.Drawing.Size(232, 23);
            this.linkLabelLembrarPassword.TabIndex = 3;
            this.linkLabelLembrarPassword.TabStop = true;
            this.linkLabelLembrarPassword.Text = "Esqueceste-te da Password?";
            this.linkLabelLembrarPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelLembrarPassword.Visible = false;
            this.linkLabelLembrarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLembrarPassword_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.LightGreen;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonLogin.Location = new System.Drawing.Point(228, 218);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(144, 48);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonNovaConta
            // 
            this.buttonNovaConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNovaConta.BackColor = System.Drawing.Color.LightGreen;
            this.buttonNovaConta.FlatAppearance.BorderSize = 0;
            this.buttonNovaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaConta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovaConta.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonNovaConta.Location = new System.Drawing.Point(177, 321);
            this.buttonNovaConta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNovaConta.Name = "buttonNovaConta";
            this.buttonNovaConta.Size = new System.Drawing.Size(247, 48);
            this.buttonNovaConta.TabIndex = 5;
            this.buttonNovaConta.Text = "Criar Nova Conta";
            this.buttonNovaConta.UseVisualStyleBackColor = false;
            this.buttonNovaConta.Click += new System.EventHandler(this.buttonNovaConta_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 85);
            this.label2.TabIndex = 8;
            this.label2.Text = "MINESWEEPER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVoltar.BackColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Voltar;
            this.buttonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonVoltar.Location = new System.Drawing.Point(9, 9);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(30, 30);
            this.buttonVoltar.TabIndex = 11;
            this.buttonVoltar.TabStop = false;
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.Sair;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSair.Location = new System.Drawing.Point(561, 9);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(30, 30);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.TabStop = false;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.ForeColor = System.Drawing.Color.LightGreen;
            this.buttonMostrar.Location = new System.Drawing.Point(497, 174);
            this.buttonMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(25, 34);
            this.buttonMostrar.TabIndex = 20;
            this.buttonMostrar.TabStop = false;
            this.buttonMostrar.Text = "*";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMostrar_MouseDown);
            this.buttonMostrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMostrar_MouseUp);
            // 
            // ViewLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNovaConta);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.linkLabelLembrarPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ViewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.LinkLabel linkLabelLembrarPassword;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonNovaConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonMostrar;
    }
}