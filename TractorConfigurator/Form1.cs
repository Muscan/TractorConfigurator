using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TractorConfigurator.Utils;

namespace TractorConfigurator
{
    public partial class Form1 : Form
    {
        private List<Models> models = new List<Models>();
        private Options option1 = new Options();
        private Options option2 = new Options();
        private double sum = 0;
        public Form1()
        {
            InitializeComponent();
            lblSumOptions.Visible = false;
            SetModels(models);
            SetOptions(option1, option2);
            Lista.DataSource    = models;
            Lista.DisplayMember = "FinalPrintMessageFormat";
            Lista.ValueMember   = "FinalPrintMessageFormat";
        }

        private void grpBoxOptiuniLivrare_Enter(object sender, EventArgs e)
        {
            //double sumOptions =0 ;
            rdoBtn1.Text = option1.Delivery;
            rdoBtn2.Text = option2.Delivery;
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            ClearButtons(rdoBtn1);
            ClearButtons(rdoBtn2);
            ClearResult(lblFinalSum);
            ClearResult(lblSumOptions);
            
        }

        private void rdoBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn1.Checked == true)
                sum += option1.Price;
            else
                sum -= option1.Price;
            SumPrint(lblSumOptions, sum);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(IsChecked(rdoBtn1, rdoBtn2) == false)
            {
                MessageAlert(grpBoxOptiuni.Text);
            }

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models selectedModel = (Models)Lista.SelectedItem;//se declara un obiect de tipul Models in care se pastreaza itemul selectat din list
            sum += selectedModel.Price;//adunam la variabila sum pretul obiectului selecatat din lista
            lblSumOptions.Text += "Price: " + sum;//afisam prin Label
            lblSumOptions.Visible = true;
        }

        private void rdoBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn2.Checked == true)
                sum += option2.Price;
            else
                sum -= option2.Price;
            SumPrint(lblSumOptions, sum);
        }
    }
}
