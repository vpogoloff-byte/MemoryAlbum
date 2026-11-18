namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panelMenu.BringToFront();
            panelMenu.Visible = true;

        }

        private void MonthButton_Click(object sender, EventArgs e)
        {

            string buttonName = ((Button)sender).Name;

            if (sender is Button clickedButton)

            {
                switch (buttonName)
                {
                    case "button1":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;

                            break;
                        }
                    case "button2":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button3":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button4":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button5":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button6":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button7":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button8":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button9":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button10":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button11":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                    case "button12":
                        {
                            panelMenu.Visible = false;
                            panelContent.Visible = true;
                            break;
                        }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContent.Visible = false;
            panelMenu.Visible = true;
        }
    }
}
