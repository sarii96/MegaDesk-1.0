
namespace MegaDesk_1._0
{
    partial class AddQuote
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
            this.btGetQuote = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialBox = new System.Windows.Forms.ComboBox();
            this.deliveryBox = new System.Windows.Forms.ComboBox();
            this.NumberOfDrawUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depthUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btGetQuote
            // 
            this.btGetQuote.AutoSize = true;
            this.btGetQuote.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGetQuote.Location = new System.Drawing.Point(164, 358);
            this.btGetQuote.Name = "btGetQuote";
            this.btGetQuote.Size = new System.Drawing.Size(169, 63);
            this.btGetQuote.TabIndex = 0;
            this.btGetQuote.Text = "Get Quote";
            this.btGetQuote.UseVisualStyleBackColor = true;
            this.btGetQuote.Click += new System.EventHandler(this.btGetQuote_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(388, 358);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(169, 63);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(186, 179);
            this.widthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 22);
            this.widthUpDown.TabIndex = 18;
            this.widthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // surfaceMaterialBox
            // 
            this.surfaceMaterialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialBox.FormattingEnabled = true;
            this.surfaceMaterialBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer  "});
            this.surfaceMaterialBox.Location = new System.Drawing.Point(564, 213);
            this.surfaceMaterialBox.Name = "surfaceMaterialBox";
            this.surfaceMaterialBox.Size = new System.Drawing.Size(156, 24);
            this.surfaceMaterialBox.TabIndex = 4;
            // 
            // deliveryBox
            // 
            this.deliveryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryBox.FormattingEnabled = true;
            this.deliveryBox.Items.AddRange(new object[] {
            "Rush - 3 days",
            "Rush - 5 days",
            "Rush- 7 days",
            "No rush - 14 days"});
            this.deliveryBox.Location = new System.Drawing.Point(564, 261);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(156, 24);
            this.deliveryBox.TabIndex = 5;
            // 
            // NumberOfDrawUpDown
            // 
            this.NumberOfDrawUpDown.Location = new System.Drawing.Point(564, 176);
            this.NumberOfDrawUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumberOfDrawUpDown.Name = "NumberOfDrawUpDown";
            this.NumberOfDrawUpDown.Size = new System.Drawing.Size(120, 22);
            this.NumberOfDrawUpDown.TabIndex = 16;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(201, 77);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(342, 22);
            this.textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Quote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Drawers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Surface Material:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Delivery:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Desk Size";
            // 
            // depthUpDown
            // 
            this.depthUpDown.Location = new System.Drawing.Point(186, 236);
            this.depthUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(120, 22);
            this.depthUpDown.TabIndex = 17;
            this.depthUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.NumberOfDrawUpDown);
            this.Controls.Add(this.deliveryBox);
            this.Controls.Add(this.surfaceMaterialBox);
            this.Controls.Add(this.depthUpDown);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btGetQuote);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGetQuote;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.ComboBox surfaceMaterialBox;
        private System.Windows.Forms.ComboBox deliveryBox;
        private System.Windows.Forms.NumericUpDown NumberOfDrawUpDown;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown depthUpDown;
    }
}