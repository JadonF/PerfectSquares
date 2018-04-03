namespace PerfectSquares
{
    partial class PerfectSquares
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
            this.btnStart = new System.Windows.Forms.Button();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.lstPerfectSquaresList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(151, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Location = new System.Drawing.Point(151, 76);
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(120, 20);
            this.nudMaxValue.TabIndex = 1;
            // 
            // lstPerfectSquaresList
            // 
            this.lstPerfectSquaresList.FormattingEnabled = true;
            this.lstPerfectSquaresList.Location = new System.Drawing.Point(99, 129);
            this.lstPerfectSquaresList.Name = "lstPerfectSquaresList";
            this.lstPerfectSquaresList.Size = new System.Drawing.Size(216, 95);
            this.lstPerfectSquaresList.TabIndex = 2;
            // 
            // PerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 280);
            this.Controls.Add(this.lstPerfectSquaresList);
            this.Controls.Add(this.nudMaxValue);
            this.Controls.Add(this.btnStart);
            this.Name = "PerfectSquares";
            this.Text = "Perfect Squares";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.ListBox lstPerfectSquaresList;
    }
}

