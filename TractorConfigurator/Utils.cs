using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TractorConfigurator
{
    class Utils
    {
        public static bool IsChecked(RadioButton rdo1, RadioButton rdo2)
        {
            if (rdo1.Checked == true || rdo2.Checked == true)
            {
                return true;
            }
            return false;
        }

        public static void ClearResult(Label lbl)
        {
            lbl.Text = "";
            lbl.Visible = false;
        }

        public static void ClearButtons(RadioButton rdoBtn)
        {
            rdoBtn.Checked = false;
        }

        public static void SetModels(List<Models> models)
        {
            Models model = new Models();
            models.Add(new Models { Name = "Universal 650", Price = 4000, HorsePower = 45 });
            models.Add(new Models { Name = "Case", Price = 50000, HorsePower = 450 });
            models.Add(new Models { Name = "John Deere", Price = 200000, HorsePower = 1200 });
    
        }

        public static void SetOptions(Options option1, Options option2)
        {
            option1.Delivery = "Delivery";
            option1.Price = 5000;
            option2.Delivery = "Pick Up";
            option2.Price = 2000;
        }

        public static void MessageAlert(string fieldName)
        {
            MessageBox.Show($"Mandatory field: {fieldName}");
        }

        public static void SumPrint(Label lblSumOptions, double sum)
        {
            lblSumOptions.Text = "Price: " + sum;//afisam prin Label
            lblSumOptions.Visible = true;
        }

         public static void DeliveryOptions(RadioButton rdo1, RadioButton rdo2, Options option1, Options option2)
        {
              rdo1.Text = option1.Delivery;
              rdo2.Text = option2.Delivery;
        }
      
    }
}
