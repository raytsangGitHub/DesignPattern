using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Structural.Proxy.ISharedFolder;

namespace Structural.Proxy
{
    internal class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee _employee;
        public SharedFolderProxy(Employee emp)  //inject Employee 
        {
            _employee = emp;
        }

        internal SharedFolder SharedFolder
        {
            get => default;
            set
            {
            }
        }

        internal Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public void PerformRWOperations()
        {
            if (_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
