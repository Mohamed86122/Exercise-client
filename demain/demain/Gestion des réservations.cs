using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demain
{
    public partial class Gestion_des_réservations : Form
    {
        public SqlConnection Connection = new SqlConnection(@"data source =DESKTOP-CB87R1M\SQLEXPRESS; Initial catalog=GTR;" + "Integrated security= true;");
        public Gestion_des_réservations()
        {
            InitializeComponent();
        }
        public void vider()
        {
            txt_code.Clear();
            cb_c.Items.Clear();
            txt_pEN.Clear();
            
        }

        private void Gestion_des_réservations_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("Select * from Client");
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sql = cmd.ExecuteReader();
                while (sql.Read())
                {
                    cb_c.Items.Add(sql[0].ToString());

                }
                Connection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btn_aj_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("Insert into Réservation values({0},{1},'{2}','{3}')",txt_code.Text,cb_c.SelectedItem,dateTimer.Value,txt_pEN.Text);
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("ajout réussi !!!!");
                vider();
                Connection.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void cb_c_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("select * from Client");

            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sql = cmd.ExecuteReader();
                while (sql.Read())
                {
                    if (cb_c.Text == sql[0].ToString())
                    {
                        lb_Nom.Text = sql[1].ToString();
                        lb_tel.Text = sql[3].ToString();
                    }
                }
                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);

            }

        }

        private void btn_aff_Click(object sender, EventArgs e)
        {
           
        }
    }
}
