namespace PL1G06.Minesweeper.Winform.Views
{
    partial class ViewTOP10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTOP10));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.listBoxTOP10Medio = new System.Windows.Forms.ListBox();
            this.listBoxTOP10Facil = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMTF = new System.Windows.Forms.TextBox();
            this.textBoxMTM = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(253, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP10";
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
            // listBoxTOP10Medio
            // 
            this.listBoxTOP10Medio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTOP10Medio.BackColor = System.Drawing.Color.LightGreen;
            this.listBoxTOP10Medio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTOP10Medio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTOP10Medio.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBoxTOP10Medio.FormattingEnabled = true;
            this.listBoxTOP10Medio.HorizontalScrollbar = true;
            this.listBoxTOP10Medio.IntegralHeight = false;
            this.listBoxTOP10Medio.ItemHeight = 28;
            this.listBoxTOP10Medio.Location = new System.Drawing.Point(303, 103);
            this.listBoxTOP10Medio.Name = "listBoxTOP10Medio";
            this.listBoxTOP10Medio.Size = new System.Drawing.Size(285, 230);
            this.listBoxTOP10Medio.TabIndex = 12;
            this.listBoxTOP10Medio.TabStop = false;
            this.listBoxTOP10Medio.UseTabStops = false;
            this.listBoxTOP10Medio.SelectedIndexChanged += new System.EventHandler(this.listBoxTOP10Medio_SelectedIndexChanged);
            // 
            // listBoxTOP10Facil
            // 
            this.listBoxTOP10Facil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTOP10Facil.BackColor = System.Drawing.Color.LightGreen;
            this.listBoxTOP10Facil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTOP10Facil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTOP10Facil.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBoxTOP10Facil.FormattingEnabled = true;
            this.listBoxTOP10Facil.HorizontalScrollbar = true;
            this.listBoxTOP10Facil.IntegralHeight = false;
            this.listBoxTOP10Facil.ItemHeight = 28;
            this.listBoxTOP10Facil.Location = new System.Drawing.Point(12, 103);
            this.listBoxTOP10Facil.Name = "listBoxTOP10Facil";
            this.listBoxTOP10Facil.Size = new System.Drawing.Size(285, 230);
            this.listBoxTOP10Facil.TabIndex = 13;
            this.listBoxTOP10Facil.TabStop = false;
            this.listBoxTOP10Facil.UseTabStops = false;
            this.listBoxTOP10Facil.SelectedIndexChanged += new System.EventHandler(this.listBoxTOP10Facil_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = " Fácil:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(303, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = " Médio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Melhor tempo Fácil offline:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(303, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Melhor tempo Médio offline:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMTF
            // 
            this.textBoxMTF.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxMTF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMTF.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxMTF.Location = new System.Drawing.Point(12, 372);
            this.textBoxMTF.Name = "textBoxMTF";
            this.textBoxMTF.ReadOnly = true;
            this.textBoxMTF.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxMTF.Size = new System.Drawing.Size(285, 34);
            this.textBoxMTF.TabIndex = 18;
            this.textBoxMTF.TabStop = false;
            // 
            // textBoxMTM
            // 
            this.textBoxMTM.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxMTM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMTM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMTM.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxMTM.Location = new System.Drawing.Point(303, 372);
            this.textBoxMTM.Name = "textBoxMTM";
            this.textBoxMTM.ReadOnly = true;
            this.textBoxMTM.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxMTM.Size = new System.Drawing.Size(285, 34);
            this.textBoxMTM.TabIndex = 19;
            this.textBoxMTM.TabStop = false;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApagar.AutoSize = true;
            this.buttonApagar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonApagar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonApagar.Location = new System.Drawing.Point(9, 410);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(120, 31);
            this.buttonApagar.TabIndex = 20;
            this.buttonApagar.TabStop = false;
            this.buttonApagar.Text = "Apagar Registos";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // ViewTOP10
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.textBoxMTM);
            this.Controls.Add(this.textBoxMTF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTOP10Facil);
            this.Controls.Add(this.listBoxTOP10Medio);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ViewTOP10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP 10";
            this.VisibleChanged += new System.EventHandler(this.ViewTOP10_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ListBox listBoxTOP10Medio;
        private System.Windows.Forms.ListBox listBoxTOP10Facil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMTF;
        private System.Windows.Forms.TextBox textBoxMTM;
        private System.Windows.Forms.Button buttonApagar;
    }
}