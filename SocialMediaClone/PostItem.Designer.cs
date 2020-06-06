namespace SocialMediaClone
{
    partial class PostItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.commentButton = new FontAwesome.Sharp.IconButton();
            this.dislikeButton = new FontAwesome.Sharp.IconButton();
            this.likeButton = new FontAwesome.Sharp.IconButton();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.likeLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.commentButton);
            this.panel1.Controls.Add(this.dislikeButton);
            this.panel1.Controls.Add(this.likeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 54);
            this.panel1.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteButton.IconColor = System.Drawing.Color.DarkRed;
            this.deleteButton.IconSize = 32;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(413, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.deleteButton.Rotation = 0D;
            this.deleteButton.Size = new System.Drawing.Size(162, 54);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete Post";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // commentButton
            // 
            this.commentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.commentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.commentButton.FlatAppearance.BorderSize = 0;
            this.commentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.commentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.commentButton.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.commentButton.IconColor = System.Drawing.Color.Orange;
            this.commentButton.IconSize = 32;
            this.commentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commentButton.Location = new System.Drawing.Point(251, 0);
            this.commentButton.Name = "commentButton";
            this.commentButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.commentButton.Rotation = 0D;
            this.commentButton.Size = new System.Drawing.Size(162, 54);
            this.commentButton.TabIndex = 8;
            this.commentButton.Text = "Comments";
            this.commentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.commentButton.UseVisualStyleBackColor = false;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // dislikeButton
            // 
            this.dislikeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dislikeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.dislikeButton.FlatAppearance.BorderSize = 0;
            this.dislikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dislikeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dislikeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislikeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.dislikeButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            this.dislikeButton.IconColor = System.Drawing.Color.Red;
            this.dislikeButton.IconSize = 32;
            this.dislikeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dislikeButton.Location = new System.Drawing.Point(112, 0);
            this.dislikeButton.Name = "dislikeButton";
            this.dislikeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dislikeButton.Rotation = 0D;
            this.dislikeButton.Size = new System.Drawing.Size(139, 54);
            this.dislikeButton.TabIndex = 7;
            this.dislikeButton.Text = "Dislike";
            this.dislikeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dislikeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dislikeButton.UseVisualStyleBackColor = false;
            this.dislikeButton.Click += new System.EventHandler(this.dislikeButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.likeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.likeButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.likeButton.IconColor = System.Drawing.Color.MediumBlue;
            this.likeButton.IconSize = 32;
            this.likeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.likeButton.Location = new System.Drawing.Point(0, 0);
            this.likeButton.Name = "likeButton";
            this.likeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.likeButton.Rotation = 0D;
            this.likeButton.Size = new System.Drawing.Size(112, 54);
            this.likeButton.TabIndex = 6;
            this.likeButton.Text = "Like";
            this.likeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.likeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(4, 4);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(73, 17);
            this.fullnameLabel.TabIndex = 0;
            this.fullnameLabel.Text = "Full Name";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Silver;
            this.dateLabel.Location = new System.Drawing.Point(4, 21);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(56, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "6/2/2020";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Silver;
            this.timeLabel.Location = new System.Drawing.Point(4, 38);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 17);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "4:02 PM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.fullnameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 71);
            this.panel2.TabIndex = 1;
            // 
            // likeLabel
            // 
            this.likeLabel.AutoSize = true;
            this.likeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.likeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.ForeColor = System.Drawing.Color.White;
            this.likeLabel.Location = new System.Drawing.Point(35, 241);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(16, 18);
            this.likeLabel.TabIndex = 10;
            this.likeLabel.Text = "0";
            this.likeLabel.Click += new System.EventHandler(this.likeLabel_Click);
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.ForeColor = System.Drawing.Color.White;
            this.commentLabel.Location = new System.Drawing.Point(410, 193);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(16, 18);
            this.commentLabel.TabIndex = 11;
            this.commentLabel.Text = "0";
            this.commentLabel.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 71);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.ReadOnly = true;
            this.descriptionLabel.Size = new System.Drawing.Size(807, 188);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            this.descriptionLabel.TextChanged += new System.EventHandler(this.descriptionLabel_TextChanged);
            // 
            // PostItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.likeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PostItem";
            this.Size = new System.Drawing.Size(807, 313);
            this.Load += new System.EventHandler(this.PostItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton commentButton;
        private FontAwesome.Sharp.IconButton dislikeButton;
        private FontAwesome.Sharp.IconButton likeButton;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label likeLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.RichTextBox descriptionLabel;
    }
}
