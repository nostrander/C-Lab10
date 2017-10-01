using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_LAB10_NatashaOstrander
{
    class Speed
    {
        public int s; //current speed
        public int x; //x coordinate
        public int y; //y coordinate
        public string newDirection;
        
        //speed will go u-up,d-down
        public void move(string newSpeed)
        {
            if (newSpeed == "u" || newSpeed == "U")
                speedUp();
            else if (newSpeed == "d" || newSpeed == "D")
                slowDown();
            else if (newSpeed == "e" || newSpeed == "E")
                east();
            else if (newSpeed == "w" || newSpeed == "W")
                west();
            else if (newSpeed == "n" || newSpeed == "N")
                north();
            else if (newSpeed == "s" || newSpeed == "S")
                south();

            else
                Console.WriteLine("Invalid Direction");
        }

        //Can only be called with Speed class
        private void speedUp()
        {
            this.s++;
            Console.WriteLine("Speed is " + this.x);
        }
        private void slowDown()
        {
            this.s--;
        }

        private void east()
        {
            this.x++;
//            this.newDirection = "East";
        }
        private void west()
        {
            this.x--;
//            this.newDirection = "West";
        }
        private void north()
        {
            this.y++;
//            this.newDirection = "North";
        }
        private void south()
        {
            this.y--;
//            this.newDirection="South";
        }

    }

    class Vehicle
    {
        //Define some properties
        public string make;
        string model;
        string color;
        string typeOfVehicle;
        public int topSpeed;
        public int currentSpeed;
        public int direction;
        public string direction;
        public bool isMoving;

        public Speed mySpeed;

        public Vehicle(string myVehicle)
        {
            this.typeOfVehicle = myVehicle;
            this.model = "Unknown";
            this.make = "Unknown";
            this.isMoving = false;
            this.mySpeed = new Speed();
            currentSpeed = this.mySpeed.x;

        }

        public Vehicle(string myMake,string myModel, string myColor, string myVehicle)
        {
            this.typeOfVehicle = myVehicle;
            this.model = myModel;
            this.make = myMake;
            this.color = myColor;
            this.isMoving = false;
            this.mySpeed = new Speed();
            currentSpeed = this.mySpeed.x;

        }
        
        public Vehicle(string myMake, string myModel, string myColor, string myVehicle,int myTopSpeed)
        {
            this.typeOfVehicle = myVehicle;
            this.model = myModel;
            this.make = myMake;
            this.color = myColor;
            this.topSpeed = myTopSpeed;
            this.isMoving = false;

            this.mySpeed = new Speed();
            currentSpeed=this.mySpeed.x;
       }
        public void ToString()
        {
            string finalSentence = "The " + this.typeOfVehicle + " is a " + this.color + " " + this.make + " " + this.model +
                " and is currently going " + this.mySpeed.x + " in the following direction: " + this.mySpeed.x+","+this.mySpeed.y + "." +
                " It has a top speed of " + this.topSpeed + ".";
            Console.WriteLine(finalSentence);
            Console.Write(this.typeOfVehicle + " is a ");
            Console.Write(this.color+" " + this.make+" "+this.model);
            Console.Write(" and is currently going "+this.mySpeed.x);
            Console.Write(" in the following direction: "+this.mySpeed.newDirection+".");
            Console.WriteLine(" It has a top speed of "+this.topSpeed+".");
        }


    }
}
