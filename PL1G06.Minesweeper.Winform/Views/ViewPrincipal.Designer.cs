namespace PL1G06.Minesweeper.Winform.Views
{
    partial class ViewPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPrincipal));
            this.buttonStandalone = new System.Windows.Forms.Button();
            this.buttonRede = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpcoes = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStandalone
            // 
            this.buttonStandalone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStandalone.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStandalone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStandalone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStandalone.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStandalone.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonStandalone.Location = new System.Drawing.Point(36, 297);
            this.buttonStandalone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStandalone.Name = "buttonStandalone";
            this.buttonStandalone.Size = new System.Drawing.Size(176, 75);
            this.buttonStandalone.TabIndex = 1;
            this.buttonStandalone.TabStop = false;
            this.buttonStandalone.Text = "Standalone";
            this.buttonStandalone.UseVisualStyleBackColor = false;
            this.buttonStandalone.Click += new System.EventHandler(this.buttonStandalone_Click);
            // 
            // buttonRede
            // 
            this.buttonRede.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRede.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRede.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRede.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonRede.Location = new System.Drawing.Point(212, 297);
            this.buttonRede.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRede.Name = "buttonRede";
            this.buttonRede.Size = new System.Drawing.Size(176, 75);
            this.buttonRede.TabIndex = 2;
            this.buttonRede.TabStop = false;
            this.buttonRede.Text = "Rede";
            this.buttonRede.UseVisualStyleBackColor = false;
            this.buttonRede.Click += new System.EventHandler(this.buttonRede_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 118);
            this.label1.TabIndex = 2;
            this.label1.Text = "MINESWEEPER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpcoes
            // 
            this.buttonOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpcoes.BackColor = System.Drawing.Color.LightGreen;
            this.buttonOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpcoes.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpcoes.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonOpcoes.Location = new System.Drawing.Point(388, 297);
            this.buttonOpcoes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpcoes.Name = "buttonOpcoes";
            this.buttonOpcoes.Size = new System.Drawing.Size(176, 75);
            this.buttonOpcoes.TabIndex = 3;
            this.buttonOpcoes.TabStop = false;
            this.buttonOpcoes.Text = "Opções";
            this.buttonOpcoes.UseVisualStyleBackColor = false;
            this.buttonOpcoes.Click += new System.EventHandler(this.buttonOpcoes_Click);
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
            this.buttonSair.TabIndex = 4;
            this.buttonSair.TabStop = false;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // ViewPrincipal
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonOpcoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRede);
            this.Controls.Add(this.buttonStandalone);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ViewPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.ViewPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStandalone;
        private System.Windows.Forms.Button buttonRede;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOpcoes;
        private System.Windows.Forms.Button buttonSair;
    }
}

