﻿using Structural.Bridge.RefactoringGuru.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge.RefactoringGuru.Abstractions
{
    public class Abstraction
    {
        protected IImplementation _implementation;
        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Absract: Base operation with : \n" + _implementation.OperationImplementation();
        }
    }
}
