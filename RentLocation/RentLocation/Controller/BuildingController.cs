using RentLocation.Service;
using RentLocation.Types.Commons;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentLocation.Controller
{
    class BuildingController
    {
        public BuildingService buildingService;

        public BuildingController(MainForm parent)
        {
            this.buildingService = new BuildingService(parent);
        }

        public Building Save(String Name, String Location, int NbApparts)
        {
            try
            {
                Building building = new Building(Name, Location, NbApparts);
                buildingService.Save(building);
                return building;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Building> FindAll()
        {
            return buildingService.FindAll();
        }

        public Building FindByName(String name)
        {
            return buildingService.FindByName(name);
        }

        public List<Building> FilterByName(String name)
        {
            return buildingService.Filter(name);
        }

        public int Delete(int id)
        {
            return buildingService.Delete(id);
        }
    }
}
