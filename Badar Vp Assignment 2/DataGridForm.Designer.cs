namespace LoginAndDataGridApp
{
    partial class DataGridForm
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
            dataGridViewCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(118, 123);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.Size = new Size(544, 177);
            dataGridViewCourses.TabIndex = 0;
            dataGridViewCourses.CellContentClick += dataGridViewCourses_CellContentClick;
            // 
            // DataGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCourses);
            Name = "DataGridForm";
            Text = "Hasaan Azeem";
            Load += DataGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCourses;
    }
}
