using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    public interface ITarget
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
