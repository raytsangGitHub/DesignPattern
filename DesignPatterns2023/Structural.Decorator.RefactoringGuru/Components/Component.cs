﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator.RefactoringGuru.Components
{
    // The base Component interface defines operations that can be altered by
    // decorators.
    public abstract class Component
    {
        public abstract string Operation();
        public virtual string WriteOperation() 
        { 
            return "Write data."; 
        }
    }
}
