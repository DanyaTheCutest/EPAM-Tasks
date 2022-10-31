using System;
using System.Collections.Generic;
using Task8.BL;
using Task8.Entities;
using Task8.Dependencies;
using Task8.BLL.Interfaces;

namespace Task8.PL.Console
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IBLL bll = DependencyResolver.Instance.BLL;
        }
    }
}



