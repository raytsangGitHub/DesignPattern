﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.RefactoringGuru.Strategy
{
    public interface IStrategy
    {
        List<string> DoAlgorithn(List<string> data);
    }
}
