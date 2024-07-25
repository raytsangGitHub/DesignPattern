using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepAndShallowCopy
{
    public class AutoModel
    {
        IShallowCopyUtil _shallowCopyUtil = null!;
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public Address DealerAddress { get; set; }  //new idea

        public AutoModel()
        {

        }

        public AutoModel GetShallowClone()
        {
            return (AutoModel)this.MemberwiseClone();  //casting the return type
            //_shallowCopyUtil = new ShallowCopyUtil();
            //return _shallowCopyUtil.GetShallowClone(this); //casting the return type 
        }

        public AutoModel GetDeepClone()
        {
            //copy both local properties and properties in other object
            AutoModel auto =(AutoModel)this.MemberwiseClone();  //copy local properties
            //assign local property DealerAddress by calling DealerAddress.GetClone() - a shallow copy
            auto.DealerAddress = DealerAddress.GetClone();
            return auto;
        }

    }
}
