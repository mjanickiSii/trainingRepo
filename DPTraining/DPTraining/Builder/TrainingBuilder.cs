using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPTraining.Builder
{
    public class TrainingBuilder : ITrainingBuilder
    {
        private string _value;
        private string _name;
        public void AddValue(object value)
        {
            _value = value.ToString();
        }

        public void AddName(string name)
        {
            _name = name;
        }

        public string GetProduct()
        {
            return string.Format("{0}: {1}",_name,_value);
        }
    }
}
