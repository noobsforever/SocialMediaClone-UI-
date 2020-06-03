namespace SocialMediaClone
{
    partial class Newsfeed
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
            this.postItem2 = new SocialMediaClone.PostItem();
            this.postItem1 = new SocialMediaClone.PostItem();
            this.postItem3 = new SocialMediaClone.PostItem();
            this.SuspendLayout();
            // 
            // postItem2
            // 
            this.postItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.postItem2.Location = new System.Drawing.Point(0, 0);
            this.postItem2.Name = "postItem2";
            this.postItem2.Padding = new System.Windows.Forms.Padding(14);
            this.postItem2.Size = new System.Drawing.Size(1060, 313);
            this.postItem2.TabIndex = 2;
            // 
            // postItem1
            // 
            this.postItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.postItem1.Location = new System.Drawing.Point(0, 313);
            this.postItem1.Name = "postItem1";
            this.postItem1.Padding = new System.Windows.Forms.Padding(14);
            this.postItem1.Size = new System.Drawing.Size(1060, 313);
            this.postItem1.TabIndex = 3;
            // 
            // postItem3
            // 
            this.postItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.postItem3.Location = new System.Drawing.Point(0, 626);
            this.postItem3.Name = "postItem3";
            this.postItem3.Padding = new System.Windows.Forms.Padding(14);
            this.postItem3.Size = new System.Drawing.Size(1060, 313);
            this.postItem3.TabIndex = 4;
            // 
            // Newsfeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1077, 568);
            this.Controls.Add(this.postItem3);
            this.Controls.Add(this.postItem1);
            this.Controls.Add(this.postItem2);
            this.Name = "Newsfeed";
            this.Text = "Newsfeed";
            this.ResumeLayout(false);

        }

        #endregion

        private PostItem postItem2;
        private PostItem postItem1;
        private PostItem postItem3;
    }
}