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
            //array
            string[] nomes = { "Gorete", "Dilma", "Juca" };
            //lista genérica
            List<string> nomesList = new List<string>();
            
            nomesList.Add("Juvenal");
            nomesList.Add("Teodoro");
            nomesList.Add("Godofredo");

            nomesList.AddRange(nomes);

            foreach(string nome in nomesList)
            {
                lista.Items.Add(nome);
            }
        }
    }
}
