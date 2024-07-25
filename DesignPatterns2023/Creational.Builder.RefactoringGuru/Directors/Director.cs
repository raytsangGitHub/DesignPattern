using Creational.Builder.RefactoringGuru.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.RefactoringGuru.Directors
{
    public class Director
    {
        //associate director to builder
        private IBuilder _builder;

        //property
        public IBuilder Builder
        { 
            set {  _builder=value; } 

        }

        //ctor 
        public Director(IBuilder _builder)
        { 
            this._builder=_builder;
        }
        //methods for order of building products 
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
