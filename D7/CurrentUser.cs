using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7
{
    public static class CurrentUser
    {
        public static string? LoginStatus { get; set; } = "not autenticated";
        public static string? Name { get; set; }
    }
}