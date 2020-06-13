namespace CinemaGUI
{
    partial class ShowMovies
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MovName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Starring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovName,
            this.Genre,
            this.Starring,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(69, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(718, 320);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MovName
            // 
            this.MovName.HeaderText = "Movie Name";
            this.MovName.MinimumWidth = 8;
            this.MovName.Name = "MovName";
            this.MovName.Width = 150;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.Width = 150;
            // 
            // Starring
            // 
            this.Starring.HeaderText = "Starring";
            this.Starring.MinimumWidth = 8;
            this.Starring.Name = "Starring";
            this.Starring.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "List of Movies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowMovies";
            this.Size = new System.Drawing.Size(846, 500);
            this.Load += new System.EventHandler(this.ShowMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Starring;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
