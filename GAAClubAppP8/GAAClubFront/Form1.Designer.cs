namespace GAAClubFront
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbDist = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonSummary = new System.Windows.Forms.Button();
            this.dgvGaa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NameError = new System.Windows.Forms.Label();
            this.AgeError = new System.Windows.Forms.Label();
            this.HeightError = new System.Windows.Forms.Label();
            this.DistError = new System.Windows.Forms.Label();
            this.SpeedError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player Running Distance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Player Speed";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(146, 205);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(146, 237);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(146, 267);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 8;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(146, 296);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 9;
            // 
            // tbDist
            // 
            this.tbDist.Location = new System.Drawing.Point(146, 326);
            this.tbDist.Name = "tbDist";
            this.tbDist.Size = new System.Drawing.Size(100, 20);
            this.tbDist.TabIndex = 10;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(146, 355);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbSpeed.TabIndex = 11;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(15, 390);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(96, 390);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 13;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonSummary
            // 
            this.ButtonSummary.Location = new System.Drawing.Point(372, 208);
            this.ButtonSummary.Name = "ButtonSummary";
            this.ButtonSummary.Size = new System.Drawing.Size(142, 23);
            this.ButtonSummary.TabIndex = 15;
            this.ButtonSummary.Text = "Refresh Summary";
            this.ButtonSummary.UseVisualStyleBackColor = true;
            this.ButtonSummary.Click += new System.EventHandler(this.ButtonSummary_Click);
            // 
            // dgvGaa
            // 
            this.dgvGaa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGaa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvGaa.Location = new System.Drawing.Point(15, 24);
            this.dgvGaa.Name = "dgvGaa";
            this.dgvGaa.Size = new System.Drawing.Size(666, 163);
            this.dgvGaa.TabIndex = 16;
            this.dgvGaa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGaa_CellContentClick);
            this.dgvGaa.SelectionChanged += new System.EventHandler(this.dgvGaa_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Player ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Height";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Run Distance";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Speed";
            this.Column6.Name = "Column6";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(372, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 173);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.Location = new System.Drawing.Point(258, 239);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(35, 13);
            this.NameError.TabIndex = 19;
            this.NameError.Text = "label7";
            // 
            // AgeError
            // 
            this.AgeError.AutoSize = true;
            this.AgeError.Location = new System.Drawing.Point(258, 270);
            this.AgeError.Name = "AgeError";
            this.AgeError.Size = new System.Drawing.Size(35, 13);
            this.AgeError.TabIndex = 20;
            this.AgeError.Text = "label8";
            // 
            // HeightError
            // 
            this.HeightError.AutoSize = true;
            this.HeightError.Location = new System.Drawing.Point(258, 296);
            this.HeightError.Name = "HeightError";
            this.HeightError.Size = new System.Drawing.Size(35, 13);
            this.HeightError.TabIndex = 21;
            this.HeightError.Text = "label9";
            this.HeightError.Click += new System.EventHandler(this.label9_Click);
            // 
            // DistError
            // 
            this.DistError.AutoSize = true;
            this.DistError.Location = new System.Drawing.Point(258, 326);
            this.DistError.Name = "DistError";
            this.DistError.Size = new System.Drawing.Size(41, 13);
            this.DistError.TabIndex = 22;
            this.DistError.Text = "label10";
            // 
            // SpeedError
            // 
            this.SpeedError.AutoSize = true;
            this.SpeedError.Location = new System.Drawing.Point(258, 358);
            this.SpeedError.Name = "SpeedError";
            this.SpeedError.Size = new System.Drawing.Size(41, 13);
            this.SpeedError.TabIndex = 23;
            this.SpeedError.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 425);
            this.Controls.Add(this.SpeedError);
            this.Controls.Add(this.DistError);
            this.Controls.Add(this.HeightError);
            this.Controls.Add(this.AgeError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvGaa);
            this.Controls.Add(this.ButtonSummary);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbDist);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GAAFrontEnd";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbDist;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonSummary;
        private System.Windows.Forms.DataGridView dgvGaa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label AgeError;
        private System.Windows.Forms.Label HeightError;
        private System.Windows.Forms.Label DistError;
        private System.Windows.Forms.Label SpeedError;
    }
}

