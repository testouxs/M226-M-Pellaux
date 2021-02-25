using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTamagotchi
{
    public partial class frm1 : Form
    {
        Random rnd = new Random();
        Tamagotchi normal = null;
        Tamagotchi steve = null;
        Tamagotchi gabi = null;
        Tamagotchi orion = null;
        Tamagotchi valaha = null;
        int index = 0;

        Tamagotchi[] tamagotchiTable ={};

        public frm1()
        {
            InitializeComponent();
            tbxDead.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int random = rnd.Next(0, 3);
            Tamagotchi[] typeTable = 
            {
                new Tamagotchi(""),
                new Monstre(""),
                new Mignon("")
            };

            Tamagotchi[] tamagotchiTable = 
            {
                normal = new Tamagotchi("normal"),
                steve = new Tamagotchi("steve"),
                gabi = new Tamagotchi("gabi"),
                orion = new Tamagotchi("orion"),
                valaha = new Tamagotchi("valaha")
            };

            btnTamagotchi1.Text = tamagotchiTable[0].Nom;
            btnTamagotchi1.Text = tamagotchiTable[1].Nom;
            btnTamagotchi1.Text = tamagotchiTable[2].Nom;
            btnTamagotchi1.Text = tamagotchiTable[3].Nom;

            switch (random)
            {
                case 0:
                    tamagotchiTable[index] = new Monstre("Michael Myers");
                    lblTest.Text = "Monstre";
                    lblMechant.Text = "Mechant";
                    btnPunir.Visible = true;
                    btnPunir.Enabled = true;
                    btnCalinou.Visible = false;
                    btnCalinou.Enabled = false;
                    break;
                case 1:
                    tamagotchiTable[index] = new Tamagotchi("Michael Myers");
                    lblTest.Text = "Tamagotchi";
                    break;
                case 2:
                    tamagotchiTable[index] = new Mignon("Michael Myers");
                    lblTest.Text = "Mignon";
                    lblMechant.Text = "Gentil";
                    btnCalinou.Visible = true;
                    btnCalinou.Enabled = true;
                    btnPunir.Visible = false;
                    btnPunir.Enabled = false;
                    break;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            tamagotchiTable[index].Vivre();
            UpdateView();
        }

        private void UpdateView()
        {
            if (tamagotchiTable[index].Vivant == false)
            {
                tbxDead.Text = tamagotchiTable[index].Nom + " KILLED YOU";
                tbxDead.Visible = true;
            }
            else
            {
                if (tamagotchiTable[index] is Monstre)
                {
                    pgrbMechant.Value = (tamagotchiTable[index] as Monstre).Mechant;
                    pgrbMechant.Visible = true;
                    lblMechant.Visible = true;
                    btnPunir.Visible = true;
                    btnPunir.Enabled = true;
                }
                else if (tamagotchiTable[index] is Mignon)
                {
                    pgrbMechant.Value = (tamagotchiTable[index] as Mignon).Gentil;
                    pgrbMechant.Visible = true;
                    lblMechant.Visible = true;
                    btnCalinou.Visible = true;
                    btnCalinou.Enabled = true;
                }
                else // Tamagotchi
                { 
                    pgrbMechant.Visible = false;
                    lblMechant.Visible = false;
                    btnPunir.Visible = false;
                    btnPunir.Enabled = false;
                    btnCalinou.Visible = false;
                    btnCalinou.Enabled = false;
                }
                lblName.Text = tamagotchiTable[index].Nom;
                lblEtat.Text = tamagotchiTable[index].Vivre();
                pgrbCalorie.Value = tamagotchiTable[index].Calorie;
                pgrbLiquide.Value = tamagotchiTable[index].Liquide;
                pgrbVirus.Value = tamagotchiTable[index].Virus;
                pgrbFatigue.Value = tamagotchiTable[index].Fatigue;
            }
        }

        private void btnManger_Click(object sender, EventArgs e)
        {
            tamagotchiTable[index].Manger();
            UpdateView();
        }

        private void btnBoire_Click(object sender, EventArgs e)
        {
            tamagotchiTable[index].Boire();
            UpdateView();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            tamagotchiTable[index].Dormir();
            UpdateView();
        }
        private void btnSoigner_Click(object sender, EventArgs e)
        {
            tamagotchiTable[index].Soigner();
            UpdateView();
        }

        private void tbxFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPunir_Click(object sender, EventArgs e)
        {
            (tamagotchiTable[index] as Monstre).Punir();
            UpdateView();
        }

        private void btnCalinou_Click(object sender, EventArgs e)
        {
            (tamagotchiTable[index] as Mignon).Calinou();
            UpdateView();
        }

        private void btnTamagotchi1_Click(object sender, EventArgs e)
        {
            index = 0;
            UpdateView();
        }

        private void btnTamagotchi2_Click(object sender, EventArgs e)
        {
            index = 1;
            UpdateView();
        }

        private void btnTamagotchi3_Click(object sender, EventArgs e)
        {
            index = 2;
            UpdateView();
        }

        private void btnTamagotchi4_Click(object sender, EventArgs e)
        {
            index = 3;
            UpdateView();
        }
    }
}
