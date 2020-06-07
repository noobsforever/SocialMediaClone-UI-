namespace SocialMediaClone
{
    partial class SearchItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.followButton = new FontAwesome.Sharp.IconButton();
            this.viewProfileButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.followButton);
            this.panel1.Controls.Add(this.viewProfileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 54);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // followButton
            // 
            this.followButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.followButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.followButton.FlatAppearance.BorderSize = 0;
            this.followButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.followButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.followButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.followButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.followButton.IconColor = System.Drawing.Color.Green;
            this.followButton.IconSize = 32;
            this.followButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.followButton.Location = new System.Drawing.Point(143, 0);
            this.followButton.Name = "followButton";
            this.followButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.followButton.Rotation = 0D;
            this.followButton.Size = new System.Drawing.Size(139, 54);
            this.followButton.TabIndex = 7;
            this.followButton.Text = "Send Request";
            this.followButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.followButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.followButton.UseVisualStyleBackColor = false;
            this.followButton.Click += new System.EventHandler(this.followButton_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.viewProfileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewProfileButton.FlatAppearance.BorderSize = 0;
            this.viewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfileButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.viewProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewProfileButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.viewProfileButton.IconColor = System.Drawing.Color.Green;
            this.viewProfileButton.IconSize = 32;
            this.viewProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProfileButton.Location = new System.Drawing.Point(0, 0);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.viewProfileButton.Rotation = 0D;
            this.viewProfileButton.Size = new System.Drawing.Size(143, 54);
            this.viewProfileButton.TabIndex = 6;
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.fullnameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 71);
            this.panel2.TabIndex = 5;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(128, 19);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(119, 25);
            this.fullnameLabel.TabIndex = 0;
            this.fullnameLabel.Text = "Full Name";
            // 
            // SearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchItem";
            this.Size = new System.Drawing.Size(431, 124);
            this.Load += new System.EventHandler(this.SearchItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton followButton;
        private FontAwesome.Sharp.IconButton viewProfileButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fullnameLabel;
    }
}
