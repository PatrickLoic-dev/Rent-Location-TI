using System;

namespace RentLocation.Types.Commons
{
    public class Appartment
    {
        public int Id;
        public String Name;
        public String Number;
        public float Price;
        public Building Building;
        public Tenant Tenant;

        public static int INC_ID;

        public Appartment(String Name, String Number, float Price, Building Building)
        {
            this.Name = Name;
            this.Number = Number;
            this.Price = Price;
            this.Building = Building;
            this.Id = ++INC_ID;
        }

        public void SetTenant(Tenant tenant)
        {
            this.Tenant = tenant;
        }
    }
}
