
namespace TractorConfigurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.lblFinalSum = new System.Windows.Forms.Label();
            this.grpBoxOptiuni = new System.Windows.Forms.GroupBox();
            this.rdoBtn2 = new System.Windows.Forms.RadioButton();
            this.rdoBtn1 = new System.Windows.Forms.RadioButton();
            this.lblSumOptions = new System.Windows.Forms.Label();
            this.grpBoxOptiuni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(586, 362);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculeaza";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(694, 362);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 29);
            this.btnAnuleaza.TabIndex = 1;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 20;
            this.Lista.Location = new System.Drawing.Point(49, 48);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(560, 164);
            this.Lista.TabIndex = 2;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // lblFinalSum
            // 
            this.lblFinalSum.AutoSize = true;
            this.lblFinalSum.Location = new System.Drawing.Point(566, 231);
            this.lblFinalSum.Name = "lblFinalSum";
            this.lblFinalSum.Size = new System.Drawing.Size(87, 20);
            this.lblFinalSum.TabIndex = 3;
            this.lblFinalSum.Text = "Suma finala";
            this.lblFinalSum.Visible = false;
            // 
            // grpBoxOptiuni
            // 
            this.grpBoxOptiuni.Controls.Add(this.rdoBtn2);
            this.grpBoxOptiuni.Controls.Add(this.rdoBtn1);
            this.grpBoxOptiuni.Location = new System.Drawing.Point(49, 266);
            this.grpBoxOptiuni.Name = "grpBoxOptiuni";
            this.grpBoxOptiuni.Size = new System.Drawing.Size(250, 106);
            this.grpBoxOptiuni.TabIndex = 4;
            this.grpBoxOptiuni.TabStop = false;
            this.grpBoxOptiuni.Text = "Optiuni";
            this.grpBoxOptiuni.Enter += new System.EventHandler(this.grpBoxOptiuniLivrare_Enter);
            // 
            // rdoBtn2
            // 
            this.rdoBtn2.AutoSize = true;
            this.rdoBtn2.Location = new System.Drawing.Point(20, 77);
            this.rdoBtn2.Name = "rdoBtn2";
            this.rdoBtn2.Size = new System.Drawing.Size(84, 24);
            this.rdoBtn2.TabIndex = 1;
            this.rdoBtn2.TabStop = true;
            this.rdoBtn2.Text = "Option2";
            this.rdoBtn2.UseVisualStyleBackColor = true;
            this.rdoBtn2.CheckedChanged += new System.EventHandler(this.rdoBtn2_CheckedChanged);
            // 
            // rdoBtn1
            // 
            this.rdoBtn1.AutoSize = true;
            this.rdoBtn1.Location = new System.Drawing.Point(20, 26);
            this.rdoBtn1.Name = "rdoBtn1";
            this.rdoBtn1.Size = new System.Drawing.Size(84, 24);
            this.rdoBtn1.TabIndex = 0;
            this.rdoBtn1.TabStop = true;
            this.rdoBtn1.Text = "Option1";
            this.rdoBtn1.UseVisualStyleBackColor = true;
            this.rdoBtn1.CheckedChanged += new System.EventHandler(this.rdoBtn1_CheckedChanged);
            // 
            // lblSumOptions
            // 
            this.lblSumOptions.AutoSize = true;
            this.lblSumOptions.Location = new System.Drawing.Point(635, 60);
            this.lblSumOptions.Name = "lblSumOptions";
            this.lblSumOptions.Size = new System.Drawing.Size(116, 20);
            this.lblSumOptions.TabIndex = 5;
            this.lblSumOptions.Text = "Suma cu optiuni";
            this.lblSumOptions.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSumOptions);
            this.Controls.Add(this.grpBoxOptiuni);
            this.Controls.Add(this.lblFinalSum);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxOptiuni.ResumeLayout(false);
            this.grpBoxOptiuni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Label lblFinalSum;
        private System.Windows.Forms.GroupBox grpBoxOptiuni;
        private System.Windows.Forms.RadioButton rdoBtn2;
        private System.Windows.Forms.RadioButton rdoBtn1;
        private System.Windows.Forms.Label lblSumOptions;
    }
}

