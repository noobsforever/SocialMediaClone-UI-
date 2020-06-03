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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 71);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "6/2/2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "4:02 PM";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(807, 188);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // PostItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PostItem";
            this.Size = new System.Drawing.Size(807, 313);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton commentButton;
        private FontAwesome.Sharp.IconButton dislikeButton;
        private FontAwesome.Sharp.IconButton likeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
