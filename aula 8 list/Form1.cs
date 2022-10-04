using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_8_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            
            List<int> lista = new List<int>() { 10, -1 };
            string texto = null;

            lista.Add(202); // addc elementos no List
            lista.Add(301);


            lista.Insert(2, 54); // addc o elemento na posição declarada
            lista.Sort(); //Ordena os elementos em ordem crescente
            lista.Reverse(); // Ordena os elementos do Maior para o Menor

            for (int i = 0; i < lista.Count; i++)
            {
                texto += lista[i].ToString()+ "\n";
            }
            MessageBox.Show(texto);

            lista.Remove(202); // Remove o elemento
            texto = null;
            lista.RemoveAt(0); //Remove o elemento na posição do List

            for (int i = 0; i < lista.Count; i++)
            {
                texto += lista[i].ToString() + "\n";
            }
            MessageBox.Show(texto); */
        }

        List<Test> listpet = new List<Test>();
 

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int op = 0;
            for (int i=0; i<listpet.Count; i++)
            {
                if (txtPet.Text.Equals(listpet[i].Animal))
                {
                    txtDono.Text = listpet[i].Dono;
                    txtIdade.Text = listpet[i].Idade.ToString();
                    cbxEspecie.Text = listpet[i].Especie;
                    op = 1;
                        break;
                }
               
            }
            if (op == 0)
            {
                MessageBox.Show("Pet não encontrado");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listpet.Count; i++)
            {
                if (txtPet.Text.Equals(listpet[i].Animal))
                {
                    listpet.RemoveAt(i);
                    Limpar();
                    MessageBox.Show("cadastro excluido");
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Test animal = new Test();
            animal.Animal = txtPet.Text;
            animal.Idade = Convert.ToInt32(txtIdade.Text);
            animal.Especie = cbxEspecie.Text;
            animal.Dono = txtDono.Text;
            listpet.Add(animal);
            Limpar();
        }
        private void Limpar()
        {
            txtPet.Text = null;
            txtDono.Text = null;
            txtIdade.Text = null;
            cbxEspecie.SelectedIndex = -1;

        }
    }
}
