
namespace MegaDesk_1._0
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btAddNewQuote = new System.Windows.Forms.Button();
            this.btViewQuotes = new System.Windows.Forms.Button();
            this.btSearchQuotes = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddNewQuote
            // 
            this.btAddNewQuote.Location = new System.Drawing.Point(35, 38);
            this.btAddNewQuote.Name = "btAddNewQuote";
            this.btAddNewQuote.Size = new System.Drawing.Size(303, 84);
            this.btAddNewQuote.TabIndex = 0;
            this.btAddNewQuote.Text = "Add New Quote";
            this.btAddNewQuote.UseVisualStyleBackColor = true;
            this.btAddNewQuote.Click += new System.EventHandler(this.btAddNewQuote_Click);
            // 
            // btViewQuotes
            // 
            this.btViewQuotes.Location = new System.Drawing.Point(35, 148);
            this.btViewQuotes.Name = "btViewQuotes";
            this.btViewQuotes.Size = new System.Drawing.Size(303, 84);
            this.btViewQuotes.TabIndex = 1;
            this.btViewQuotes.Text = "View Quotes";
            this.btViewQuotes.UseVisualStyleBackColor = true;
            this.btViewQuotes.Click += new System.EventHandler(this.btViewQuotes_Click);
            // 
            // btSearchQuotes
            // 
            this.btSearchQuotes.Location = new System.Drawing.Point(35, 267);
            this.btSearchQuotes.Name = "btSearchQuotes";
            this.btSearchQuotes.Size = new System.Drawing.Size(303, 84);
            this.btSearchQuotes.TabIndex = 2;
            this.btSearchQuotes.Text = "Search Quotes";
            this.btSearchQuotes.UseVisualStyleBackColor = true;
            this.btSearchQuotes.Click += new System.EventHandler(this.btSearchQuotes_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(35, 375);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(303, 84);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSearchQuotes);
            this.Controls.Add(this.btViewQuotes);
            this.Controls.Add(this.btAddNewQuote);
            this.Name = "MainMenu";
            this.Text = "MageDesk | Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddNewQuote;
        private System.Windows.Forms.Button btViewQuotes;
        private System.Windows.Forms.Button btSearchQuotes;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

