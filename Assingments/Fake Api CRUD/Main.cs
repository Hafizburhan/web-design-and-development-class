using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pureCRUD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Size = new Size(630, 420);
        }
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.Size = new Size(37, 37);
        }

        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.Size = new Size(36, 36);
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(37, 37);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(36, 36);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(630, 420);
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.White;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Gainsboro;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Name")
            {
                name.Text = "";
                name.ForeColor = Color.White;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Name";
                name.ForeColor = Color.Gainsboro;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.PasswordChar = '*';
                password.ForeColor = Color.White;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.PasswordChar = '\0';
                password.ForeColor = Color.Gainsboro;
            }
        }

        private void website_Enter(object sender, EventArgs e)
        {
            if (website.Text == "Website")
            {
                website.Text = "";
                website.ForeColor = Color.White;
            }
        }

        private void website_Leave(object sender, EventArgs e)
        {
            if (website.Text == "")
            {
                website.Text = "Website";
                website.ForeColor = Color.Gainsboro;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
                email.ForeColor = Color.White;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
                email.ForeColor = Color.Gainsboro;
            }
        }
        DataTable dTable = new DataTable();
        private void readBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase db = new dataBase();
                MySqlCommand command = new MySqlCommand("SELECT * FROM credentials.data;", db.getConnection());
                db.openConnection();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataView.DataSource = dTable;
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(864, 420);
            submitBtn.Hide();
            submitBtn2.Show();
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            // update record
            if (username.Text == "" || username.Text == "Username")
                MessageBox.Show("Please Enter Username!");
            else if (name.Text == "" || name.Text == "Name")
                MessageBox.Show("Please Enter Name!");
            else if (password.Text == "" || password.Text == "Password")
                MessageBox.Show("Please Enter Password!");
            else if (website.Text == "" || website.Text == "Website")
                MessageBox.Show("Please Enter Website!");
            else if (email.Text == "" || email.Text == "Email")
                MessageBox.Show("Please Enter Email!");
            else
            {
                try
                {
                    dataBase db = new dataBase();
                    string id = dTable.Rows[dataView.CurrentRow.Index]["ID"].ToString();
                    MySqlCommand command = new MySqlCommand("UPDATE credentials.data SET Username='" + this.username.Text + "',Name='" + this.name.Text + "',Website='" + this.website.Text + "',Email='" + this.email.Text + "',Password='" + this.password.Text + "' WHERE ID =" + id, db.getConnection());
                    db.openConnection();
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    db.closeConnection();

                    readBtn.PerformClick();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(864, 420);
            submitBtn.Show();
            submitBtn2.Hide();
        }

        private void clear()
        {
            username.Text = "Username";
            username.ForeColor = Color.Gainsboro;
            name.Text = "Name";
            name.ForeColor = Color.Gainsboro;
            email.Text = "Email";
            email.ForeColor = Color.Gainsboro;
            password.Text = "Password";
            password.ForeColor = Color.Gainsboro;
            website.Text = "Website";
            website.ForeColor = Color.Gainsboro;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // create record
            if (username.Text == "" || username.Text == "Username")
                MessageBox.Show("Please Enter Username!");
            else if (name.Text == "" || name.Text == "Name")
                MessageBox.Show("Please Enter Name!");
            else if (password.Text == "" || password.Text == "Password")
                MessageBox.Show("Please Enter Password!");
            else if (website.Text == "" || website.Text == "Website")
                MessageBox.Show("Please Enter Website!");
            else if (email.Text == "" || email.Text == "Email")
                MessageBox.Show("Please Enter Email!");
            else
            {
                try
                {
                    dataBase db = new dataBase();
                    MySqlCommand command = new MySqlCommand("INSERT INTO credentials.data(Username,Name,Website,Email,Password) VALUES('" + this.username.Text + "','" + this.name.Text + "','" + this.website.Text + "','" + this.email.Text + "','" + this.password.Text + "');", db.getConnection());
                    db.openConnection();
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    db.closeConnection();

                    readBtn.PerformClick();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // delete record
            try
            {
                dataBase db = new dataBase();
                string id = dTable.Rows[dataView.CurrentRow.Index]["ID"].ToString();
                MySqlCommand command = new MySqlCommand("DELETE FROM credentials.data WHERE ID =" + id, db.getConnection());
                db.openConnection();
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                db.closeConnection();

                readBtn.PerformClick();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            readBtn.PerformClick();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            readBtn.PerformClick();
        }
    }
}
