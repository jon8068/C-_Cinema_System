namespace CinemaGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.viewTheaters1 = new CinemaGUI.ViewTheaters();
            this.createCustomers1 = new CinemaGUI.CreateCustomers();
            this.showTransactions1 = new CinemaGUI.ShowTransactions();
            this.showSeats1 = new CinemaGUI.ShowSeats();
            this.showMovies1 = new CinemaGUI.ShowMovies();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Theaters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(537, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 88);
            this.button4.TabIndex = 6;
            this.button4.Text = "Transactions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(311, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 81);
            this.button5.TabIndex = 7;
            this.button5.Text = "Show Movies";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(80, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 81);
            this.button6.TabIndex = 8;
            this.button6.Text = "Show Seats";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // viewTheaters1
            // 
            this.viewTheaters1.Location = new System.Drawing.Point(26, 2);
            this.viewTheaters1.Name = "viewTheaters1";
            this.viewTheaters1.Size = new System.Drawing.Size(762, 447);
            this.viewTheaters1.TabIndex = 4;
            this.viewTheaters1.Load += new System.EventHandler(this.viewTheaters1_Load);
            // 
            // createCustomers1
            // 
            this.createCustomers1.Location = new System.Drawing.Point(44, 2);
            this.createCustomers1.Name = "createCustomers1";
            this.createCustomers1.Size = new System.Drawing.Size(722, 430);
            this.createCustomers1.TabIndex = 5;
            this.createCustomers1.Load += new System.EventHandler(this.createCustomers1_Load);
            // 
            // showTransactions1
            // 
            this.showTransactions1.Location = new System.Drawing.Point(26, 2);
            this.showTransactions1.Name = "showTransactions1";
            this.showTransactions1.Size = new System.Drawing.Size(745, 442);
            this.showTransactions1.TabIndex = 9;
            // 
            // showSeats1
            // 
            this.showSeats1.Location = new System.Drawing.Point(61, 24);
            this.showSeats1.Name = "showSeats1";
            this.showSeats1.Size = new System.Drawing.Size(689, 392);
            this.showSeats1.TabIndex = 11;
            // 
            // showMovies1
            // 
            this.showMovies1.Location = new System.Drawing.Point(-20, -39);
            this.showMovies1.Name = "showMovies1";
            this.showMovies1.Size = new System.Drawing.Size(846, 500);
            this.showMovies1.TabIndex = 10;
            this.showMovies1.Load += new System.EventHandler(this.showMovies1_Load);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(80, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 81);
            this.button7.TabIndex = 12;
            this.button7.Text = "Add Theaters";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(537, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 81);
            this.button8.TabIndex = 13;
            this.button8.Text = "Add Movies";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewTheaters1);
            this.Controls.Add(this.createCustomers1);
            this.Controls.Add(this.showTransactions1);
            this.Controls.Add(this.showSeats1);
            this.Controls.Add(this.showMovies1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ViewTheaters viewTheaters1;
        private CreateCustomers createCustomers1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private ShowTransactions showTransactions1;
        private ShowMovies showMovies1;
        private ShowSeats showSeats1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

