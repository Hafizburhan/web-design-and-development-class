using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pureCRUD
{
    public partial class start : Form
    {
        private string Password = "Hafizburhan";
        public start()
        {
            InitializeComponent();
            focus.Focus();
        }

        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        private void start_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void start_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void start_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void passwordCheck_Enter(object sender, EventArgs e)
        {
            passwordCheck.Text = "";
            passwordCheck.PasswordChar = '*';
            passwordCheck.ForeColor = Color.Black;
        }

        private void passwordCheck_Leave(object sender, EventArgs e)
        {
            passwordCheck.Text = "Password";
            passwordCheck.ForeColor = Color.Gray;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(40, 40);
            closeBtn.Location = new Point(518, 3);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Size = new Size(36, 36);
            closeBtn.Location = new Point(520, 5);
        }

        private void passwordCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (passwordCheck.Text == Password)
                {
                    this.Hide();
                    Main m = new Main();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password!", "Password Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }
    }
}
