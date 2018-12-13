namespace GrammarbotWinforms
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
            this.txtSentense = new System.Windows.Forms.TextBox();
            this.lblSentense = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPI_Key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSentense
            // 
            this.txtSentense.Location = new System.Drawing.Point(12, 72);
            this.txtSentense.Name = "txtSentense";
            this.txtSentense.Size = new System.Drawing.Size(432, 20);
            this.txtSentense.TabIndex = 0;
            // 
            // lblSentense
            // 
            this.lblSentense.AutoSize = true;
            this.lblSentense.Location = new System.Drawing.Point(12, 56);
            this.lblSentense.Name = "lblSentense";
            this.lblSentense.Size = new System.Drawing.Size(53, 13);
            this.lblSentense.TabIndex = 1;
            this.lblSentense.Text = "Sentence";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "API Key";
            // 
            // txtAPI_Key
            // 
            this.txtAPI_Key.Location = new System.Drawing.Point(12, 23);
            this.txtAPI_Key.Name = "txtAPI_Key";
            this.txtAPI_Key.Size = new System.Drawing.Size(212, 20);
            this.txtAPI_Key.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Language:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(232, 23);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(212, 20);
            this.txtLanguage.TabIndex = 7;
            this.txtLanguage.Text = "en-US";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 128);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 141);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAPI_Key);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSentense);
            this.Controls.Add(this.txtSentense);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSentense;
        private System.Windows.Forms.Label lblSentense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPI_Key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblStatus;
    }
}

