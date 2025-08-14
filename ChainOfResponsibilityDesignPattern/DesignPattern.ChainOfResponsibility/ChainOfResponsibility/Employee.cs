using DesignPattern.ChainOfResponsibility.DAT;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        //bir noktadan referans alabilmek. COR, zincir mantığı ile çalıştığı için bir zincirler hep bir önceki zincirden referans alır.
        //Bı kod bloğunda Employee sınıfı, zincir mantığını uygulamak için bir sonraki approver'ı tutar.
        protected Employee NextApprover; 
        public void SetNextApprover(Employee superVisior)
        {
            this.NextApprover = superVisior;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req); //Burada CustomerProcessViewModel sınıfını bir istek sınıfı olarak kullanıyoruz.

    }
    //abstract class vs interface
}
