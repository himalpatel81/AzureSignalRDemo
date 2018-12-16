using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrain.MultiTenant
{
    public class AppTenant
    {
        public string Name { get; set; }
        public string[] Hostnames { get; set; }
    }
}
