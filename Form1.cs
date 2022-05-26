using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quantidade_dias_mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_mes.Items.Add("Janeiro");
            cb_mes.Items.Add("Fevereiro");
            cb_mes.Items.Add("Março");
            cb_mes.Items.Add("Abril");
            cb_mes.Items.Add("Maio");
            cb_mes.Items.Add("Junho");
            cb_mes.Items.Add("Julho");
            cb_mes.Items.Add("Agosto");
            cb_mes.Items.Add("Setembro");
            cb_mes.Items.Add("Outubro");
            cb_mes.Items.Add("Novembro");
            cb_mes.Items.Add("Dezembro");
          

        }

        private void bt_case_Click(object sender, EventArgs e)
        {

            string mes = (cb_mes.SelectedItem).ToString();

            switch(mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":  
                case "Julho":    
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    txt_result.Text = "31 dias";
                    break;

                case "Fevereiro":
                    txt_result.Text = "28 ou 29 dias";
                    break;

                default:
                    txt_result.Text = "30 dias";
                    break;

            }


        }

        private void bt_if_Click(object sender, EventArgs e)
        {
            string mes_if = cb_mes.SelectedItem.ToString();


            if (mes_if == "Janeiro" || mes_if == "Março"|| mes_if == "Maio" || mes_if == "Julho" || mes_if == "Agosto" || mes_if == "Outubro" || mes_if == "Dezembro")

            {

                txt_result.Text = "31 dias";
            }
            else if (mes_if == "Fevereiro")
            {
                txt_result.Text = "28 ou 29 dias";

            }
            else
            {
                txt_result.Text = "30 dias";


            }




        }
    }
}
