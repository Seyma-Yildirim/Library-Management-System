
namespace LibraryManagmentSystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.label7 = new System.Windows.Forms.Label();
            this.txtBQ = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBPub = new System.Windows.Forms.TextBox();
            this.txtBAN = new System.Windows.Forms.TextBox();
            this.txtBPrice = new System.Windows.Forms.TextBox();
            this.txtBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 43);
            this.label7.TabIndex = 31;
            this.label7.Text = "ADD NEW BOOK";
            // 
            // txtBQ
            // 
            this.txtBQ.Location = new System.Drawing.Point(326, 356);
            this.txtBQ.Name = "txtBQ";
            this.txtBQ.Size = new System.Drawing.Size(319, 22);
            this.txtBQ.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(500, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 38);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(326, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 38);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // txtBPub
            // 
            this.txtBPub.Location = new System.Drawing.Point(326, 234);
            this.txtBPub.Name = "txtBPub";
            this.txtBPub.Size = new System.Drawing.Size(319, 22);
            this.txtBPub.TabIndex = 22;
            // 
            // txtBAN
            // 
            this.txtBAN.Location = new System.Drawing.Point(326, 173);
            this.txtBAN.Name = "txtBAN";
            this.txtBAN.Size = new System.Drawing.Size(319, 22);
            this.txtBAN.TabIndex = 20;
            // 
            // txtBPrice
            // 
            this.txtBPrice.Location = new System.Drawing.Point(326, 429);
            this.txtBPrice.Name = "txtBPrice";
            this.txtBPrice.Size = new System.Drawing.Size(319, 22);
            this.txtBPrice.TabIndex = 26;
            // 
            // txtBN
            // 
            this.txtBN.Location = new System.Drawing.Point(326, 107);
            this.txtBN.Name = "txtBN";
            this.txtBN.Size = new System.Drawing.Size(319, 22);
            this.txtBN.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Book Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Book Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Book Purchase Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Book Publication:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book Author Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book Name:";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 553);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBQ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBPub);
            this.Controls.Add(this.txtBAN);
            this.Controls.Add(this.txtBPrice);
            this.Controls.Add(this.txtBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBQ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBPub;
        private System.Windows.Forms.TextBox txtBAN;
        private System.Windows.Forms.TextBox txtBPrice;
        private System.Windows.Forms.TextBox txtBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}