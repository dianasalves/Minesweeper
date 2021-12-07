namespace PL1G06.Minesweeper.Winform.Views
{
	partial class ViewDificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDificuldade));
            this.buttonFacil = new System.Windows.Forms.Button();
            this.buttonMedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFacil
            // 
            this.buttonFacil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFacil.BackColor = System.Drawing.Color.LightGreen;
            this.buttonFacil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFacil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacil.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonFacil.Location = new System.Drawing.Point(213, 211);
            this.buttonFacil.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFacil.Name = "buttonFacil";
            this.buttonFacil.Size = new System.Drawing.Size(175, 63);
            this.buttonFacil.TabIndex = 0;
            this.buttonFacil.Text = "Fácil";
            this.buttonFacil.UseVisualStyleBackColor = false;
            this.buttonFacil.Click += new System.EventHandler(this.buttonFacil_Click);
            // 
            // buttonMedio
            // 
            this.buttonMedio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMedio.BackColor = System.Drawing.Color.LightGreen;
            this.buttonMedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMedio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedio.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonMedio.Location = new System.Drawing.Point(213, 274);
            this.buttonMedio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMedio.Name = "buttonMedio";
            this.buttonMedio.Size = new System.Drawing.Size(175, 63);
            this.buttonMedio.TabIndex = 1;
            this.buttonMedio.Text = "Médio";
            this.buttonMedio.UseVisualStyleBackColor = false;
            this.buttonMedio.Click += new System.EventHandler(this.buttonMedio_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 100);
            this.label1.TabIndex = 7;
            this.label1.Text = "MINESWEEPER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonSair.TabIndex = 8;
            this.buttonSair.TabStop = false;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
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
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.TabStop = false;
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // ViewDificuldade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMedio);
            this.Controls.Add(this.buttonFacil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ViewDificuldade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha de Dificuldade";
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonFacil;
		private System.Windows.Forms.Button buttonMedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonVoltar;
    }
}