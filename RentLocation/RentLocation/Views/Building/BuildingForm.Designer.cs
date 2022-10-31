namespace RentLocation.Views.Building
{
    partial class BuildingForm
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
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NbApparts_txt = new System.Windows.Forms.TextBox();
            this.SubmitBuildingForm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW BUILDING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(92, 211);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(599, 31);
            this.Name_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // Location_txt
            // 
            this.Location_txt.Location = new System.Drawing.Point(92, 330);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(599, 31);
            this.Location_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total room";
            // 
            // NbApparts_txt
            // 
            this.NbApparts_txt.Location = new System.Drawing.Point(92, 475);
            this.NbApparts_txt.Name = "NbApparts_txt";
            this.NbApparts_txt.Size = new System.Drawing.Size(599, 31);
            this.NbApparts_txt.TabIndex = 6;
            // 
            // SubmitBuildingForm_btn
            // 
            this.SubmitBuildingForm_btn.Location = new System.Drawing.Point(425, 569);
            this.SubmitBuildingForm_btn.Name = "SubmitBuildingForm_btn";
            this.SubmitBuildingForm_btn.Size = new System.Drawing.Size(265, 69);
            this.SubmitBuildingForm_btn.TabIndex = 7;
            this.SubmitBuildingForm_btn.Text = "Submit";
            this.SubmitBuildingForm_btn.UseVisualStyleBackColor = true;
            this.SubmitBuildingForm_btn.Click += new System.EventHandler(this.SubmitBuildingForm_btn_Click);
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 714);
            this.Controls.Add(this.SubmitBuildingForm_btn);
            this.Controls.Add(this.NbApparts_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "BuildingForm";
            this.ShowIcon = false;
            this.Text = "New Building";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NbApparts_txt;
        private System.Windows.Forms.Button SubmitBuildingForm_btn;
    }
}