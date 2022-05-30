using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void AfiseazaBTN_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-FEKFB5S\\SQLEXPRESS01;Initial Catalog=BioPrinz;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conn);
            DateTime today = DateTime.Now;
            string Fel1, Fel2, Desert1, Desert2, Desert3, Adresa;
            if (radioButton1.Checked) Fel1 = radioButton1.Text;
            else if (radioButton2.Checked) Fel1 = radioButton2.Text;
            else if (radioButton3.Checked) Fel1 = radioButton3.Text;
            else if (radioButton4.Checked) Fel1 = radioButton4.Text;
            else Fel1 = null;

            if (radioButton5.Checked) Fel2 = radioButton5.Text;
            else if (radioButton6.Checked) Fel2 = radioButton6.Text;
            else if (radioButton7.Checked) Fel2 = radioButton7.Text;
            else Fel2 = null;
            if (checkBox1.Checked) Desert1 = checkBox1.Text;
            else Desert1 = null;
            if (checkBox2.Checked) Desert2 = checkBox2.Text;
            else Desert2 = null;
            if (checkBox3.Checked) Desert3 = checkBox3.Text;
            else Desert3 = null;

            if (!String.IsNullOrEmpty(AdresaTXT.Text)) Adresa = AdresaTXT.Text;
            else Adresa = null;

            richTextBox1.Text = "Felul Intai: " + Fel1 + "\nFelul Doi: " + Fel2 + "\nDesert:" + Desert1 + ", " + Desert2 + ", " + Desert3;
            string query = "insert into Comanda (MainMenu, SecMenu, Desert1, Desert2, Desert3, DataComanda, Adresa) VALUES (" + "'" + Fel1 + "','" + Fel2 + "','" + Desert1 + "','" + Desert2 + "','" + Desert3 + "','" + today + "','" + Adresa + "'" + ");";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();


        }

        private void StergeBTN_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bioPrinzDataSet1.Comanda' table. You can move, or remove it, as needed.
            this.comandaTableAdapter1.Fill(this.bioPrinzDataSet1.Comanda);
            // TODO: This line of code loads data into the 'bioPrinzDataSet.Comanda' table. You can move, or remove it, as needed.
            this.comandaTableAdapter.Fill(this.bioPrinzDataSet.Comanda);

        }
    }
}
