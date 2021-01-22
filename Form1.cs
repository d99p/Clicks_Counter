using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Clicks_Counter
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public int counter;
        public int RandomHRValue()
        {
            Random random = new Random();
            int RandomNumber = random.Next(1, 20);
            counter = random.Next(1, 25);
            return RandomNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int randomInt = RandomHRValue();
            if (counter == randomInt)
            {
                label1.Text = $"Набрано балів: {counter.ToString()}";
                label2.Text = $"Потрібно набрати: {RandomHRValue().ToString()}";
                MessageBox.Show("Перемога!!! Ти хочеш отримати винагороду?");
                if (MessageBoxButtons.OK == MessageBoxButtons.OK)
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=jHWKtQHXVJg&ab_channel=AwwAnimals");
                    
                }
             counter = 0;
            }

            if (counter >= 21)
            {
                label1.Text = $"Набрано балів: {counter.ToString()}";
                label2.Text = $"Потрібно набрати: {RandomHRValue().ToString()}";
                MessageBox.Show("Ми програли, але це не кінець може спробуємо ще раз?)");
                counter = 0;
            }
            label1.Text = $"Набрано балів: {counter.ToString()}";
            label2.Text = $"Потрібно набрати: {RandomHRValue().ToString()}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@"Привіт, я створив маленьку гру.
Суть гри набрати відповідну кількість балів, з тою що випадає випадково!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
