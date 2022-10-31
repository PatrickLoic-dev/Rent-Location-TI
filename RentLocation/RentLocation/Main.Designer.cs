namespace RentLocation
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_new = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_building = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_building_form = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_building_list = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_appart = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_appart_form = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_appart_list = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_tenant = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_tenant_form = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_tenant_list = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_window = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_window_arrangement = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_window_arrangement_cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_window_arrangement_icon = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_window_arrangement_horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.Mts_window_arrangement_vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Mts_window});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_new,
            this.Mts_quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Mts_new
            // 
            this.Mts_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_building,
            this.Mts_appart,
            this.Mts_tenant});
            this.Mts_new.Name = "Mts_new";
            this.Mts_new.Size = new System.Drawing.Size(268, 38);
            this.Mts_new.Text = "New";
            // 
            // Mts_building
            // 
            this.Mts_building.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_building_form,
            this.Mts_building_list});
            this.Mts_building.Name = "Mts_building";
            this.Mts_building.Size = new System.Drawing.Size(268, 38);
            this.Mts_building.Text = "Building";
            // 
            // Mts_building_form
            // 
            this.Mts_building_form.Name = "Mts_building_form";
            this.Mts_building_form.Size = new System.Drawing.Size(268, 38);
            this.Mts_building_form.Text = "Form";
            this.Mts_building_form.Click += new System.EventHandler(this.Mts_building_form_Click);
            // 
            // Mts_building_list
            // 
            this.Mts_building_list.Name = "Mts_building_list";
            this.Mts_building_list.Size = new System.Drawing.Size(268, 38);
            this.Mts_building_list.Text = "List";
            this.Mts_building_list.Click += new System.EventHandler(this.Mts_building_list_Click);
            // 
            // Mts_appart
            // 
            this.Mts_appart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_appart_form,
            this.Mts_appart_list});
            this.Mts_appart.Name = "Mts_appart";
            this.Mts_appart.Size = new System.Drawing.Size(268, 38);
            this.Mts_appart.Text = "Appartment";
            // 
            // Mts_appart_form
            // 
            this.Mts_appart_form.Name = "Mts_appart_form";
            this.Mts_appart_form.Size = new System.Drawing.Size(169, 38);
            this.Mts_appart_form.Text = "Form";
            // 
            // Mts_appart_list
            // 
            this.Mts_appart_list.Name = "Mts_appart_list";
            this.Mts_appart_list.Size = new System.Drawing.Size(169, 38);
            this.Mts_appart_list.Text = "List";
            // 
            // Mts_tenant
            // 
            this.Mts_tenant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_tenant_form,
            this.Mts_tenant_list});
            this.Mts_tenant.Name = "Mts_tenant";
            this.Mts_tenant.Size = new System.Drawing.Size(268, 38);
            this.Mts_tenant.Text = "Tenant";
            // 
            // Mts_tenant_form
            // 
            this.Mts_tenant_form.Name = "Mts_tenant_form";
            this.Mts_tenant_form.Size = new System.Drawing.Size(169, 38);
            this.Mts_tenant_form.Text = "Form";
            // 
            // Mts_tenant_list
            // 
            this.Mts_tenant_list.Name = "Mts_tenant_list";
            this.Mts_tenant_list.Size = new System.Drawing.Size(169, 38);
            this.Mts_tenant_list.Text = "List";
            // 
            // Mts_quit
            // 
            this.Mts_quit.Name = "Mts_quit";
            this.Mts_quit.Size = new System.Drawing.Size(268, 38);
            this.Mts_quit.Text = "Quit";
            this.Mts_quit.Click += new System.EventHandler(this.Mts_quit_Click);
            // 
            // Mts_window
            // 
            this.Mts_window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_window_arrangement});
            this.Mts_window.Name = "Mts_window";
            this.Mts_window.Size = new System.Drawing.Size(114, 38);
            this.Mts_window.Text = "Window";
            // 
            // Mts_window_arrangement
            // 
            this.Mts_window_arrangement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mts_window_arrangement_cascade,
            this.Mts_window_arrangement_icon,
            this.Mts_window_arrangement_horizontal,
            this.Mts_window_arrangement_vertical});
            this.Mts_window_arrangement.Name = "Mts_window_arrangement";
            this.Mts_window_arrangement.Size = new System.Drawing.Size(254, 38);
            this.Mts_window_arrangement.Text = "Arrangement";
            // 
            // Mts_window_arrangement_cascade
            // 
            this.Mts_window_arrangement_cascade.Name = "Mts_window_arrangement_cascade";
            this.Mts_window_arrangement_cascade.Size = new System.Drawing.Size(224, 38);
            this.Mts_window_arrangement_cascade.Text = "Cascade";
            this.Mts_window_arrangement_cascade.Click += new System.EventHandler(this.Mts_window_arrangement_cascade_Click);
            // 
            // Mts_window_arrangement_icon
            // 
            this.Mts_window_arrangement_icon.Name = "Mts_window_arrangement_icon";
            this.Mts_window_arrangement_icon.Size = new System.Drawing.Size(224, 38);
            this.Mts_window_arrangement_icon.Text = "Icon";
            this.Mts_window_arrangement_icon.Click += new System.EventHandler(this.Mts_window_arrangement_icon_Click);
            // 
            // Mts_window_arrangement_horizontal
            // 
            this.Mts_window_arrangement_horizontal.Name = "Mts_window_arrangement_horizontal";
            this.Mts_window_arrangement_horizontal.Size = new System.Drawing.Size(224, 38);
            this.Mts_window_arrangement_horizontal.Text = "Horizontal";
            this.Mts_window_arrangement_horizontal.Click += new System.EventHandler(this.Mts_window_arrangement_horizontal_Click);
            // 
            // Mts_window_arrangement_vertical
            // 
            this.Mts_window_arrangement_vertical.Name = "Mts_window_arrangement_vertical";
            this.Mts_window_arrangement_vertical.Size = new System.Drawing.Size(224, 38);
            this.Mts_window_arrangement_vertical.Text = "Vertical";
            this.Mts_window_arrangement_vertical.Click += new System.EventHandler(this.Mts_window_arrangement_vertical_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 781);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mts_new;
        private System.Windows.Forms.ToolStripMenuItem Mts_building;
        private System.Windows.Forms.ToolStripMenuItem Mts_building_form;
        private System.Windows.Forms.ToolStripMenuItem Mts_building_list;
        private System.Windows.Forms.ToolStripMenuItem Mts_appart;
        private System.Windows.Forms.ToolStripMenuItem Mts_appart_form;
        private System.Windows.Forms.ToolStripMenuItem Mts_appart_list;
        private System.Windows.Forms.ToolStripMenuItem Mts_tenant;
        private System.Windows.Forms.ToolStripMenuItem Mts_tenant_form;
        private System.Windows.Forms.ToolStripMenuItem Mts_tenant_list;
        private System.Windows.Forms.ToolStripMenuItem Mts_quit;
        private System.Windows.Forms.ToolStripMenuItem Mts_window;
        private System.Windows.Forms.ToolStripMenuItem Mts_window_arrangement;
        private System.Windows.Forms.ToolStripMenuItem Mts_window_arrangement_cascade;
        private System.Windows.Forms.ToolStripMenuItem Mts_window_arrangement_icon;
        private System.Windows.Forms.ToolStripMenuItem Mts_window_arrangement_horizontal;
        private System.Windows.Forms.ToolStripMenuItem Mts_window_arrangement_vertical;
    }
}

