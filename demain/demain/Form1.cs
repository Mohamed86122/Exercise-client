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
    public partial class Form1 : Form
    {
         public SqlConnection Connection =new SqlConnection(@"data source =DESKTOP-CB87R1M\SQLEXPRESS; Initial catalog=GTR;"+"Integrated security= true;");
        public Form1()
        {
            InitializeComponent();
        }
        public void vider ()
        {
            txt_Id.Clear();
            txt_Nom.Clear();
            txt_adresse.Clear();
            txt_tel.Clear();
        }
        
            
        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("Insert into Client values({0},'{1}','{2}','{3}')", txt_Id.Text, txt_Nom.Text, txt_adresse.Text, txt_tel.Text);
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout réussie");
                vider();
                Connection.Close();


            }
            catch(SqlException ex)
            {
                MessageBox.Show("ERROR"+ex.Message);
            }
            
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("select * from Client ");

            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sql = cmd.ExecuteReader();

                sql.Read();

                txt_Id.Text = sql[0].ToString();
                txt_Nom.Text = sql[1].ToString();
                txt_adresse.Text = sql[2].ToString();
                txt_tel.Text = sql[3].ToString();

                Connection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("select * from Client ");

            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sql = cmd.ExecuteReader();

                while(sql.Read())
                {
                txt_Id.Text = sql[0].ToString();
                txt_Nom.Text = sql[1].ToString();
                txt_adresse.Text = sql[2].ToString();
                txt_tel.Text = sql[3].ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand();
            sql.Connection = Connection;
            sql.CommandText = string.Format("Delete from Client where IdClient =" +txt_Id.Text);
            try
            {
                Connection.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Suppression réussite!!!!!!!!");
                Connection.Close();

            }
            catch(SqlException ex )
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand();
            sql.Connection = Connection;
            sql.CommandText = string.Format("Update Client set NomClient = '" + txt_Nom.Text+ "', AdresseClient = '" + txt_adresse.Text+ "', TelClient = '"+txt_tel.Text +"' where IdClient = " +txt_Id.Text);
            try
            {
                Connection.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Modification réussite!!!!!!!!");
                Connection.Close();



            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool tr = false;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = string.Format("select * from Client ");

            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader= cmd.ExecuteReader();                
                while(reader.Read())
                {
                    if(reader[0].ToString()==txt_Id.Text)
                    {
                        txt_Id.Text = reader[0].ToString();
                        txt_Nom.Text = reader[1].ToString();
                        txt_adresse.Text = reader[2].ToString();
                        txt_tel.Text = reader[3].ToString();
                        tr = true;
                    }
                    
                }
                if(tr==false)
                {
                    MessageBox.Show("Client Introuvable !!!!!!!!");
                }
                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
    }
}
