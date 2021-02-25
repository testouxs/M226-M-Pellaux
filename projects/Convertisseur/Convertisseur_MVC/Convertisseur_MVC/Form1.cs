using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertisseur_MVC
{
    public partial class Form1 : Form
    {
        private CurEx_Controller _controller;
        private double _amount;
        private string _from;
        private string _to;

        public Form1()
        {
            InitializeComponent();
            _controller = new CurEx_Controller(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] table = _controller.GetAvailableCurrenciesInModel();
            cbxMonnaie.Items.Clear();
            cbxConverssion.Items.Clear();
            foreach (var value in table)
            {
                cbxMonnaie.Items.Add(value[0]);
                cbxConverssion.Items.Add(value[1]);
            }
        }

        private double Convert(double amount)
        {
            return _controller.Convert(amount);
        }

        private void UpdateView()
        {
            _amount = _controller.Convert(tbxMontant.Text);
            _from = cbxMonnaie.Text;
            _to = cbxConverssion.Text;
            tbxResultat.Text = _amount + " * " + Convert(_amount);
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
