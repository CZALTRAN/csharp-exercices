namespace ImageViewer
{
    partial class FrmPrin
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkAlongar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMudarFundo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutPanel.Controls.Add(this.chkAlongar, 0, 1);
            this.layoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.layoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 2;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(454, 355);
            this.layoutPanel.TabIndex = 0;
            // 
            // chkAlongar
            // 
            this.chkAlongar.AutoSize = true;
            this.chkAlongar.Location = new System.Drawing.Point(3, 322);
            this.chkAlongar.Name = "chkAlongar";
            this.chkAlongar.Size = new System.Drawing.Size(62, 17);
            this.chkAlongar.TabIndex = 1;
            this.chkAlongar.Text = "Alongar";
            this.chkAlongar.UseVisualStyleBackColor = true;
            this.chkAlongar.CheckedChanged += new System.EventHandler(this.chkAlongar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layoutPanel.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMostrar);
            this.flowLayoutPanel1.Controls.Add(this.btnLimpar);
            this.flowLayoutPanel1.Controls.Add(this.btnMudarFundo);
            this.flowLayoutPanel1.Controls.Add(this.btnFechar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 322);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(3, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(84, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMudarFundo
            // 
            this.btnMudarFundo.Location = new System.Drawing.Point(165, 3);
            this.btnMudarFundo.Name = "btnMudarFundo";
            this.btnMudarFundo.Size = new System.Drawing.Size(92, 23);
            this.btnMudarFundo.TabIndex = 2;
            this.btnMudarFundo.Text = "Mudar Fundo";
            this.btnMudarFundo.UseVisualStyleBackColor = true;
            this.btnMudarFundo.Click += new System.EventHandler(this.btnMudarFundo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(263, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog.Title = "Escolha uma imagem";
            // 
            // FrmPrin
            // 
            this.AcceptButton = this.btnMostrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(454, 355);
            this.Controls.Add(this.layoutPanel);
            this.Name = "FrmPrin";
            this.Text = "Visualizador de Imagem";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAlongar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMudarFundo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

