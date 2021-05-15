
namespace Cina
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
            this.ecoBox = new System.Windows.Forms.CheckBox();
            this.artificiiBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ecoBox
            // 
            this.ecoBox.AutoSize = true;
            this.ecoBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoBox.Location = new System.Drawing.Point(49, 133);
            this.ecoBox.Name = "ecoBox";
            this.ecoBox.Size = new System.Drawing.Size(118, 25);
            this.ecoBox.TabIndex = 0;
            this.ecoBox.Text = "Optiuni Eco";
            this.ecoBox.UseVisualStyleBackColor = true;
            this.ecoBox.CheckedChanged += new System.EventHandler(this.ecoBox_CheckedChanged);
            // 
            // artificiiBox
            // 
            this.artificiiBox.AutoSize = true;
            this.artificiiBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artificiiBox.Location = new System.Drawing.Point(49, 101);
            this.artificiiBox.Name = "artificiiBox";
            this.artificiiBox.Size = new System.Drawing.Size(158, 25);
            this.artificiiBox.TabIndex = 0;
            this.artificiiBox.Text = "Decoratii artificii";
            this.artificiiBox.UseVisualStyleBackColor = true;
            this.artificiiBox.CheckedChanged += new System.EventHandler(this.artificiiBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(134, 174);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(59, 23);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(49, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(199, 29);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numar de persoane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost final";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(49, 212);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(59, 23);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 313);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.artificiiBox);
            this.Controls.Add(this.ecoBox);
            this.Name = "Form1";
            this.Text = "Planificator Petreceri";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ecoBox;
        private System.Windows.Forms.CheckBox artificiiBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
    }
}

