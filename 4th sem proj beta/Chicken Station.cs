﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace _4th_sem_proj_beta
{
    public partial class Chicken_Station : Form
    {
        private bool isCheckboxChecked = false;
        private bool isCheckboxChecked1 = false;
        private bool isCheckboxChecked2 = false;


        private bool isCheckboxChecked3 = false;
        private bool isCheckboxChecked4 = false;
        private bool isCheckboxChecked5 = false;

        private bool isCheckboxChecked6 = false;
        private bool isCheckboxChecked7 = false;
        private bool isCheckboxChecked8 = false;

        private bool isCheckboxChecked9 = false;
        private bool isCheckboxChecked10 = false;
        private bool isCheckboxChecked11 = false;

        private bool isCheckboxChecked12 = false;
        private bool isCheckboxChecked13 = false;
        private bool isCheckboxChecked14 = false;

        private bool isCheckboxChecked15 = false;
        private bool isCheckboxChecked16 = false;
        private bool isCheckboxChecked17 = false;

        private bool isCheckboxChecked18 = false;
        private bool isCheckboxChecked19 = false;
        private bool isCheckboxChecked20 = false;

        private bool isCheckboxChecked21 = false;

        private bool isCheckboxChecked22 = false;
        private bool isCheckboxChecked23 = false;
        private bool isCheckboxChecked24 = false;

        private bool isCheckboxChecked25 = false;
        private bool isCheckboxChecked26 = false;
        private bool isCheckboxChecked27 = false;

        private int currentValue = 0;
        private int currentValue1 = 0;
        private int currentValue2 = 0;
        private int currentValue3 = 0;
        private int currentValue4 = 0;
        private int currentValue5 = 0;
        private int currentValue6 = 0;
        private int currentValue7 = 0;
        private int currentValue8 = 0;
        private int currentValue9 = 0;
        private int currentValue10 = 0;
        private int currentValue11 = 0;
        private int currentValue12 = 0;
        private int currentValue13 = 0;
        private int currentValue14 = 0;
        private int currentValue15 = 0;
        private int currentValue16 = 0;
        private int currentValue17 = 0;
        private int currentValue18 = 0;
        private int currentValue19 = 0;
        private int currentValue20 = 0;
        private int currentValue21 = 0;
        private int currentValue22 = 0;
        private int currentValue23 = 0;
        private int currentValue24 = 0;
        private int currentValue25 = 0;
        private int currentValue26 = 0;
        private int currentValue27 = 0;

        private string connectionString = "server=localhost;user=root;database=sastomasto;port=3306;password=@Mysqlserver;";
        private List<CartItem> cartItems = new List<CartItem>();
        public Chicken_Station()
        {
            InitializeComponent();
        }
        public class CartItem
        {
            public string F_Name { get; set; }
            public int Quantity { get; set; }
            public decimal F_Price { get; set; }

            public decimal Total => Quantity * F_Price;
        }


        private void AddToCart(string itemId, string itemName, int quantity)
        {
            try
            {
                decimal price = GetItemPriceFromDatabase(itemId); // Assuming GetItemPriceFromDatabase accepts itemId
                var existingItem = cartItems.FirstOrDefault(x => x.F_Name == itemName);

                if (existingItem != null)
                {
                    existingItem.Quantity = quantity;
                }
                else
                {
                    cartItems.Add(new CartItem { F_Name = itemName, Quantity = quantity, F_Price = price });
                }

                UpdateCartDisplay();
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item to cart: {ex.Message}");
            }
        }

        private decimal GetItemPriceFromDatabase(string itemName)
        {
            decimal price = 0;
            string query = $"SELECT F_Price FROM menu WHERE F_ID=@F_ID"; // Modified the query

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@F_ID", itemName); // Modified this line
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching item price from database: {ex.Message}");
            }

            return price;
        }

        private string GetItemNameFromDatabase(string itemName1)
        {
            string itemNameFromDatabase = ""; // Initialize the variable to store the item name

            string query = $"SELECT F_Name FROM menu WHERE F_ID=@F_ID"; // Query to select item name

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@F_ID", itemName1);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        itemNameFromDatabase = result.ToString(); // Assign the item name from the database to the variable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching item name from database: {ex.Message}");
            }

            return itemNameFromDatabase;
        }


        private void UpdateCartDisplay()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cartItems;
            dataGridViewCart.Invalidate();
            dataGridViewCart.Refresh();
            dataGridViewCart.Update();

        }

        private void UpdateTotalAmount()
        {
            decimal total = cartItems.Sum(x => x.Total);
            TP.Text = $"Total: Rs{total:F2}";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main ok = new Main();
            ok.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblabout_Click(object sender, EventArgs e)
        {
            Aboutus ok = new Aboutus();
            ok.Show();
            this.Hide();
        }

        private void lblareas_Click(object sender, EventArgs e)
        {
            AvailableAreas ok = new AvailableAreas();
            ok.Show();
            this.Hide();
        }

        private void label75_Click(object sender, EventArgs e)
        {
            HowToOrder ok = new HowToOrder();
            ok.Show();
            this.Hide();
        }

        private void label74_Click(object sender, EventArgs e)
        {
            Fqs ok = new Fqs();
            ok.Show();
            this.Hide();
        }

        private void label73_Click(object sender, EventArgs e)
        {
            ContactUs ok = new ContactUs();
            ok.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox1.Checked;
            button1.Enabled = button2.Enabled = button3.Enabled = isCheckboxChecked;
        }
        private void updatetextbox()
        {
            textBox1.Text = currentValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue--;
                if (currentValue < 0)
                {
                    currentValue = 0;
                }
                updatetextbox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue++;
                if (currentValue >= 10)
                {
                    currentValue = 10;
                }
                updatetextbox();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked1 = checkBox2.Checked;
            button4.Enabled = button5.Enabled = button6.Enabled = isCheckboxChecked1;
        }
        private void updatetextbox1()
        {
            textBox2.Text = currentValue1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked1)
            {
                currentValue1--;
                if (currentValue1 < 0)
                {
                    currentValue1 = 0;
                }
                updatetextbox1();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked1)
            {
                currentValue1++;
                if (currentValue1 >= 10)
                {
                    currentValue1 = 10;
                }
                updatetextbox1();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked2 = checkBox3.Checked;
            button7.Enabled = button8.Enabled = button9.Enabled = isCheckboxChecked2;
        }
        private void updatetextbox2()
        {
            textBox3.Text = currentValue2.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked2)
            {
                currentValue2--;
                if (currentValue2 < 0)
                {
                    currentValue2 = 0;
                }
                updatetextbox2();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked2)
            {
                currentValue2++;
                if (currentValue2 >= 10)
                {
                    currentValue2 = 10;
                }
                updatetextbox2();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked3 = checkBox4.Checked;
            button10.Enabled = button11.Enabled = button12.Enabled = isCheckboxChecked3;
        }
        private void updatetextbox3()
        {
            textBox4.Text = currentValue3.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked8)
            {
                currentValue8--;
                if (currentValue8 < 0)
                {
                    currentValue8 = 0;
                }
                updatetextbox8();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked3)
            {
                currentValue3--;
                if (currentValue3 < 0)
                {
                    currentValue3 = 0;
                }
                updatetextbox3();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked3)
            {
                currentValue3++;
                if (currentValue3 >= 10)
                {
                    currentValue3 = 10;
                }
                updatetextbox3();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked4 = checkBox5.Checked;
            button13.Enabled = button14.Enabled = button15.Enabled = isCheckboxChecked4;
        }
        private void updatetextbox4()
        {
            textBox5.Text = currentValue4.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked4)
            {
                currentValue4--;
                if (currentValue4 < 0)
                {
                    currentValue4 = 0;
                }
                updatetextbox4();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked4)
            {
                currentValue4++;
                if (currentValue4 >= 10)
                {
                    currentValue4 = 10;
                }
                updatetextbox4();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked5 = checkBox6.Checked;
            button16.Enabled = button17.Enabled = button18.Enabled = isCheckboxChecked5;
        }
        private void updatetextbox5()
        {
            textBox6.Text = currentValue5.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked5)
            {
                currentValue5--;
                if (currentValue5 < 0)
                {
                    currentValue5 = 0;
                }
                updatetextbox5();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked5)
            {
                currentValue5++;
                if (currentValue5 >= 10)
                {
                    currentValue5 = 10;
                }
                updatetextbox5();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked6 = checkBox7.Checked;
            button19.Enabled = button20.Enabled = button21.Enabled = isCheckboxChecked6;
        }
        private void updatetextbox6()
        {
            textBox7.Text = currentValue6.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked6)
            {
                currentValue6--;
                if (currentValue6 < 0)
                {
                    currentValue6 = 0;
                }
                updatetextbox6();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked6)
            {
                currentValue6++;
                if (currentValue6 >= 10)
                {
                    currentValue6 = 10;
                }
                updatetextbox6();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked7 = checkBox9.Checked;
            button25.Enabled = button26.Enabled = button27.Enabled = isCheckboxChecked7;
        }
        private void updatetextbox7()
        {
            textBox9.Text = currentValue7.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked7)
            {
                currentValue7--;
                if (currentValue7 < 0)
                {
                    currentValue7 = 0;
                }
                updatetextbox7();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked7)
            {
                currentValue7++;
                if (currentValue7 >= 10)
                {
                    currentValue7 = 10;
                }
                updatetextbox7();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked8 = checkBox8.Checked;
            button22.Enabled = button23.Enabled = button24.Enabled = isCheckboxChecked8;
        }
        private void updatetextbox8()
        {
            textBox8.Text = currentValue8.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked8)
            {
                currentValue8++;
                if (currentValue8 >= 10)
                {
                    currentValue8 = 10;
                }
                updatetextbox8();
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked9 = checkBox10.Checked;
            button28.Enabled = button29.Enabled = button30.Enabled = isCheckboxChecked9;
        }
        private void updatetextbox9()
        {
            textBox10.Text = currentValue9.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked9)
            {
                currentValue9--;
                if (currentValue9 < 0)
                {
                    currentValue9 = 0;
                }
                updatetextbox9();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked9)
            {
                currentValue9++;
                if (currentValue9 >= 10)
                {
                    currentValue9 = 10;
                }
                updatetextbox9();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked10 = checkBox11.Checked;
            button31.Enabled = button32.Enabled = button33.Enabled = isCheckboxChecked10;
        }
        private void updatetextbox10()
        {
            textBox11.Text = currentValue10.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked10)
            {
                currentValue10--;
                if (currentValue10 < 0)
                {
                    currentValue10 = 0;
                }
                updatetextbox10();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked10)
            {
                currentValue10++;
                if (currentValue10 >= 10)
                {
                    currentValue10 = 10;
                }
                updatetextbox10();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked11 = checkBox12.Checked;
            button34.Enabled = button35.Enabled = button36.Enabled = isCheckboxChecked11;
        }
        private void updatetextbox11()
        {
            textBox12.Text = currentValue11.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked11)
            {
                currentValue11--;
                if (currentValue11 < 0)
                {
                    currentValue11 = 0;
                }
                updatetextbox11();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked11)
            {
                currentValue11++;
                if (currentValue11 >= 10)
                {
                    currentValue11 = 10;
                }
                updatetextbox11();
            }
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked12 = checkBox16.Checked;
            button46.Enabled = button47.Enabled = button48.Enabled = isCheckboxChecked12;
        }
        private void updatetextbox12()
        {
            textBox16.Text = currentValue12.ToString();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked12)
            {
                currentValue12--;
                if (currentValue12 < 0)
                {
                    currentValue12 = 0;
                }
                updatetextbox12();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked12)
            {
                currentValue12++;
                if (currentValue12 >= 10)
                {
                    currentValue12 = 10;
                }
                updatetextbox12();
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked13 = checkBox17.Checked;
            button49.Enabled = button50.Enabled = button51.Enabled = isCheckboxChecked13;
        }
        private void updatetextbox13()
        {
            textBox17.Text = currentValue13.ToString();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked13)
            {
                currentValue13--;
                if (currentValue13 < 0)
                {
                    currentValue13 = 0;
                }
                updatetextbox13();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked13)
            {
                currentValue13++;
                if (currentValue13 >= 10)
                {
                    currentValue13 = 10;
                }
                updatetextbox13();
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked14 = checkBox18.Checked;
            button52.Enabled = button53.Enabled = button54.Enabled = isCheckboxChecked14;
        }
        private void updatetextbox14()
        {
            textBox18.Text = currentValue14.ToString();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked14)
            {
                currentValue14--;
                if (currentValue14 < 0)
                {
                    currentValue14 = 0;
                }
                updatetextbox14();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked14)
            {
                currentValue14++;
                if (currentValue14 >= 10)
                {
                    currentValue14 = 10;
                }
                updatetextbox14();
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked15 = checkBox27.Checked;
            button79.Enabled = button80.Enabled = button81.Enabled = isCheckboxChecked15;
        }
        private void updatetextbox15()
        {
            textBox27.Text = currentValue15.ToString();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked15)
            {
                currentValue15--;
                if (currentValue15 < 0)
                {
                    currentValue15 = 0;
                }
                updatetextbox15();
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked15)
            {
                currentValue15++;
                if (currentValue15 >= 10)
                {
                    currentValue15 = 10;
                }
                updatetextbox15();
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked16 = checkBox26.Checked;
            button76.Enabled = button77.Enabled = button78.Enabled = isCheckboxChecked16;
        }
        private void updatetextbox16()
        {
            textBox26.Text = currentValue16.ToString();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked16)
            {
                currentValue16--;
                if (currentValue16 < 0)
                {
                    currentValue16 = 0;
                }
                updatetextbox16();
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked16)
            {
                currentValue16++;
                if (currentValue16 >= 10)
                {
                    currentValue16 = 10;
                }
                updatetextbox16();
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked17 = checkBox25.Checked;
            button73.Enabled = button74.Enabled = button75.Enabled = isCheckboxChecked17;
        }
        private void updatetextbox17()
        {
            textBox25.Text = currentValue17.ToString();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked17)
            {
                currentValue17--;
                if (currentValue17 < 0)
                {
                    currentValue17 = 0;
                }
                updatetextbox17();
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked17)
            {
                currentValue17++;
                if (currentValue17 >= 10)
                {
                    currentValue17 = 10;
                }
                updatetextbox17();
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked18 = checkBox21.Checked;
            button61.Enabled = button62.Enabled = button63.Enabled = isCheckboxChecked18;
        }
        private void updatetextbox18()
        {
            textBox21.Text = currentValue18.ToString();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked18)
            {
                currentValue18--;
                if (currentValue18 < 0)
                {
                    currentValue18 = 0;
                }
                updatetextbox18();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked18)
            {
                currentValue18++;
                if (currentValue18 >= 10)
                {
                    currentValue18 = 10;
                }
                updatetextbox18();
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked19 = checkBox20.Checked;
            button58.Enabled = button59.Enabled = button60.Enabled = isCheckboxChecked19;
        }
        private void updatetextbox19()
        {
            textBox20.Text = currentValue19.ToString();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked19)
            {
                currentValue19--;
                if (currentValue19 < 0)
                {
                    currentValue19 = 0;
                }
                updatetextbox19();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked19)
            {
                currentValue19++;
                if (currentValue19 >= 10)
                {
                    currentValue19 = 10;
                }
                updatetextbox19();
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked20 = checkBox19.Checked;
            button55.Enabled = button56.Enabled = button57.Enabled = isCheckboxChecked20;
        }
        private void updatetextbox20()
        {
            textBox19.Text = currentValue20.ToString();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked20)
            {
                currentValue20--;
                if (currentValue20 < 0)
                {
                    currentValue20 = 0;
                }
                updatetextbox20();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked20)
            {
                currentValue20++;
                if (currentValue20 >= 10)
                {
                    currentValue20 = 10;
                }
                updatetextbox20();
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked21 = checkBox15.Checked;
            button43.Enabled = button44.Enabled = button45.Enabled = isCheckboxChecked21;
        }
        private void updatetextbox21()
        {
            textBox15.Text = currentValue21.ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked21)
            {
                currentValue21--;
                if (currentValue21 < 0)
                {
                    currentValue21 = 0;
                }
                updatetextbox21();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked21)
            {
                currentValue21++;
                if (currentValue21 >= 10)
                {
                    currentValue21 = 10;
                }
                updatetextbox21();
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked22 = checkBox14.Checked;
            button40.Enabled = button41.Enabled = button42.Enabled = isCheckboxChecked22;
        }
        private void updatetextbox22()
        {
            textBox14.Text = currentValue22.ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked22)
            {
                currentValue22--;
                if (currentValue22 < 0)
                {
                    currentValue22 = 0;
                }
                updatetextbox22();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked22)
            {
                currentValue22++;
                if (currentValue22 >= 10)
                {
                    currentValue22 = 10;
                }
                updatetextbox22();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked23 = checkBox13.Checked;
            button37.Enabled = button38.Enabled = button39.Enabled = isCheckboxChecked23;
        }
        private void updatetextbox23()
        {
            textBox13.Text = currentValue23.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked23)
            {
                currentValue23--;
                if (currentValue23 < 0)
                {
                    currentValue23 = 0;
                }
                updatetextbox23();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked23)
            {
                currentValue23++;
                if (currentValue23 >= 10)
                {
                    currentValue23 = 10;
                }
                updatetextbox23();
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked24 = checkBox24.Checked;
            button70.Enabled = button71.Enabled = button72.Enabled = isCheckboxChecked24;
        }
        private void updatetextbox24()
        {
            textBox24.Text = currentValue24.ToString();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked24)
            {
                currentValue24--;
                if (currentValue24 < 0)
                {
                    currentValue24 = 0;
                }
                updatetextbox24();
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked24)
            {
                currentValue24++;
                if (currentValue24 >= 10)
                {
                    currentValue24 = 10;
                }
                updatetextbox24();
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked25 = checkBox23.Checked;
            button67.Enabled = button68.Enabled = button69.Enabled = isCheckboxChecked25;
        }
        private void updatetextbox25()
        {
            textBox23.Text = currentValue25.ToString();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked25)
            {
                currentValue25--;
                if (currentValue25 < 0)
                {
                    currentValue25 = 0;
                }
                updatetextbox25();
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked25)
            {
                currentValue25++;
                if (currentValue25 >= 10)
                {
                    currentValue25 = 10;
                }
                updatetextbox25();
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked26 = checkBox22.Checked;
            button64.Enabled = button65.Enabled = button66.Enabled = isCheckboxChecked26;
        }
        private void updatetextbox26()
        {
            textBox22.Text = currentValue26.ToString();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked26)
            {
                currentValue26--;
                if (currentValue26 < 0)
                {
                    currentValue26 = 0;
                }
                updatetextbox26();
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked26)
            {
                currentValue26++;
                if (currentValue26 >= 10)
                {
                    currentValue26 = 10;
                }
                updatetextbox26();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox1.Text);
                    string itemId = "F1"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked)
            {
                int quantity = int.Parse(textBox1.Text);
                AddToCart("F1", "Veg Momo", quantity); // Update parameters accordingly
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox2.Text);
                    string itemId = "F2"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked1)
            {
                int quantity = int.Parse(textBox2.Text);
                AddToCart("F2", "Buff Momo", quantity); // Update parameters accordingly
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox3.Text);
                    string itemId = "F3"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked2)
            {
                int quantity = int.Parse(textBox3.Text);
                AddToCart("F3", "C.MO:MO", quantity); // Update parameters accordingly
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox4.Text);
                    string itemId = "F4"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked3)
            {
                int quantity = int.Parse(textBox4.Text);
                AddToCart("F4", "Veg.Chowmin", quantity); // Update parameters accordingly
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox5.Text);
                    string itemId = "F5"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked4)
            {
                int quantity = int.Parse(textBox5.Text);
                AddToCart("F5", "Buff.Chowmin", quantity); // Update parameters accordingly
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox6.Text);
                    string itemId = "F6"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked5)
            {
                int quantity = int.Parse(textBox6.Text);
                AddToCart("F6", "C.Chowmin", quantity); // Update parameters accordingly
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox7.Text);
                    string itemId = "F7"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked6)
            {
                int quantity = int.Parse(textBox7.Text);
                AddToCart("F7", "Veg Pizza", quantity); // Update parameters accordingly
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox9.Text);
                    string itemId = "F8"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked7)
            {
                int quantity = int.Parse(textBox9.Text);
                AddToCart("F8", "Buff Pizza", quantity); // Update parameters accordingly
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox8.Text);
                    string itemId = "F9"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked8)
            {
                int quantity = int.Parse(textBox8.Text);
                AddToCart("F9", "C.Pizza", quantity); // Update parameters accordingly
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox10.Text);
                    string itemId = "F10"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked9)
            {
                int quantity = int.Parse(textBox10.Text);
                AddToCart("F10", "Veg.Burger", quantity); // Update parameters accordingly
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox11.Text);
                    string itemId = "F11"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked10)
            {
                int quantity = int.Parse(textBox11.Text);
                AddToCart("F11", "Buff.Burger", quantity); // Update parameters accordingly
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox12.Text);
                    string itemId = "F12"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked11)
            {
                int quantity = int.Parse(textBox12.Text);
                AddToCart("F12", "C.Burger", quantity); // Update parameters accordingly
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox16.Text);
                    string itemId = "F13"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked12)
            {
                int quantity = int.Parse(textBox16.Text);
                AddToCart("F13", "Veg.Khana", quantity); // Update parameters accordingly
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox17.Text);
                    string itemId = "F14"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked13)
            {
                int quantity = int.Parse(textBox17.Text);
                AddToCart("F14", "Buff.Khana", quantity); // Update parameters accordingly
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox18.Text);
                    string itemId = "F15"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked14)
            {
                int quantity = int.Parse(textBox18.Text);
                AddToCart("F15", "C.Khana", quantity); // Update parameters accordingly
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox27.Text);
                    string itemId = "F16"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked15)
            {
                int quantity = int.Parse(textBox27.Text);
                AddToCart("F16", "Veg.Biriyani", quantity); // Update parameters accordingly
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox26.Text);
                    string itemId = "F17"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked16)
            {
                int quantity = int.Parse(textBox26.Text);
                AddToCart("F17", "Buff.Biriyani", quantity); // Update parameters accordingly
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox25.Text);
                    string itemId = "F18"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked17)
            {
                int quantity = int.Parse(textBox25.Text);
                AddToCart("F18", "C.Biriyani", quantity); // Update parameters accordingly
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox21.Text);
                    string itemId = "F19"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked18)
            {
                int quantity = int.Parse(textBox21.Text);
                AddToCart("F19", "Cappuchino", quantity); // Update parameters accordingly
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox20.Text);
                    string itemId = "F20"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked19)
            {
                int quantity = int.Parse(textBox20.Text);
                AddToCart("F20", "Expresso", quantity); // Update parameters accordingly
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox19.Text);
                    string itemId = "F21"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked20)
            {
                int quantity = int.Parse(textBox19.Text);
                AddToCart("F21", "Lattee", quantity); // Update parameters accordingly
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox15.Text);
                    string itemId = "F22"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked21)
            {
                int quantity = int.Parse(textBox15.Text);
                AddToCart("F22", "Cococola", quantity); // Update parameters accordingly
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox14.Text);
                    string itemId = "F23"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked22)
            {
                int quantity = int.Parse(textBox14.Text);
                AddToCart("F23", "Fanta", quantity); // Update parameters accordingly
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox13.Text);
                    string itemId = "F24"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked23)
            {
                int quantity = int.Parse(textBox13.Text);
                AddToCart("F24", "Dew", quantity); // Update parameters accordingly
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox24.Text);
                    string itemId = "F25"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked24)
            {
                int quantity = int.Parse(textBox24.Text);
                AddToCart("F25", "Monster", quantity); // Update parameters accordingly
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox23.Text);
                    string itemId = "F26"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked25)
            {
                int quantity = int.Parse(textBox23.Text);
                AddToCart("F26", "Prime", quantity); // Update parameters accordingly
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int quantity = int.Parse(textBox22.Text);
                    string itemId = "F27"; // Replace "F1" with actual item ID
                    string query = "UPDATE cart SET c_qty = @c_qty WHERE F_ID = @F_ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_qty", quantity);
                        cmd.Parameters.AddWithValue("@F_ID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    return; // Exit the method if there's an error
                }
            }

            if (isCheckboxChecked26)
            {
                int quantity = int.Parse(textBox22.Text);
                AddToCart("F27", "Red Bull", quantity); // Update parameters accordingly
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Payment ok = new Payment();
            ok.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Red;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Tan;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            Bhaktapur ok = new Bhaktapur();
            ok.Show();
            this.Hide();
        }
    }
}
