﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    // The Receiver handles he request.
    internal class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }
        public void Save()
        {
            Console.WriteLine("Document Saved");
        }
        public void Close()
        {
            Console.WriteLine("Document Closed");
        }
    }
}
