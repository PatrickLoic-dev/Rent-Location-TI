using System;

namespace RentLocation.Types.Commons
{
    public class Building
    {
        public int Id;
        public String Name;
        public String Location;
        public int NbApparts;

        public static int INC_ID;

        public Building(String Name, String Location, int NbApparts)
        {
            this.Name = Name;
            this.Location = Location;
            this.NbApparts = NbApparts;
            this.Id = ++INC_ID;
        }

        public bool IsNull()
        {
            return this == null;
        }
    }
}
