using RentLocation.Types.Commons;
using System.Collections.Generic;

namespace RentLocation.Dal
{
    public class AppartmentDal
    {
        public MainForm Parent;

        public AppartmentDal (MainForm mainForm)
        {
            this.Parent = mainForm;
        }

        //Appartment
        public List<Appartment> GetAppartments()
        {
            return this.Parent.appartments;
        }

        public void AddAppatrment(Appartment appartment)
        {
            this.Parent.appartments.Add(appartment);
        }
    }
}
