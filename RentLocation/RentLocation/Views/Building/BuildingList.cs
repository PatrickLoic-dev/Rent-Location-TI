using RentLocation.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentLocation.Views.Building
{
    public partial class BuildingList : Form
    {
        BuildingController buildingController;
        public BuildingList()
        {
            InitializeComponent();
        }

        public BuildingList(MainForm Parent)
        {
            buildingController = new BuildingController(Parent);
            InitializeComponent();
        }

        private void BuildingList_Load(object sender, EventArgs e)
        {
            LoadBuildings();
        }

        public void LoadBuildings()
        {
            List<RentLocation.Types.Commons.Building> buildings = buildingController.FindAll();
            PopulateBuildingListView(buildings);
        }

        public void PopulateBuildingListView(List<RentLocation.Types.Commons.Building> buildings)
        {
            BuldingListView.Rows.Clear();
            buildings.ForEach(delegate (RentLocation.Types.Commons.Building item) {
                BuldingListView.Rows.Add(item.Id, item.Name, item.Location, item.NbApparts, false);
            });
        }

        public void RefreshBuildingList_btn_Click(object sender, EventArgs e)
        {
            LoadBuildings();
        }

        public void FilterHandle(object sender, EventArgs e)
        {
            String FilterKey = BuildingFilterInput.Text;
            if(FilterKey.Length > 0)
            {
                List<RentLocation.Types.Commons.Building> buildings = buildingController.FilterByName(FilterKey);
                PopulateBuildingListView(buildings);
            }
            else
            {
                LoadBuildings();
            }
        }

        public int RowsCountListSelected()
        {
            int RowsSelected = 0;
            try
            {
                for(int i = 0; i < BuldingListView.Rows.Count; i++)
                {
                    int cellsCount = BuldingListView.Rows[i].Cells.Count;
                    if ( (bool) BuldingListView.Rows[i].Cells[cellsCount - 1].Value == true)
                    {
                        RowsSelected++;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RowsSelected;
        }

        public int GetBuildingIdFromRowList()
        {
            int Id = 0;
            int RowSelected = RowsCountListSelected();
            if (RowSelected == 1)
            {
                for (int i = 0; i < BuldingListView.Rows.Count - 1; i++)
                {
                    int cellsCount = BuldingListView.Rows[i].Cells.Count - 1;
                    if (
                        BuldingListView.Rows[i].Cells[cellsCount] != null &&
                        (bool)BuldingListView.Rows[i].Cells[cellsCount].Value == true
                        )
                    {
                        Id = (int)BuldingListView.Rows[i].Cells[0].Value;
                    }
                }
            }else if(RowSelected > 1)
            {
                MessageBox.Show("You have to select only one item from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RowSelected < 1)
            {
                MessageBox.Show("You have to select an item from the list to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Id;
        }

        private void DeleteBuilding_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = GetBuildingIdFromRowList();
                if(Id > 0)
                {
                    DialogResult CanDelete = MessageBox.Show("Do you really want to delete this item?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(CanDelete == DialogResult.Yes)
                    {
                        buildingController.Delete(Id);
                        MessageBox.Show("Item deleted!");
                        LoadBuildings();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
