using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilizaServico.ServiceReference1;

namespace UtilizaServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BUSCA
        private void button2_Click(object sender, EventArgs e)
        {
            ClienteServiceClient servico = new ClienteServiceClient();
            try
            {

                var clienteBusca = servico.GetCliente(txtNome.Text);

                if(clienteBusca is null)
                {
                    txtCPF.Text = "";
                    MessageBox.Show("A busca não retornou resultados");
                }
                else
                {
                    txtCPF.Text = clienteBusca.CPF;
                }
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        
        //CADASTRO
        private void button1_Click(object sender, EventArgs e)
        {
            ClienteServiceClient servico = new ClienteServiceClient();
            try
            {
                ClienteEntidade clienteCadastro = new ClienteEntidade
                {
                    Nome = txtNome.Text
                    ,
                    CPF = txtCPF.Text
                };
                servico.AddCliente(clienteCadastro);

                MessageBox.Show("Cliente cadastro com sucesso");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
