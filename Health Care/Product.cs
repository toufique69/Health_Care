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

namespace Health_Care
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MyConnection2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=StudentDB;Integrated Security=True;Pooling=False");
                MyConnection2.Open();

                SqlCommand Query = new SqlCommand("insert into ProductInfo (RecordNo,TradeName,GenericName,Category,Company,BatchNo,EntryDate,MfgDate,ExpDate,Quantity,Price) values('" + this.RecordtextBox.Text + "','" + this.TradetextBox.Text + "','" + this.GenerictextBox.Text + "','" + this.CategorycomboBox.Text + "','" + this.CompanytextBox.Text + "','" + this.BatchtextBox.Text + "','" + this.EntrytextBox.Text + "','" + this.MfgtextBox.Text + "','" + this.ExptextBox.Text + "','" + this.QuantitytextBox.Text + "','" + this.PricetextBox.Text + "')", MyConnection2);
                
                Query.ExecuteNonQuery();
                MessageBox.Show("Save Successfully !!");
                MyConnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EntrytextBox_TextChanged(object sender, EventArgs e)
        {
            EntrytextBox.Text = DateTime.Today.ToString("d");
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            string MyConnection2 = @"Data Source=(LocalDB)\v11.0;Initial Catalog=StudentDB;Integrated Security=True;Pooling=False";

            using (SqlConnection con = new SqlConnection(MyConnection2))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductInfo", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            ProductGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MyConnection2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=StudentDB;Integrated Security=True;Pooling=False");
                MyConnection2.Open();

                SqlCommand Query = new SqlCommand(@"update ProductInfo set RecordNo='" + this.RecordtextBox.Text + "', TradeName='" + this.TradetextBox.Text + "',GenericName='" + this.GenerictextBox.Text + "',Category='" + this.CategorycomboBox.Text + "',Company='" + this.CompanytextBox.Text + "',BatchNo='" + this.BatchtextBox.Text + "',EntryDate='" + this.EntrytextBox.Text + "',MfgDate='" + this.MfgtextBox.Text + "',ExpDate='" + this.ExptextBox.Text + "',Quantity='" + this.QuantitytextBox.Text + "',Price='" + this.PricetextBox.Text + "' where (RecordNo='" + this.RecordtextBox.Text + "')", MyConnection2);

                Query.ExecuteNonQuery();
                MessageBox.Show("Update successfully !!");
                MyConnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            RecordtextBox.Text = "";
            TradetextBox.Text = "";
            GenerictextBox.Text = "";
            CategorycomboBox.Text = "";
            CompanytextBox.Text = "";
            BatchtextBox.Text = "";
            EntrytextBox.Text = "";
            MfgtextBox.Text = "";
            ExptextBox.Text = "";
            QuantitytextBox.Text = "";
            PricetextBox.Text = "";
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MyConnection2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=StudentDB;Integrated Security=True;Pooling=False");
                MyConnection2.Open();

                SqlCommand Query = new SqlCommand(@"Delete from ProductInfo where (RecordNo='" + this.RecordtextBox.Text + "')", MyConnection2);

                Query.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully !!!");
                MyConnection2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
