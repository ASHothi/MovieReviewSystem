namespace MediaReviewSystem
{
    partial class SelectionScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RBMovie = new System.Windows.Forms.RadioButton();
            this.RBTV = new System.Windows.Forms.RadioButton();
            this.RBActor = new System.Windows.Forms.RadioButton();
            this.RBWriter = new System.Windows.Forms.RadioButton();
            this.RBDirector = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEARCH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(316, 213);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RBMovie
            // 
            this.RBMovie.AutoSize = true;
            this.RBMovie.Location = new System.Drawing.Point(396, 121);
            this.RBMovie.Name = "RBMovie";
            this.RBMovie.Size = new System.Drawing.Size(63, 19);
            this.RBMovie.TabIndex = 6;
            this.RBMovie.TabStop = true;
            this.RBMovie.Text = "Movies";
            this.RBMovie.UseVisualStyleBackColor = true;
            // 
            // RBTV
            // 
            this.RBTV.AutoSize = true;
            this.RBTV.Location = new System.Drawing.Point(396, 146);
            this.RBTV.Name = "RBTV";
            this.RBTV.Size = new System.Drawing.Size(69, 19);
            this.RBTV.TabIndex = 7;
            this.RBTV.TabStop = true;
            this.RBTV.Text = "TV show";
            this.RBTV.UseVisualStyleBackColor = true;
            // 
            // RBActor
            // 
            this.RBActor.AutoSize = true;
            this.RBActor.Location = new System.Drawing.Point(396, 171);
            this.RBActor.Name = "RBActor";
            this.RBActor.Size = new System.Drawing.Size(54, 19);
            this.RBActor.TabIndex = 8;
            this.RBActor.TabStop = true;
            this.RBActor.Text = "Actor";
            this.RBActor.UseVisualStyleBackColor = true;
            // 
            // RBWriter
            // 
            this.RBWriter.AutoSize = true;
            this.RBWriter.Location = new System.Drawing.Point(396, 196);
            this.RBWriter.Name = "RBWriter";
            this.RBWriter.Size = new System.Drawing.Size(57, 19);
            this.RBWriter.TabIndex = 9;
            this.RBWriter.TabStop = true;
            this.RBWriter.Text = "Writer";
            this.RBWriter.UseVisualStyleBackColor = true;
            // 
            // RBDirector
            // 
            this.RBDirector.AutoSize = true;
            this.RBDirector.Location = new System.Drawing.Point(396, 221);
            this.RBDirector.Name = "RBDirector";
            this.RBDirector.Size = new System.Drawing.Size(67, 19);
            this.RBDirector.TabIndex = 10;
            this.RBDirector.TabStop = true;
            this.RBDirector.Text = "Director";
            this.RBDirector.UseVisualStyleBackColor = true;
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RBDirector);
            this.Controls.Add(this.RBWriter);
            this.Controls.Add(this.RBActor);
            this.Controls.Add(this.RBTV);
            this.Controls.Add(this.RBMovie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SelectionScreen";
            this.Size = new System.Drawing.Size(640, 676);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private RadioButton RBMovie;
        private RadioButton RBTV;
        private RadioButton RBActor;
        private RadioButton RBWriter;
        private RadioButton RBDirector;
    }
}
