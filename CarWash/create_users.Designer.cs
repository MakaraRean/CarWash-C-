namespace CarWash
{
    partial class create_users
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_users));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btAddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.checkboxShowPass = new System.Windows.Forms.CheckBox();
            this.checkBoxConfirmShowPass = new System.Windows.Forms.CheckBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MASTERPLAN", 20F);
            this.label1.Location = new System.Drawing.Point(226, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new user";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(207, 127);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(207, 198);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(226, 30);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(207, 274);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(226, 30);
            this.txtConfirmPass.TabIndex = 6;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position";
            // 
            // cbPosition
            // 
            this.cbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Admin",
            "Seller",
            "Manager"});
            this.cbPosition.Location = new System.Drawing.Point(207, 354);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(226, 33);
            this.cbPosition.TabIndex = 8;
            // 
            // btAddUser
            // 
            this.btAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Location = new System.Drawing.Point(207, 410);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(226, 41);
            this.btAddUser.TabIndex = 9;
            this.btAddUser.Text = "Add User";
            this.btAddUser.UseVisualStyleBackColor = false;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Oregon LDO Black", 12F, System.Drawing.FontStyle.Bold);
            this.Close.ForeColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(652, 2);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Close.Size = new System.Drawing.Size(30, 28);
            this.Close.TabIndex = 10;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDrag.Controls.Add(this.Minimize);
            this.panelDrag.Controls.Add(this.Close);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(686, 32);
            this.panelDrag.TabIndex = 11;
            // 
            // checkboxShowPass
            // 
            this.checkboxShowPass.AutoSize = true;
            this.checkboxShowPass.Location = new System.Drawing.Point(439, 200);
            this.checkboxShowPass.Name = "checkboxShowPass";
            this.checkboxShowPass.Size = new System.Drawing.Size(175, 29);
            this.checkboxShowPass.TabIndex = 12;
            this.checkboxShowPass.Text = "Show Password";
            this.checkboxShowPass.UseVisualStyleBackColor = true;
            this.checkboxShowPass.CheckedChanged += new System.EventHandler(this.checkboxShowPass_CheckedChanged);
            // 
            // checkBoxConfirmShowPass
            // 
            this.checkBoxConfirmShowPass.AutoSize = true;
            this.checkBoxConfirmShowPass.Location = new System.Drawing.Point(439, 276);
            this.checkBoxConfirmShowPass.Name = "checkBoxConfirmShowPass";
            this.checkBoxConfirmShowPass.Size = new System.Drawing.Size(175, 29);
            this.checkBoxConfirmShowPass.TabIndex = 13;
            this.checkBoxConfirmShowPass.Text = "Show Password";
            this.checkBoxConfirmShowPass.UseVisualStyleBackColor = true;
            this.checkBoxConfirmShowPass.CheckedChanged += new System.EventHandler(this.checkBoxConfirmShowPass_CheckedChanged);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(44, 51);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(48, 41);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 14;
            this.pictureBoxBack.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Oregon LDO Black", 12F, System.Drawing.FontStyle.Bold);
            this.Minimize.ForeColor = System.Drawing.Color.Red;
            this.Minimize.Location = new System.Drawing.Point(627, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Minimize.Size = new System.Drawing.Size(25, 28);
            this.Minimize.TabIndex = 11;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // create_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 569);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.checkBoxConfirmShowPass);
            this.Controls.Add(this.checkboxShowPass);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "create_users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Users";
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.CheckBox checkBoxConfirmShowPass;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label Minimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

