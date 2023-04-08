using Entiteti;

namespace CGMV
{
    public partial class Form1 : Form
    {

        private const string PATH = "ListaPredavaca.txt";
        private const char DEL = '|';

        Osoba Admin = new()
        {
            Ime = "Pero",
            Prezime = "Peric",
            Email = "admin",
            Lozinka = "pwd",
            JeAdmin = true
        };
        Osoba Predavac_1 = new()
        {
            Ime = "Ana",
            Prezime = "Anic",
            Email = "pred1",
            Lozinka = "pred1",
            JeAdmin = false
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ProvjeraKredencijala();
        }

        private void TbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProvjeraKredencijala();
            }
        }

        private void TbLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProvjeraKredencijala();
            }
        }


        private void ProvjeraKredencijala()
        {

            // kreirat bolji foreach, dok je samo s jednom linijom u .txt radi, medutim 2 ili vise ne radi
            string[] lines = File.ReadAllLines(PATH);
            bool uspjeh = false;

            foreach (string line in lines)
            {
                string[] data = line.Split(DEL);
                if (data[2] == tbEmail.Text && data[3] == tbLozinka.Text)
                {
                    uspjeh = true;

                    this.Hide();
                    Predavac_Pocetna predavac = new();
                    predavac.Show();
                    predavac.BringToFront();
                }
            }

            if (tbEmail.Text == "admin" && tbLozinka.Text == "pwd")
            {
                uspjeh = true;

                this.Hide();
                Administrator_Pocetna adminPocetna = new();
                adminPocetna.Show();
                adminPocetna.BringToFront();
            }

            if (uspjeh == false)
            {
                MessageBox.Show("Neuspjeli pokušaj, pokušajte ponovno");
                ClearForm();
            }

        }

        private void ClearForm()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                    tbEmail.Focus();
                }
            }
        }

        
    }
}