using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoviPokritiqProject
{
    public abstract class PodoviPokritiq : IPrint
    {
        private string productType;
        private string materialType;
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public PodoviPokritiq(string productType, string materialType)
        {
            this.productType = productType;
            this.materialType = materialType;
        }
        public virtual void Print() { }
    }
}
