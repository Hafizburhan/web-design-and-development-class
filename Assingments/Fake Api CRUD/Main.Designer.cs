namespace pureCRUD
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitBtn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(369, 6);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Credentials";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            this.label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pureCRUD.Properties.Resources.cumulus_cloud1;
            this.panel1.Controls.Add(this.submitBtn2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.website);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.dataView);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.readBtn);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 387);
            this.panel1.TabIndex = 0;
            // 
            // submitBtn2
            // 
            this.submitBtn2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn2.Location = new System.Drawing.Point(699, 317);
            this.submitBtn2.Name = "submitBtn2";
            this.submitBtn2.Size = new System.Drawing.Size(101, 45);
            this.submitBtn2.TabIndex = 22;
            this.submitBtn2.Text = "Submit";
            this.submitBtn2.UseVisualStyleBackColor = true;
            this.submitBtn2.Click += new System.EventHandler(this.submit2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gainsboro;
            this.password.Location = new System.Drawing.Point(668, 160);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(157, 26);
            this.password.TabIndex = 20;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Gainsboro;
            this.email.Location = new System.Drawing.Point(635, 262);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(225, 26);
            this.email.TabIndex = 19;
            this.email.Text = "Email";
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // website
            // 
            this.website.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.website.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.ForeColor = System.Drawing.Color.Gainsboro;
            this.website.Location = new System.Drawing.Point(635, 211);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(225, 26);
            this.website.TabIndex = 18;
            this.website.Text = "Website";
            this.website.Enter += new System.EventHandler(this.website_Enter);
            this.website.Leave += new System.EventHandler(this.website_Leave);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Gainsboro;
            this.name.Location = new System.Drawing.Point(668, 109);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 26);
            this.name.TabIndex = 17;
            this.name.Text = "Name";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(699, 317);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(101, 45);
            this.submitBtn.TabIndex = 15;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gainsboro;
            this.username.Location = new System.Drawing.Point(668, 56);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(157, 26);
            this.username.TabIndex = 16;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(630, 334);
            this.dataView.TabIndex = 6;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(512, 340);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 39);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(343, 340);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 39);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(175, 340);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 39);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(12, 340);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 39);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeBtn.BackgroundImage = global::pureCRUD.Properties.Resources.icons8_close_window_100;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Location = new System.Drawing.Point(826, -2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 36);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizeBtn.BackgroundImage = global::pureCRUD.Properties.Resources.icons8_minimize_window_100;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeBtn.Location = new System.Drawing.Point(784, -2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(36, 36);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.minimizeBtn_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.minimizeBtn_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(864, 420);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox website;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitBtn2;
    }
}

