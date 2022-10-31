using System;
using System.Drawing;

namespace RentLocation.Types.Commons
{
    public class Tenant
    {
        public int Id;
        public String Firstname;
        public String Lastname;
        public String PhoneNumber;
        public String Email;
        public Image Avatar;
        public Appartment Appartment;

        public static int INC_ID;

        public Tenant(String Firstname, String Lastname, String PhoneNumber, String Email)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Id = ++INC_ID;
        }

        public void SetImage(Image Avatar)
        {
            this.Avatar = Avatar;
        }

        public void SetAppartment(Appartment appartment)
        {
            this.Appartment = appartment;
        }
    }
}
