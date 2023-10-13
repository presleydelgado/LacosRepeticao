using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valortabuada = int.Parse(textBox1valortabuada.Text);

            for (int x = 0; x <= valortabuada; x++) 
            {
                for (int y = 0; y <= valortabuada; y++)
                {
                   // richTextBox1resultado.AppendText("\nValor: " + x + " x " + y + " = " + (x * y)); jeito antigo
                   // modo mais limpo de codar as variaveis V V V
                   richTextBox1resultado.AppendText($"\nValor: {x} x {y} = {x*y} " );
                }
                richTextBox1resultado.AppendText("\n");
            }
        }

        private void button2adicao_Click(object sender, EventArgs e)
        {
            int valortabuada = int.Parse(textBox1valortabuada.Text);

            for (int x = 0; x <= valortabuada; x++)
            {
                for (int y = 0; y <= valortabuada; y++)
                {
                    // richTextBox1resultado.AppendText("\nValor: " + x + " x " + y + " = " + (x * y)); jeito antigo
                    // modo mais limpo de codar as variaveis V V V
                    richTextBox1resultado.AppendText($"\nValor: {x} + {y} = {x + y} ");
                }
                richTextBox1resultado.AppendText("\n");
            }
        }
    }
}
