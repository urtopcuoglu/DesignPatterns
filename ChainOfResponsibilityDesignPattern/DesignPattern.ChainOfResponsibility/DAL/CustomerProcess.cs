using DesignPattern.ChainOfResponsibility.DAT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DAT
{
    public class CustomerProcess
    {
        public string CustomerProcessId { get; set; }
        public string Name { get; set; }

        public string Amount { get; set; }

        public string EmployeeName { get; set; }

        public string Description { get; set; }
    }
}
