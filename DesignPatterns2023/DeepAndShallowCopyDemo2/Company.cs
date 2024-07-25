using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepAndShallowCopyDemo2
{
    public class Company
    {
        public int GBRank;
        public CompanyDescription desc;

        public Company(int gbRank, string c, string o)
        {
            this.GBRank = gbRank;
            desc = new CompanyDescription(c, o);  //composition 
        }

        // method for cloning object
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

        // method for cloning object
        public Company DeepCopy()
        {
            Company deepcopyCompany = new Company(this.GBRank,
                               desc.CompanyName, desc.Owner);

            return deepcopyCompany;
        }
    }
}
