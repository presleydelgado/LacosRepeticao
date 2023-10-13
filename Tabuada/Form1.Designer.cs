namespace Tabuada
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
            this.textBox1valortabuada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1resultado = new System.Windows.Forms.RichTextBox();
            this.button2adicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1valortabuada
            // 
            this.textBox1valortabuada.Location = new System.Drawing.Point(151, 85);
            this.textBox1valortabuada.Name = "textBox1valortabuada";
            this.textBox1valortabuada.Size = new System.Drawing.Size(149, 26);
            this.textBox1valortabuada.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Multiplicação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número da tabuada";
            // 
            // richTextBox1resultado
            // 
            this.richTextBox1resultado.Location = new System.Drawing.Point(151, 163);
            this.richTextBox1resultado.Name = "richTextBox1resultado";
            this.richTextBox1resultado.Size = new System.Drawing.Size(499, 245);
            this.richTextBox1resultado.TabIndex = 3;
            this.richTextBox1resultado.Text = "";
            // 
            // button2adicao
            // 
            this.button2adicao.Location = new System.Drawing.Point(357, 118);
            this.button2adicao.Name = "button2adicao";
            this.button2adicao.Size = new System.Drawing.Size(120, 39);
            this.button2adicao.TabIndex = 4;
            this.button2adicao.Text = "Adição";
            this.button2adicao.UseVisualStyleBackColor = true;
            this.button2adicao.Click += new System.EventHandler(this.button2adicao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2adicao);
            this.Controls.Add(this.richTextBox1resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1valortabuada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1valortabuada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1resultado;
        private System.Windows.Forms.Button button2adicao;
    }
}

