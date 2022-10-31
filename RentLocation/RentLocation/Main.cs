using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RentLocation.Types.Commons;
using RentLocation.Views.Building;

namespace RentLocation
{
    public partial class MainForm : Form
    {
        public List<Building> buildings;
        public List<Appartment> appartments;
        public List<Tenant> tenants;

        public MainForm()
        {
            InitializeComponent();
            buildings = new List<Building>();
            appartments = new List<Appartment>();
            tenants = new List<Tenant>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Mts_quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Do you realy want to leave?", 
                "Quit?",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
            );

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Mts_window_arrangement_cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void Mts_window_arrangement_icon_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void Mts_window_arrangement_horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Mts_window_arrangement_vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Mts_building_form_Click(object sender, EventArgs e)
        {
            BuildingForm buildingForm = new BuildingForm(this);
            buildingForm.MdiParent = this;
            buildingForm.Show();
        }

        private void Mts_building_list_Click(object sender, EventArgs e)
        {
            BuildingList buildingList = new BuildingList(this);
            buildingList.MdiParent = this;
            buildingList.Show();
        }
    }
}
