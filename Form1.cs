using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04022025
{
    public partial class Form1 : Form
    {
        GPACalculator gPACalculator ;

        public Form1()
        {
            InitializeComponent();
            gPACalculator = new GPACalculator();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(this.tb_input_GPA.Text);
                gPACalculator.setGPA(input);
                UpdateUI();

                this.tb_GPAx.Text = gPACalculator.getGPAX().ToString("F2");
                this.tb_max.Text = gPACalculator.getMaxGPA().ToString("F2");
                this.tb_min.Text = gPACalculator.getMinGPA().ToString("F2");

                
                

                this.tb_input_GPA.Text = string.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show("WRONGGGG");
                this.tb_input_GPA.Text = string.Empty;
            }   

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.tb_input_GPA.Text = string.Empty;
            this.tb_GPAx.Text = string.Empty;
            this.tb_max.Text = string.Empty;
            this.tb_min.Text = string.Empty;
            UpdateUI();
        }
        private void UpdateUI()
        {
            this.tb_GPAx.Text = gPACalculator.getGPAX().ToString("F2");
            this.tb_max.Text = gPACalculator.getMaxGPA().ToString("F2");
            this.tb_min.Text = gPACalculator.getMinGPA().ToString("F2");
            this.tb_STD.Text = gPACalculator.getStudentCount().ToString();
        }



    }
}
