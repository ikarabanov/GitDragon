﻿namespace RpgEditor
{
    partial class FormShieldDetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbAllowedClasses = new System.Windows.Forms.ListBox();
            this.btnRemoveAllowed = new System.Windows.Forms.Button();
            this.btnMoveAllowed = new System.Windows.Forms.Button();
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbDefenseModifier = new System.Windows.Forms.MaskedTextBox();
            this.mtbDefenseValue = new System.Windows.Forms.MaskedTextBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.mtbPrice = new System.Windows.Forms.MaskedTextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(421, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(318, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 69;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Allowed Classes:";
            // 
            // lbAllowedClasses
            // 
            this.lbAllowedClasses.FormattingEnabled = true;
            this.lbAllowedClasses.Location = new System.Drawing.Point(449, 72);
            this.lbAllowedClasses.Name = "lbAllowedClasses";
            this.lbAllowedClasses.Size = new System.Drawing.Size(120, 199);
            this.lbAllowedClasses.TabIndex = 67;
            // 
            // btnRemoveAllowed
            // 
            this.btnRemoveAllowed.Location = new System.Drawing.Point(366, 169);
            this.btnRemoveAllowed.Name = "btnRemoveAllowed";
            this.btnRemoveAllowed.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllowed.TabIndex = 66;
            this.btnRemoveAllowed.Text = "<<";
            this.btnRemoveAllowed.UseVisualStyleBackColor = true;
            // 
            // btnMoveAllowed
            // 
            this.btnMoveAllowed.Location = new System.Drawing.Point(366, 126);
            this.btnMoveAllowed.Name = "btnMoveAllowed";
            this.btnMoveAllowed.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAllowed.TabIndex = 65;
            this.btnMoveAllowed.Text = ">>";
            this.btnMoveAllowed.UseVisualStyleBackColor = true;
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.Location = new System.Drawing.Point(245, 72);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.Size = new System.Drawing.Size(115, 199);
            this.lbClasses.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Character Classes:";
            // 
            // mtbDefenseModifier
            // 
            this.mtbDefenseModifier.Location = new System.Drawing.Point(119, 221);
            this.mtbDefenseModifier.Mask = "000";
            this.mtbDefenseModifier.Name = "mtbDefenseModifier";
            this.mtbDefenseModifier.Size = new System.Drawing.Size(100, 20);
            this.mtbDefenseModifier.TabIndex = 61;
            // 
            // mtbDefenseValue
            // 
            this.mtbDefenseValue.Location = new System.Drawing.Point(119, 193);
            this.mtbDefenseValue.Mask = "000";
            this.mtbDefenseValue.Name = "mtbDefenseValue";
            this.mtbDefenseValue.Size = new System.Drawing.Size(100, 20);
            this.mtbDefenseValue.TabIndex = 62;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Location = new System.Drawing.Point(119, 140);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 20);
            this.nudWeight.TabIndex = 59;
            // 
            // mtbPrice
            // 
            this.mtbPrice.Location = new System.Drawing.Point(119, 106);
            this.mtbPrice.Mask = "00000";
            this.mtbPrice.Name = "mtbPrice";
            this.mtbPrice.Size = new System.Drawing.Size(100, 20);
            this.mtbPrice.TabIndex = 58;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(119, 72);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 20);
            this.tbType.TabIndex = 57;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Defense Modifier:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Defense Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name:";
            // 
            // FormShieldDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbAllowedClasses);
            this.Controls.Add(this.btnRemoveAllowed);
            this.Controls.Add(this.btnMoveAllowed);
            this.Controls.Add(this.lbClasses);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtbDefenseModifier);
            this.Controls.Add(this.mtbDefenseValue);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.mtbPrice);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormShieldDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shield Details";
            this.Load += new System.EventHandler(this.FormShieldDetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbAllowedClasses;
        private System.Windows.Forms.Button btnRemoveAllowed;
        private System.Windows.Forms.Button btnMoveAllowed;
        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbDefenseModifier;
        private System.Windows.Forms.MaskedTextBox mtbDefenseValue;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.MaskedTextBox mtbPrice;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}