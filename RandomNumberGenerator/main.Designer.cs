namespace RandomNumberGenerator
{
    partial class main
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
            this.seedLabel = new System.Windows.Forms.Label();
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.incrementLabel = new System.Windows.Forms.Label();
            this.modulusLabel = new System.Windows.Forms.Label();
            this.numberOfIterationsLabel = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.incrementTextBox = new System.Windows.Forms.TextBox();
            this.modulusTextBox = new System.Windows.Forms.TextBox();
            this.numberOfIterationsTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.randomNumbersTable = new System.Windows.Forms.DataGridView();
            this.cycleLengthLabel = new System.Windows.Forms.Label();
            this.cycleLengthTextBox = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomNumbersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.randomNumbersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.seedLabel.Location = new System.Drawing.Point(44, 20);
            this.seedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(124, 30);
            this.seedLabel.TabIndex = 0;
            this.seedLabel.Text = "Seed (X0)";
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.AutoSize = true;
            this.multiplierLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.multiplierLabel.Location = new System.Drawing.Point(44, 84);
            this.multiplierLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(114, 30);
            this.multiplierLabel.TabIndex = 1;
            this.multiplierLabel.Text = "Multiplier";
            // 
            // incrementLabel
            // 
            this.incrementLabel.AutoSize = true;
            this.incrementLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.incrementLabel.Location = new System.Drawing.Point(44, 151);
            this.incrementLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.incrementLabel.Name = "incrementLabel";
            this.incrementLabel.Size = new System.Drawing.Size(126, 30);
            this.incrementLabel.TabIndex = 2;
            this.incrementLabel.Text = "Increment";
            // 
            // modulusLabel
            // 
            this.modulusLabel.AutoSize = true;
            this.modulusLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.modulusLabel.Location = new System.Drawing.Point(44, 222);
            this.modulusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modulusLabel.Name = "modulusLabel";
            this.modulusLabel.Size = new System.Drawing.Size(105, 30);
            this.modulusLabel.TabIndex = 3;
            this.modulusLabel.Text = "Modulus";
            // 
            // numberOfIterationsLabel
            // 
            this.numberOfIterationsLabel.AutoSize = true;
            this.numberOfIterationsLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.numberOfIterationsLabel.Location = new System.Drawing.Point(44, 299);
            this.numberOfIterationsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberOfIterationsLabel.Name = "numberOfIterationsLabel";
            this.numberOfIterationsLabel.Size = new System.Drawing.Size(248, 30);
            this.numberOfIterationsLabel.TabIndex = 4;
            this.numberOfIterationsLabel.Text = "Number Of Iterations";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(326, 12);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(189, 38);
            this.seedTextBox.TabIndex = 6;
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(326, 76);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(189, 38);
            this.multiplierTextBox.TabIndex = 7;
            // 
            // incrementTextBox
            // 
            this.incrementTextBox.Location = new System.Drawing.Point(326, 143);
            this.incrementTextBox.Name = "incrementTextBox";
            this.incrementTextBox.Size = new System.Drawing.Size(189, 38);
            this.incrementTextBox.TabIndex = 8;
            // 
            // modulusTextBox
            // 
            this.modulusTextBox.Location = new System.Drawing.Point(326, 219);
            this.modulusTextBox.Name = "modulusTextBox";
            this.modulusTextBox.Size = new System.Drawing.Size(189, 38);
            this.modulusTextBox.TabIndex = 9;
            // 
            // numberOfIterationsTextBox
            // 
            this.numberOfIterationsTextBox.Location = new System.Drawing.Point(326, 291);
            this.numberOfIterationsTextBox.Name = "numberOfIterationsTextBox";
            this.numberOfIterationsTextBox.Size = new System.Drawing.Size(189, 38);
            this.numberOfIterationsTextBox.TabIndex = 10;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(49, 359);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(466, 46);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Generate Random Numbers";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // randomNumbersTable
            // 
            this.randomNumbersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randomNumbersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.randomNumbersColumn});
            this.randomNumbersTable.Location = new System.Drawing.Point(561, 12);
            this.randomNumbersTable.Name = "randomNumbersTable";
            this.randomNumbersTable.RowHeadersWidth = 51;
            this.randomNumbersTable.Size = new System.Drawing.Size(377, 462);
            this.randomNumbersTable.TabIndex = 12;
            // 
            // cycleLengthLabel
            // 
            this.cycleLengthLabel.AutoSize = true;
            this.cycleLengthLabel.Location = new System.Drawing.Point(44, 444);
            this.cycleLengthLabel.Name = "cycleLengthLabel";
            this.cycleLengthLabel.Size = new System.Drawing.Size(154, 30);
            this.cycleLengthLabel.TabIndex = 13;
            this.cycleLengthLabel.Text = "Cycle Length";
            // 
            // cycleLengthTextBox
            // 
            this.cycleLengthTextBox.Location = new System.Drawing.Point(326, 436);
            this.cycleLengthTextBox.Name = "cycleLengthTextBox";
            this.cycleLengthTextBox.ReadOnly = true;
            this.cycleLengthTextBox.Size = new System.Drawing.Size(189, 38);
            this.cycleLengthTextBox.TabIndex = 14;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 125;
            // 
            // randomNumbersColumn
            // 
            this.randomNumbersColumn.HeaderText = "Random Numbers";
            this.randomNumbersColumn.MinimumWidth = 6;
            this.randomNumbersColumn.Name = "randomNumbersColumn";
            this.randomNumbersColumn.Width = 207;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.cycleLengthTextBox);
            this.Controls.Add(this.cycleLengthLabel);
            this.Controls.Add(this.randomNumbersTable);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numberOfIterationsTextBox);
            this.Controls.Add(this.modulusTextBox);
            this.Controls.Add(this.incrementTextBox);
            this.Controls.Add(this.multiplierTextBox);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.numberOfIterationsLabel);
            this.Controls.Add(this.modulusLabel);
            this.Controls.Add(this.incrementLabel);
            this.Controls.Add(this.multiplierLabel);
            this.Controls.Add(this.seedLabel);
            this.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "main";
            this.Text = "Random Number Generator";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randomNumbersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.Label incrementLabel;
        private System.Windows.Forms.Label modulusLabel;
        private System.Windows.Forms.Label numberOfIterationsLabel;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.TextBox incrementTextBox;
        private System.Windows.Forms.TextBox modulusTextBox;
        private System.Windows.Forms.TextBox numberOfIterationsTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView randomNumbersTable;
        private System.Windows.Forms.Label cycleLengthLabel;
        private System.Windows.Forms.TextBox cycleLengthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomNumbersColumn;
    }
}

