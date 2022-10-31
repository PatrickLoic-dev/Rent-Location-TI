using RentLocation.Types.Commons;
using System;
using System.Collections.Generic;

namespace RentLocation.Dal
{
    public class BuildingDal
    {
        public MainForm Parent;
        public BuildingDal (MainForm mainForm)
        {
            this.Parent = mainForm;
        }

        // Buildings
        public List<Building> GetBuildings()
        {
            return this.Parent.buildings;
        }

        public void AddBuilding(Building building) 
        {
            this.Parent.buildings.Add(building);
        }

        /**
         * DAL to find Building by ID
         * @param int Id
         * @return Bulding building
         * */
        public Building FindById(int Id)
        {
            List<Building> buildings = GetBuildings();
            return buildings.Find(delegate (Building item)
            {
                return item.Id == Id;
            });
        }

        public Building Update(Building building)
        {
            int BuildingIndex = Parent.buildings.FindIndex(delegate (Building item)
           {
               return item.Id == building.Id;
           });

            if(BuildingIndex >= 0)
            {
                Parent.buildings[BuildingIndex] = building;
                return building;
            }
            else
            {
                throw new Exception("Objet Buildind non existant!");
            }
        }

        public int Delete(int Id)
        {
            int BuildingIndex = Parent.buildings.FindIndex(delegate (Building building)
            {
                return building.Id == Id;
            });

            if(BuildingIndex >= 0)
            {
                Parent.buildings.RemoveAt(BuildingIndex);
                return BuildingIndex;
            }
            else
            {
                throw new Exception("Objet Buildind non existant!", new KeyNotFoundException("Objet non existant dans la collection"));
            }
        }

        public List<Building> FindAllByName(String Name)
        {
            return Parent.buildings.FindAll(delegate (Building Item)
            {
                return Item.Name.ToLower().Contains(Name.ToLower());
            });
        }

        public Building FindByName(String Name)
        {
            return Parent.buildings.Find(delegate (Building Item)
            {
                return Item.Name == Name;
            });
        }
    }
}
