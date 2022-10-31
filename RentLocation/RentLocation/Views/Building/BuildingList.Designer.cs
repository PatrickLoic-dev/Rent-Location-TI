namespace RentLocation.Views.Building
{
    partial class BuildingList
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
            this.BuildingFilterInput = new System.Windows.Forms.TextBox();
            this.RefreshBuildingList_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuldingListView = new System.Windows.Forms.DataGridView();
            this.UpdateBuilding_btn = new System.Windows.Forms.Button();
            this.DeleteBuilding_btn = new System.Windows.Forms.Button();
            this.PrintBuilding_btn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbApparts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuldingListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUILDINGS";
            // 
            // BuildingFilterInput
            // 
            this.BuildingFilterInput.Location = new System.Drawing.Point(42, 116);
            this.BuildingFilterInput.Name = "BuildingFilterInput";
            this.BuildingFilterInput.Size = new System.Drawing.Size(1363, 31);
            this.BuildingFilterInput.TabIndex = 2;
            this.BuildingFilterInput.TextChanged += new System.EventHandler(this.FilterHandle);
            // 
            // RefreshBuildingList_btn
            // 
            this.RefreshBuildingList_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RefreshBuildingList_btn.Location = new System.Drawing.Point(42, 182);
            this.RefreshBuildingList_btn.Name = "RefreshBuildingList_btn";
            this.RefreshBuildingList_btn.Size = new System.Drawing.Size(286, 47);
            this.RefreshBuildingList_btn.TabIndex = 3;
            this.RefreshBuildingList_btn.Text = "Refresh";
            this.RefreshBuildingList_btn.UseVisualStyleBackColor = true;
            this.RefreshBuildingList_btn.Click += new System.EventHandler(this.RefreshBuildingList_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BuldingListView);
            this.panel1.Location = new System.Drawing.Point(42, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 733);
            this.panel1.TabIndex = 4;
            // 
            // BuldingListView
            // 
            this.BuldingListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BuldingListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BuldingListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuldingListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.location,
            this.nbApparts,
            this.action});
            this.BuldingListView.Location = new System.Drawing.Point(0, 0);
            this.BuldingListView.Name = "BuldingListView";
            this.BuldingListView.RowTemplate.Height = 33;
            this.BuldingListView.Size = new System.Drawing.Size(1363, 733);
            this.BuldingListView.TabIndex = 0;
            // 
            // UpdateBuilding_btn
            // 
            this.UpdateBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateBuilding_btn.Location = new System.Drawing.Point(349, 182);
            this.UpdateBuilding_btn.Name = "UpdateBuilding_btn";
            this.UpdateBuilding_btn.Size = new System.Drawing.Size(310, 47);
            this.UpdateBuilding_btn.TabIndex = 5;
            this.UpdateBuilding_btn.Text = "Update";
            this.UpdateBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteBuilding_btn
            // 
            this.DeleteBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBuilding_btn.Location = new System.Drawing.Point(677, 182);
            this.DeleteBuilding_btn.Name = "DeleteBuilding_btn";
            this.DeleteBuilding_btn.Size = new System.Drawing.Size(357, 47);
            this.DeleteBuilding_btn.TabIndex = 6;
            this.DeleteBuilding_btn.Text = "Delete";
            this.DeleteBuilding_btn.UseVisualStyleBackColor = true;
            this.DeleteBuilding_btn.Click += new System.EventHandler(this.DeleteBuilding_btn_Click);
            // 
            // PrintBuilding_btn
            // 
            this.PrintBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrintBuilding_btn.Location = new System.Drawing.Point(1053, 182);
            this.PrintBuilding_btn.Name = "PrintBuilding_btn";
            this.PrintBuilding_btn.Size = new System.Drawing.Size(352, 47);
            this.PrintBuilding_btn.TabIndex = 7;
            this.PrintBuilding_btn.Text = "Print";
            this.PrintBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // nbApparts
            // 
            this.nbApparts.HeaderText = "Rooms";
            this.nbApparts.Name = "nbApparts";
            this.nbApparts.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            // 
            // BuildingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 1006);
            this.Controls.Add(this.PrintBuilding_btn);
            this.Controls.Add(this.DeleteBuilding_btn);
            this.Controls.Add(this.UpdateBuilding_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefreshBuildingList_btn);
            this.Controls.Add(this.BuildingFilterInput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BuildingList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuildingList";
            this.Load += new System.EventHandler(this.BuildingList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuldingListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuildingFilterInput;
        private System.Windows.Forms.Button RefreshBuildingList_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BuldingListView;
        private System.Windows.Forms.Button UpdateBuilding_btn;
        private System.Windows.Forms.Button DeleteBuilding_btn;
        private System.Windows.Forms.Button PrintBuilding_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbApparts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn action;
    }
}