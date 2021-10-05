using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Model
{
    public class Sample
    {

        private int id;
        private string name;
        private double value;
        private DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }


        public double Value
        {
            get { return value; }
            set { value = this.value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public Sample(int id, string name, double value, DateTime time)
        {
            this.id = id;
            this.name = name;
            this.value = value;
            this.time = time;
        }
    }
}
