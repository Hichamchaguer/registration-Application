using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP9_EX1_PE
{
    public partial class Form1 : Form
    {
         List<Stagiaire> L = new List<Stagiaire>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TNom.Text == "" || TPrenom.Text == "" || COption.Text == "" || NAge.Text == "" || (F.Checked == false && M.Checked == false))
                MessageBox.Show("Les champs sont vides !!! ", "Attention");
            else
            {
                string sexe="H";
                if (M.Checked)
                {
                    sexe = "M";
                }
                else if (F.Checked)
                {
                    sexe = "F";
                }
                Stagiaire s = new Stagiaire();

                s.Nom = TNom.Text;
                s.Prenom = TPrenom.Text;
                s.Sexe = sexe;
                s.Option = COption.Text;
                s.Age = int.Parse(NAge.Value.ToString());
                L.Add(s);
                dataGridView1.Rows.Add(s.Nom,s.Prenom,s.Sexe,s.Option,s.Age);
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            DialogResult reponse = MessageBox.Show("Vouler vous vraiment supprimer!", "Suppression", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    MessageBox.Show("Aucune ligne n'est slectionnée");
                else
                {
                   int pos = dataGridView1.SelectedRows[0].Index;
                   dataGridView1.Rows.RemoveAt(pos);
                   L.RemoveAt(pos);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Stagiaire s in L)
                if (s.Nom == TNom.Text)
                {
                    TPrenom.Text = s.Prenom;
                    COption.Text = s.Option;
                    NAge.Value = s.Age;
                    if (s.Sexe == "M")
                        M.Checked = true;
                    else if (s.Sexe == "F")
                        F.Checked = true;
                    break;
                }
        }

        private void buttonAjouter_MouseEnter(object sender, EventArgs e)
        {
            buttonAjouter.BackColor = Color.PaleGreen;
        }

        private void buttonAjouter_MouseLeave(object sender, EventArgs e)
        {
            buttonAjouter.BackColor = Color.Moccasin;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleGreen;
        }

        private void buttonSupprimer_MouseEnter(object sender, EventArgs e)
        {
            buttonSupprimer.BackColor = Color.PaleGreen;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.PaleGreen;
        }

        private void buttonSupprimer_MouseLeave(object sender, EventArgs e)
        {
            buttonSupprimer.BackColor = Color.Moccasin;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Moccasin;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string option = COption.SelectedItem.ToString();
            foreach (Stagiaire s in L)
                if (s.Option == option)
                {
                    dataGridView1.Rows.Add(s.Nom, s.Prenom, s.Sexe, s.Option, s.Age);
                }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Moccasin;
        }

        private void M_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
