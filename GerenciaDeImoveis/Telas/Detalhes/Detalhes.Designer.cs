namespace GerenciaDeImoveis
{
    partial class Detalhes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox_Observacoes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 443);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.richTextBox_Observacoes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 139);
            this.panel3.TabIndex = 1;
            // 
            // richTextBox_Observacoes
            // 
            this.richTextBox_Observacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.richTextBox_Observacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Observacoes.CausesValidation = false;
            this.richTextBox_Observacoes.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.richTextBox_Observacoes.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_Observacoes.HideSelection = false;
            this.richTextBox_Observacoes.Location = new System.Drawing.Point(12, 40);
            this.richTextBox_Observacoes.Name = "richTextBox_Observacoes";
            this.richTextBox_Observacoes.ReadOnly = true;
            this.richTextBox_Observacoes.Size = new System.Drawing.Size(478, 87);
            this.richTextBox_Observacoes.TabIndex = 100;
            this.richTextBox_Observacoes.TabStop = false;
            this.richTextBox_Observacoes.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(1, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Observações";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-9, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 109);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16F);
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 1;
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detalhes";
            this.Text = "Detalhes";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Observacoes;
    }
}