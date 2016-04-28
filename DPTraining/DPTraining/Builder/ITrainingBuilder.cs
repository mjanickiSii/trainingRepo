using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPTraining.Builder
{
    interface ITrainingBuilder
    {
        void AddValue(object name);
        void AddName(string value);
        string GetProduct();
    }
}
