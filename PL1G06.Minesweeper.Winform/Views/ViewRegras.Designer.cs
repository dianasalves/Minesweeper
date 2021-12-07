namespace PL1G06.Minesweeper.Winform.Views
{
	partial class ViewRegras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRegras));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.richTextBoxRegras = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonVoltar.TabIndex = 13;
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
            this.buttonSair.Location = new System.Drawing.Point(891, 11);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(30, 30);
            this.buttonSair.TabIndex = 12;
            this.buttonSair.TabStop = false;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // richTextBoxRegras
            // 
            this.richTextBoxRegras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRegras.BackColor = System.Drawing.Color.LightGreen;
            this.richTextBoxRegras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxRegras.CausesValidation = false;
            this.richTextBoxRegras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRegras.ForeColor = System.Drawing.Color.DarkGreen;
            this.richTextBoxRegras.Location = new System.Drawing.Point(41, 156);
            this.richTextBoxRegras.Name = "richTextBoxRegras";
            this.richTextBoxRegras.ReadOnly = true;
            this.richTextBoxRegras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxRegras.Size = new System.Drawing.Size(849, 464);
            this.richTextBoxRegras.TabIndex = 12;
            this.richTextBoxRegras.TabStop = false;
            this.richTextBoxRegras.Text = resources.GetString("richTextBoxRegras.Text");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 119);
            this.label1.TabIndex = 8;
            this.label1.Text = "MINESWEEPER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewRegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(930, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxRegras);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(930, 670);
            this.MinimumSize = new System.Drawing.Size(930, 670);
            this.Name = "ViewRegras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regras do Jogo";
            this.TopMost = true;
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.RichTextBox richTextBoxRegras;
        private System.Windows.Forms.Label label1;
    }
}