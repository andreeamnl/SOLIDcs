using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IManager : IEmployee   //Imanager really is Iemployee
    {
        void GeneratePerformanceReview();
    }
}
