namespace autoomg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auto Fabia = new Auto("a", 1);
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Fabia.Rozjezd();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fabia.Zastav((int)numericUpDown2.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = Fabia.VratUjeteKm().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = Fabia.CelkovaSpotreba().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = Fabia.CelkovaSpotreba().ToString();
            label7.Text = Fabia.VratUjeteKm().ToString();
            MessageBox.Show(Fabia.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {


            if (maskedTextBox1.Text != "" && (int)numericUpDown1.Value != 0 && (int)numericUpDown2.Value != 0)
            {

                button1.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button2.Enabled = true;
                button3.Visible = true;
                button3.Enabled = true;
                button4.Visible = true;
                button4.Enabled = true;
                button5.Visible = true;
                button5.Enabled = true;
                label5.Visible = true;
                label4.Visible = true;
                button6.Visible = false;
                button6.Enabled = false;

                maskedTextBox1.Enabled = false;
                numericUpDown1.Enabled = false;
                


                MessageBox.Show("Auto úspìšnì vytvoøeno!");
                    Fabia = new Auto(maskedTextBox1.Text, (int)numericUpDown1.Value);
                
            }
            else
            {
                MessageBox.Show("Auto nebylo vytvoøeno!\nZadej všechny hodnoty!");
            }
                    
            
            

            
        }
    }
}