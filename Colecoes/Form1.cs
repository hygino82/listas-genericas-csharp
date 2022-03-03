using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();//limpa a list box
            //array
            string[] nomes = { "Gorete", "Dilma", "Juca" };
            //lista genérica
            List<string> nomesList = new List<string>();

            nomesList.Add("Juvenal");
            nomesList.Add("Teodoro");
            nomesList.Add("Godofredo");

            nomesList.AddRange(nomes);

            /*if (nomesList.Remove("Teodoro"))
            {
                MessageBox.Show("Tedodoro removido");
            }
            else
            {
                MessageBox.Show("Não foi possível remover");
            }*/

            //if (nomesList.Contains("Godofredo"))
            //{
            //    MessageBox.Show("Godofredo está na lista");
            //}
            //else
            //{
            //    MessageBox.Show("Não encontrado");
            //}

            //MessageBox.Show("A lista tem: " + nomesList.Count + " elementos.");
            //nomesList.Sort();

            //MessageBox.Show("Gorete está no indice: " + nomesList.IndexOf("Gorete"));

            //nomesList.Insert(2, "Batista");

            //nomesList.RemoveAt(3);

            //nomesList.Clear();

            nomesList.Add("Gorete");

            foreach (string nome in nomesList)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            HashSet<string> carros = new HashSet<string>()
            {
                "Opala","Chevete","Pampa","Belina","147"
            };

            //if (carros.Add("147"))
            //{
            //    MessageBox.Show("Adicionado a lista");

            //}
            //else
            //{
            //    MessageBox.Show("Não foi adicionado a lista");

            //}

            //string c = "147";
            //if (carros.Contains(c))
            //{
            //    MessageBox.Show("Contém o veículo: " + c);
            //}
            //else
            //{
            //    MessageBox.Show("Não contém o veículo: " + c);

            //}

            //carros.Remove("Opala");

            foreach (string carro in carros)
            {
                lista.Items.Add(carro);
            }

            //MessageBox.Show(carros.ElementAt(2));
            MessageBox.Show(carros.Last());


        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 7,"Dilma" },{74,"Roberto"},{26,"Felipe" }
            };

            alunos.Add(1, "Gorete");
            alunos.Add(33, "Godofredo");

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno.Key + " -> " + aluno.Value);
            }

           
        }
    }
}
