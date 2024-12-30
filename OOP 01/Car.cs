using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    internal class Car
    {

        private int id;
        private int speed;
        private string model;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }



    }
}
