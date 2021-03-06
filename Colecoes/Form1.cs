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



            //MessageBox.Show("Quantidade de alunos: " + alunos.Count);

            //alunos.Remove(7);

            //int chave = 714;
            string valor = "Gorete";
            //if (alunos.ContainsKey(chave))
            //{
            //    MessageBox.Show("Existe");
            //}
            //else
            //{
            //    MessageBox.Show("Não existe");

            //}

            if (alunos.ContainsValue(valor))
            {
                MessageBox.Show("Existe");
            }
            else
            {
                MessageBox.Show("Não existe");

            }

            //MessageBox.Show("Primeiro: " + alunos.First().Key);

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno.Key + " -> " + aluno.Value);
            }


            //alunos.Clear();
            //alunos.ContainsKey(74);
            //alunos.ContainsValue("Gorete");
            //alunos.First();
            //alunos.Last();

        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 7,"Dilma" },
                {74,"Roberto"},
                {26,"Felipe" },
                { 51,"Juca"}
            };

            alunos.Add(1, "Gorete");
            alunos.Add(33, "Godofredo");


            //alunos.Remove(51);
            //alunos.RemoveAt(0);
            //MessageBox.Show("a lista tem: " + alunos.Count().ToString() + " elementos");

            int chave = 33;

            if (alunos.ContainsKey(chave))
            {
                string obj = "";
                foreach (KeyValuePair<int, string> aluno in alunos)
                {
                    if (aluno.Key == chave)
                    {
                        obj = aluno.Value;
                    }
                }
                MessageBox.Show("Contém a chave: " + chave + " e o aluno é " + obj);
            }
            else
            {
                MessageBox.Show("Não contém a chave: " + chave);
            }

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno);
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                { 7,"Dilma" },
                {74,"Roberto"},
                {26,"Felipe" },
                { 51,"Juca"}
            };

            alunos.Add(1, "Gorete");
            alunos.Add(33, "Godofredo");

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno);
            }
            MessageBox.Show(alunos.ElementAt(0).ToString());
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Dilma","Gorete","Jupira","Tonho"
            };

            if (!nomes.Add("Godofredo"))
            {
                MessageBox.Show("Não podes repetir o valor");
            }

            nomes.Remove("Dilma");
            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }
            //nomes.Reverse()
            //nomes.ElementAt(3)
            // MessageBox.Show(nomes.First());
            //mostra o primeiro elemento da lista
            MessageBox.Show(nomes.Count().ToString());
            //mostra o número de elementos da lista

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Dilma");
            fila.Enqueue("Gorete");
            fila.Enqueue("Jupira");

            //MessageBox.Show(fila.Count.ToString());

            foreach (string item in fila)
            {
                lista.Items.Add(item);
            }

            // MessageBox.Show("Primeiro da fila -> " + fila.Peek());
            // MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila -> " + fila.First());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("ùltimo da fila -> " + fila.Last());
            //MessageBox.Show(fila.Count.ToString());

            //fila.Clear();//limpa a fila 

            while (fila.Count > 0)
            {
                MessageBox.Show("Primeiro da fila -> " + fila.Dequeue());
                MessageBox.Show(fila.Count.ToString());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }
        }
    }
}
