namespace ComparisonSort
{
    partial class ComparisonSort
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblSorted = new System.Windows.Forms.Label();
            this.lblComparisons = new System.Windows.Forms.Label();
            this.txtComparisons = new System.Windows.Forms.TextBox();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(153, 42);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 24);
            this.txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblInput.Location = new System.Drawing.Point(23, 42);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(100, 24);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Array input";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(153, 85);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(125, 24);
            this.txtOutput.TabIndex = 2;
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSorted.Location = new System.Drawing.Point(23, 85);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(111, 24);
            this.lblSorted.TabIndex = 3;
            this.lblSorted.Text = "Array output";
            // 
            // lblComparisons
            // 
            this.lblComparisons.AutoSize = true;
            this.lblComparisons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblComparisons.Location = new System.Drawing.Point(23, 127);
            this.lblComparisons.Name = "lblComparisons";
            this.lblComparisons.Size = new System.Drawing.Size(121, 24);
            this.lblComparisons.TabIndex = 4;
            this.lblComparisons.Text = "Comparisons";
            // 
            // txtComparisons
            // 
            this.txtComparisons.Location = new System.Drawing.Point(153, 127);
            this.txtComparisons.Multiline = true;
            this.txtComparisons.Name = "txtComparisons";
            this.txtComparisons.Size = new System.Drawing.Size(125, 24);
            this.txtComparisons.TabIndex = 5;
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(114, 185);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(80, 33);
            this.btnHeapSort.TabIndex = 7;
            this.btnHeapSort.Text = "HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(114, 224);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(80, 33);
            this.btnQuickSort.TabIndex = 8;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(114, 263);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(80, 33);
            this.btnInsertionSort.TabIndex = 9;
            this.btnInsertionSort.Text = "InsertionSort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(114, 302);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(80, 33);
            this.btnMergeSort.TabIndex = 10;
            this.btnMergeSort.Text = "MergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(86, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 42);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ComparisonSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.txtComparisons);
            this.Controls.Add(this.lblComparisons);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Name = "ComparisonSort";
            this.Text = "ComparisonSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.Label lblComparisons;
        private System.Windows.Forms.TextBox txtComparisons;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnClear;
    }
}

