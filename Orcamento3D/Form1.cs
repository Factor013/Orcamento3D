using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Orcamento3D

{
    public partial class Form1 : Form
    {
        private float peso, tempo_impressao, erros, depreciacao, valor_filamento,
                      qtd_comprada, energia, modelagem, fixacao,
                      lucro, consumo, valor_maquina, lixas, tintas,
                      quimicos, mao_obra, desc_porcento;
        private int tempo, dias, horas;

        private void textBox_filamentoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_qtdComprada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_energia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_modelagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_consumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_lucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_valorMaquina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_meses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_lixas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_tintas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void toolStripLabel_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicação desenvolvida para auxiliar na realização de orçamentos de impressão 3D\n\n" +
                "           Sobre a LICENÇA PÚBLICA GERAL GNU \n                Versão 3, 29 de junho de 2007. \n\n\n\n" +
                "Desenvolvido por Rafael Reis.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_quimicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_maoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_descPorcento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_depreciacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_erros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_fixacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_tempoImpressao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void toolStripLabel_carregarPref_Click(object sender, EventArgs e)
        {
            carregaPref();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            salvaPref();
        }

        public void getValores()
        {
            if (string.IsNullOrWhiteSpace(textBox_peso.Text))
            {
                peso = 0;
            }
            else
            {
                peso = float.Parse(textBox_peso.Text);
            }
            if (string.IsNullOrWhiteSpace(textBox_tempoImpressao.Text))
            {
                tempo_impressao = 0;
            }
            else
            {
                tempo_impressao = float.Parse(textBox_tempoImpressao.Text);
            }   
            if (string.IsNullOrWhiteSpace(textBox_erros.Text))
            {
                erros = 0;
            }
            else
            {
                erros = float.Parse(textBox_erros.Text);
            }
            if (string.IsNullOrWhiteSpace(textBox_depreciacao.Text))
            {
                depreciacao = 0;
            }
            else
            {
                depreciacao = float.Parse(textBox_depreciacao.Text);
            }



            if (string.IsNullOrWhiteSpace(textBox_filamentoValor.Text))
            {
                valor_filamento = 0;
            }
            else
            {
                valor_filamento = float.Parse(textBox_filamentoValor.Text);
            }  
            if (string.IsNullOrWhiteSpace(textBox_qtdComprada.Text))
            {
                qtd_comprada = 0;
            }
            else
            {
                qtd_comprada = float.Parse(textBox_qtdComprada.Text);
            }   
            if (string.IsNullOrWhiteSpace(textBox_energia.Text))
            {
                energia = 0;
            }
            else
            {
                energia = float.Parse(textBox_energia.Text);
            }
            if (string.IsNullOrWhiteSpace(textBox_modelagem.Text))
            {
                modelagem = 0;
            }
            else
            {
                modelagem = float.Parse(textBox_modelagem.Text);
            }                
            if (string.IsNullOrWhiteSpace(textBox_fixacao.Text))
            {
                fixacao = 0;
            }
            else
            {
                fixacao = float.Parse(textBox_fixacao.Text);
            }                
            if (string.IsNullOrWhiteSpace(textBox_lucro.Text))
            {
                lucro = 0;
            }
            else
            {
                lucro = float.Parse(textBox_lucro.Text);
            }
            if (string.IsNullOrWhiteSpace(textBox_consumo.Text))
            {
                consumo = 0;
            }
            else
            {
                consumo = float.Parse(textBox_consumo.Text);
            }
                

            if (string.IsNullOrWhiteSpace(textBox_valorMaquina.Text))
            {
                valor_maquina = 0;
            }
            else
            {
                valor_maquina = float.Parse(textBox_valorMaquina.Text);
            }    
            if (string.IsNullOrWhiteSpace(textBox_meses.Text))
            {
                tempo = 0;
            }
            else
            {
                tempo = int.Parse(textBox_meses.Text);
            }                
            if (string.IsNullOrWhiteSpace(textBox_dias.Text))
            {
                dias = 0;
            }
            else
            {
                dias = int.Parse(textBox_dias.Text);
            }               
            if (string.IsNullOrWhiteSpace(textBox_horas.Text))
            {
                horas = 0;
            }
            else
            {
                horas = int.Parse(textBox_horas.Text);
            }
                

            if (string.IsNullOrWhiteSpace(textBox_lixas.Text))
            {
                lixas = 0;
            }
            else
            {
                lixas = float.Parse(textBox_lixas.Text);
            }   
            if (string.IsNullOrWhiteSpace(textBox_tintas.Text))
            {
                tintas = 0;
            }
            else
            {
                tintas = float.Parse(textBox_tintas.Text);
            }
            if (string.IsNullOrWhiteSpace(textBox_quimicos.Text))
            {
                quimicos = 0;
            }
            else
            {
                quimicos = float.Parse(textBox_quimicos.Text);
            }
            if (string.IsNullOrWhiteSpace(textBox_maoObra.Text))
            {
                mao_obra = 0;
            }
            else
            {
                mao_obra = float.Parse(textBox_maoObra.Text);
            }


            if (string.IsNullOrWhiteSpace(textBox_descPorcento.Text))
            {
                desc_porcento = 0;
            }
            else
            {
                desc_porcento = float.Parse(textBox_descPorcento.Text);
            }
        }

        public void salvaPref()
        { 
            string filePath = @"C:\Preferencias.txt";

            
            StreamWriter streamWriter = new StreamWriter(filePath);

            
            streamWriter.WriteLine(textBox_filamentoValor.Text);
            streamWriter.WriteLine(textBox_lucro.Text);
            streamWriter.WriteLine(textBox_qtdComprada.Text);
            streamWriter.WriteLine(textBox_energia.Text);
            streamWriter.WriteLine(textBox_consumo.Text);
            streamWriter.WriteLine(textBox_valorMaquina.Text);
            streamWriter.WriteLine(textBox_meses.Text);
            streamWriter.WriteLine(textBox_dias.Text);
            streamWriter.WriteLine(textBox_horas.Text);

            streamWriter.Flush();

            streamWriter.Close();

            
            MessageBox.Show("Preferências Guardadas com Sucesso !!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void carregaPref()
        {
            try
            {
                string filePath = @"C:\Preferencias.txt";

                StreamReader streamReader = new StreamReader(filePath);

                textBox_filamentoValor.Text = streamReader.ReadLine();
                textBox_lucro.Text = streamReader.ReadLine();
                textBox_qtdComprada.Text = streamReader.ReadLine();
                textBox_energia.Text = streamReader.ReadLine();
                textBox_consumo.Text = streamReader.ReadLine();
                textBox_valorMaquina.Text = streamReader.ReadLine();
                textBox_meses.Text = streamReader.ReadLine();
                textBox_dias.Text = streamReader.ReadLine();
                textBox_horas.Text = streamReader.ReadLine();

                streamReader.Close();
            }
            catch(Exception){
                MessageBox.Show("Erro ao salvar preferências, por favor, salve-as novamente", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        private void button_calcular_Click(object sender, EventArgs e)
        {
            label_valorFinal.BackColor = Color.LightGray;
            label_valorTotal.BackColor = Color.LightGreen;
            getValores();

            float valorInvest, lucroTotal;

            float filamento = (valor_filamento / (qtd_comprada*1000)) * peso; //calcula valor por grama de filamento gasto
            float custoEnergia = ((tempo_impressao / 60) * (consumo / 1000)) * energia; //calcula custo de energia da impressao
            float taxaErros = (filamento + custoEnergia)*(erros / 100); // calcula a taxa de erros em cima do que foi gasto pela impressão
            float custoImpressao = filamento + custoEnergia + taxaErros + fixacao ; //calcula o custo total gasto na impressão do objeto

            if(string.IsNullOrWhiteSpace(textBox_valorMaquina.Text) && string.IsNullOrWhiteSpace(textBox_meses.Text) && string.IsNullOrWhiteSpace(textBox_dias.Text) && string.IsNullOrWhiteSpace(textBox_horas.Text))
            {
                valorInvest = 0;
            }
            else
            {
                valorInvest = (valor_maquina / (horas * dias * tempo)) * (tempo_impressao/60);  //calcula valor por hora a ser cobrado pelo investimento
            }
             
            float acabamento = lixas + tintas + quimicos + mao_obra;

            float custoDepreci = custoImpressao * (depreciacao / 100);
            if (string.IsNullOrWhiteSpace(textBox_lucro.Text)){
                lucroTotal = 0;
            }
            else
            {
                lucroTotal = (custoImpressao + valorInvest + acabamento + custoDepreci) * (lucro / 100);
            }
             
            float valorTotal = custoImpressao + valorInvest + acabamento + lucroTotal + modelagem + custoDepreci;
            float descontoTotal = valorTotal * (desc_porcento / 100);
            float valorFinal = valorTotal - descontoTotal;


            label_acabamento.Text = "Acabamento: R$ " + Math.Round(acabamento, 2).ToString();
            if (valorFinal >= 0 && valorTotal >= 0) 
            {
                label_valorTotal.Text = Math.Round(valorTotal, 2).ToString();
                label_valorFinal.Text = Math.Round(valorFinal, 2).ToString();
            }
            else
            {
                label_valorTotal.Text = "0";
                label_valorFinal.Text = "0";
            }
            
            

           
        }

        
        
        public Form1()
        {

            InitializeComponent();
            Limpar();

            toolTip1.SetToolTip(textBox_modelagem, "Se houver modelagem");
            toolTip1.SetToolTip(textBox_energia, "Verificar preço do kW/h");
            
        }
        ToolTip toolTip1 = new ToolTip();

        public void Limpar()
        {
            //groupbox Gastos com a Impressão
            textBox_peso.Text = "";
            textBox_tempoImpressao.Text = "";
            textBox_erros.Text = "";
            textBox_depreciacao.Text = "";
            

            //groupbox Custos
            textBox_filamentoValor.Text = "";
            textBox_qtdComprada.Text = "";
            textBox_energia.Text = "";
            textBox_modelagem.Text = "";
            textBox_fixacao.Text = "";
            textBox_lucro.Text = "";
            textBox_consumo.Text = "";
          
            //groupbox Retorno do Investimento
            textBox_valorMaquina.Text = "";
            textBox_meses.Text = "";
            textBox_dias.Text = "";
            textBox_horas.Text = "";

            //groupbox Acabamento
            textBox_lixas.Text = "";
            textBox_tintas.Text = "";
            textBox_quimicos.Text = "";
            textBox_maoObra.Text = "";
            label_acabamento.Text = "";

            //groupbox Descontos
            textBox_descPorcento.Text = "";

            //groupbox Valores
            label_valorTotal.Text = "";
            label_valorFinal.Text = "";

        }


        private void button_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


    }
}
