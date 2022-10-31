using RentLocation.Types.Commons;
using System.Collections.Generic;

namespace RentLocation.Dal
{
    public class TenantDal
    {
        public MainForm Parent;

        public TenantDal(MainForm mainForm)
        {
            this.Parent = mainForm;
        }

        //Tenant
        public List<Tenant> GetTenants()
        {
            return this.Parent.tenants;
        }

        public void AddTenant(Tenant tenant)
        {
            this.Parent.tenants.Add(tenant);
        }
    }
}
