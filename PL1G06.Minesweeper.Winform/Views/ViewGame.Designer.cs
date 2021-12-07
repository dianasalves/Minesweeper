namespace PL1G06.Minesweeper.Winform.Views
{
    partial class ViewGame
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
		public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGame));
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.textBoxFlags = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonJogo = new System.Windows.Forms.Button();
            this.panelTabuleiro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTempo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTempo.CausesValidation = false;
            this.textBoxTempo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTempo.Enabled = false;
            this.textBoxTempo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempo.ForeColor = System.Drawing.Color.Red;
            this.textBoxTempo.Location = new System.Drawing.Point(403, 14);
            this.textBoxTempo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.ReadOnly = true;
            this.textBoxTempo.Size = new System.Drawing.Size(92, 45);
            this.textBoxTempo.TabIndex = 0;
            this.textBoxTempo.TabStop = false;
            this.textBoxTempo.Text = "000";
            this.textBoxTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFlags
            // 
            this.textBoxFlags.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxFlags.Enabled = false;
            this.textBoxFlags.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlags.ForeColor = System.Drawing.Color.Red;
            this.textBoxFlags.Location = new System.Drawing.Point(13, 14);
            this.textBoxFlags.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFlags.Name = "textBoxFlags";
            this.textBoxFlags.ReadOnly = true;
            this.textBoxFlags.Size = new System.Drawing.Size(92, 45);
            this.textBoxFlags.TabIndex = 2;
            this.textBoxFlags.TabStop = false;
            this.textBoxFlags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSair.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSair.Location = new System.Drawing.Point(192, 322);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(124, 41);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonJogo
            // 
            this.buttonJogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonJogo.BackColor = System.Drawing.Color.Transparent;
            this.buttonJogo.BackgroundImage = global::PL1G06.Minesweeper.Winform.Properties.Resources.BotaoJogo;
            this.buttonJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonJogo.FlatAppearance.BorderSize = 0;
            this.buttonJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJogo.Location = new System.Drawing.Point(229, 14);
            this.buttonJogo.Name = "buttonJogo";
            this.buttonJogo.Size = new System.Drawing.Size(50, 50);
            this.buttonJogo.TabIndex = 41;
            this.buttonJogo.UseVisualStyleBackColor = false;
            this.buttonJogo.Click += new System.EventHandler(this.buttonJogo_Click);
            // 
            // panelTabuleiro
            // 
            this.panelTabuleiro.AutoSize = true;
            this.panelTabuleiro.Location = new System.Drawing.Point(13, 67);
            this.panelTabuleiro.Name = "panelTabuleiro";
            this.panelTabuleiro.Size = new System.Drawing.Size(221, 213);
            this.panelTabuleiro.TabIndex = 42;
            // 
            // ViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(508, 377);
            this.ControlBox = false;
            this.Controls.Add(this.buttonJogo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.panelTabuleiro);
            this.Controls.Add(this.textBoxFlags);
            this.Controls.Add(this.textBoxTempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(293, 173);
            this.Name = "ViewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MINESWEEPER";
            this.VisibleChanged += new System.EventHandler(this.ViewGame_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.TextBox textBoxFlags;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonJogo;
        private System.Windows.Forms.Panel panelTabuleiro;
    }
}