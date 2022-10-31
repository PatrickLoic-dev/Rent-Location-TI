using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentLocation.Dal;
using RentLocation.Types.Commons;

namespace RentLocation.Service
{
    public class BuildingService
    {
        public BuildingDal buildingDal;

        public BuildingService(MainForm parent)
        {
            this.buildingDal = new BuildingDal(parent);
        }

        public void Save(Building building)
        {
            // verifier si le building existe
            if (!Exists(building.Name))
            {
                // creer le building
                this.buildingDal.AddBuilding(building);
            }
            else
            {
                throw new Exception("Le building que vous voulez creer existe deja!");
            }
        }
        
        public bool Exists(String BuildingName)
        {
            List<Building> buildings = buildingDal.GetBuildings();
            List<Building> FoundBuildings = buildings.FindAll(delegate (Building item)
            {
                return item.Name == BuildingName;
            });
            return FoundBuildings.Count > 0 ? true : false;
        }

        public Building Update(Building building)
        {
            // Verifier (par son ID) que le building quon veut modifier existe
            Building ExistBuilding = this.buildingDal.FindById(building.Id);
            if (!ExistBuilding.IsNull())
            {
                ExistBuilding.Name = building.Name;
                ExistBuilding.Location = building.Location;
                ExistBuilding.NbApparts = building.NbApparts;
                // Sauvegarder
                return buildingDal.Update(ExistBuilding);
            }
            else
            {
                throw new Exception("Building non existant!");
            }
        }

        public int Delete(int Id)
        {
            Building BuildingToDelete = buildingDal.FindById(Id);
            if (!BuildingToDelete.IsNull())
            {
                // supprimer le building
                return buildingDal.Delete(Id);
            }
            else
            {
                throw new Exception("Le building que vous voulez supprimer n'existe pas!");
            }
        }

        public List<Building> Filter(String Name)
        {
            return buildingDal.FindAllByName(Name);
        }

        public Building FindByName(String Name)
        {
            return buildingDal.FindByName(Name);
        }

        public List<Building> FindAll()
        {
            return buildingDal.GetBuildings();
        }
    }
}
