namespace PrintPDF
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrinter = new System.Windows.Forms.TextBox();
            this.txtPDFFileLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsePdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(96, 157);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 38);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Printer Name:";
            // 
            // txtPrinter
            // 
            this.txtPrinter.Location = new System.Drawing.Point(96, 102);
            this.txtPrinter.Name = "txtPrinter";
            this.txtPrinter.Size = new System.Drawing.Size(309, 20);
            this.txtPrinter.TabIndex = 2;
            this.txtPrinter.Text = "Brother DCP-L2540DW series Printer";
            // 
            // txtPDFFileLocation
            // 
            this.txtPDFFileLocation.Location = new System.Drawing.Point(94, 24);
            this.txtPDFFileLocation.Multiline = true;
            this.txtPDFFileLocation.Name = "txtPDFFileLocation";
            this.txtPDFFileLocation.Size = new System.Drawing.Size(310, 55);
            this.txtPDFFileLocation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PDF File:";
            // 
            // btnBrowsePdf
            // 
            this.btnBrowsePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePdf.Location = new System.Drawing.Point(409, 24);
            this.btnBrowsePdf.Name = "btnBrowsePdf";
            this.btnBrowsePdf.Size = new System.Drawing.Size(30, 27);
            this.btnBrowsePdf.TabIndex = 5;
            this.btnBrowsePdf.Text = "...";
            this.btnBrowsePdf.UseVisualStyleBackColor = true;
            this.btnBrowsePdf.Click += new System.EventHandler(this.btnBrowsePdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 217);
            this.Controls.Add(this.btnBrowsePdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDFFileLocation);
            this.Controls.Add(this.txtPrinter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Ghost Script Print PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrinter;
        private System.Windows.Forms.TextBox txtPDFFileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsePdf;
    }
}

