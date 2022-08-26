namespace Mes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.btnresposta = new System.Windows.Forms.Button();
            this.txtrespostaMes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o número do mês que está em dúvida";
            // 
            // txtmes
            // 
            this.txtmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.ForeColor = System.Drawing.Color.Black;
            this.txtmes.Location = new System.Drawing.Point(183, 182);
            this.txtmes.Margin = new System.Windows.Forms.Padding(4);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(130, 31);
            this.txtmes.TabIndex = 2;
            this.txtmes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnresposta
            // 
            this.btnresposta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnresposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresposta.ForeColor = System.Drawing.Color.White;
            this.btnresposta.Location = new System.Drawing.Point(149, 251);
            this.btnresposta.Margin = new System.Windows.Forms.Padding(4);
            this.btnresposta.Name = "btnresposta";
            this.btnresposta.Size = new System.Drawing.Size(191, 57);
            this.btnresposta.TabIndex = 3;
            this.btnresposta.Text = "Buscar";
            this.btnresposta.UseVisualStyleBackColor = false;
            this.btnresposta.Click += new System.EventHandler(this.Btnresposta_Click);
            // 
            // txtrespostaMes
            // 
            this.txtrespostaMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtrespostaMes.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrespostaMes.ForeColor = System.Drawing.Color.White;
            this.txtrespostaMes.Location = new System.Drawing.Point(114, 352);
            this.txtrespostaMes.Margin = new System.Windows.Forms.Padding(4);
            this.txtrespostaMes.Name = "txtrespostaMes";
            this.txtrespostaMes.Size = new System.Drawing.Size(258, 34);
            this.txtrespostaMes.TabIndex = 4;
            this.txtrespostaMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(341, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(501, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrespostaMes);
            this.Controls.Add(this.btnresposta);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descubra Mês";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Button btnresposta;
        private System.Windows.Forms.TextBox txtrespostaMes;
        private System.Windows.Forms.Button button1;
    }
}

