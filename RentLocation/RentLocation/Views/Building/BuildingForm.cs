using RentLocation.Controller;
using System;
using System.Windows.Forms;

namespace RentLocation.Views.Building
{
    public partial class BuildingForm : Form
    {
        BuildingController buildingController;
        public BuildingForm(MainForm Parent)
        {
            buildingController = new BuildingController(Parent);
            InitializeComponent();
        }

        public BuildingForm()
        {
            InitializeComponent();
        }

        private void SubmitBuildingForm_btn_Click(object sender, EventArgs e)
        {
            RentLocation.Types.Commons.Building CreatedBuilding = buildingController.Save(Name_txt.Text, Location_txt.Text, int.Parse(NbApparts_txt.Text));
            if(CreatedBuilding != null)
            {
                ClearForm();
                MessageBox.Show($"Building ({CreatedBuilding.Name}) created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error when creating Building ({CreatedBuilding.Name}), try again please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            Name_txt.Text = "";
            Location_txt.Text = "";
            NbApparts_txt.Text = "";
        }
    }
}
