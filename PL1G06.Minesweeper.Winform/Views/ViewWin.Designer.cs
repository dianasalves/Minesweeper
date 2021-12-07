namespace PL1G06.Minesweeper.Winform.Views
{
	partial class ViewWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWin));
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelVenceu = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSair.Location = new System.Drawing.Point(19, 107);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(140, 49);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelVenceu
            // 
            this.labelVenceu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVenceu.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenceu.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelVenceu.Location = new System.Drawing.Point(13, 14);
            this.labelVenceu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVenceu.Name = "labelVenceu";
            this.labelVenceu.Size = new System.Drawing.Size(321, 94);
            this.labelVenceu.TabIndex = 2;
            this.labelVenceu.Text = "Parabéns!\r\nVenceu o jogo!";
            this.labelVenceu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.BackColor = System.Drawing.Color.DarkGreen;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.Color.LightGreen;
            this.textBoxNome.Location = new System.Drawing.Point(95, 62);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(231, 27);
            this.textBoxNome.TabIndex = 4;
            this.textBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNome.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelNome.Location = new System.Drawing.Point(21, 62);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 28);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome:";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNome.Visible = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGuardar.Location = new System.Drawing.Point(188, 107);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(140, 49);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Visible = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ViewWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(347, 170);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelVenceu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 170);
            this.Name = "ViewWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENCEU";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewWin_Load);
            this.VisibleChanged += new System.EventHandler(this.ViewWin_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelVenceu;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonGuardar;
    }
}