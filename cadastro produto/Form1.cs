using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_produto
{
    public partial class Form1 : Form
    {

        private List<CadastrarProduto> produtos = new List<CadastrarProduto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarProduto a = new CadastrarProduto();

            try
            {
                a.Codigo = textBox1.Text;
                a.Descricao = textBox2.Text;
                a.PrecoAquisicao = Convert.ToDouble(textBox3.Text);
                a.Lucro = Convert.ToDouble(textBox4.Text);

                a.ValorVenda = (a.PrecoAquisicao * (a.Lucro / 100)) + a.PrecoAquisicao;
                textBox5.Text = a.ValorVenda.ToString();

                produtos.Add(a);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;
            }
            catch (Exception ex)
            {
                textBox3.Clear();
                textBox4.Clear();
                MessageBox.Show("Há um erro de digitação. Tente novamente!");
            }
            

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            produtos.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;
        }
    }
}
