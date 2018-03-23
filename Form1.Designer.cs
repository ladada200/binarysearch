namespace BinarySearch
{
    partial class frmBinSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.nudNVal = new System.Windows.Forms.NumericUpDown();
            this.nudXVal = new System.Windows.Forms.NumericUpDown();
            this.lstBoxTree = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(260, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Tree";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nudNVal
            // 
            this.nudNVal.Location = new System.Drawing.Point(59, 13);
            this.nudNVal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudNVal.Name = "nudNVal";
            this.nudNVal.Size = new System.Drawing.Size(195, 20);
            this.nudNVal.TabIndex = 0;
            // 
            // nudXVal
            // 
            this.nudXVal.Location = new System.Drawing.Point(59, 40);
            this.nudXVal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudXVal.Name = "nudXVal";
            this.nudXVal.Size = new System.Drawing.Size(195, 20);
            this.nudXVal.TabIndex = 1;
            // 
            // lstBoxTree
            // 
            this.lstBoxTree.FormattingEnabled = true;
            this.lstBoxTree.Location = new System.Drawing.Point(13, 67);
            this.lstBoxTree.Name = "lstBoxTree";
            this.lstBoxTree.Size = new System.Drawing.Size(602, 225);
            this.lstBoxTree.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value:";
            // 
            // frmBinSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxTree);
            this.Controls.Add(this.nudXVal);
            this.Controls.Add(this.nudNVal);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmBinSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Search | Christopher Rupert";
            this.Load += new System.EventHandler(this.frmBinSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudNVal;
        private System.Windows.Forms.NumericUpDown nudXVal;
        private System.Windows.Forms.ListBox lstBoxTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

