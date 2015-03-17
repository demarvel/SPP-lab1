using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_lab1
{
    public abstract class AutoPlant
    {
        public abstract Auto CreateAuto(string type);
    }
    public class BMW : AutoPlant
    {
        public override Auto CreateAuto(string type)
        {
            if(type.Equals("i5")){
                return new BMWi5();
            } else if (type.Equals("x6")) {
                return new BMWx6();
            } else { return null; }
            
        }
    }
    public class Audi : AutoPlant
    {
        public override Auto CreateAuto(string type)
        {
            if (type.Equals("A6"))
            {
                return new AudiA6();
            }
            else if (type.Equals("R8"))
            {
                return new AudiR8();
            }
            else { return null; }

        }
    }
    public abstract class Auto
    {
        public abstract string GetType();
    }
    //BMW
    public class BMWi5 : Auto
    {
        public override string GetType()
        {
            return "BMW серии i5";
        }
    }
    public class BMWx6 : Auto
    {
        public override string GetType()
        {
            return "BMW серии x6";
        }
    }
    //Audi
    public class AudiA6 : Auto
    {
        public override string GetType()
        {
            return "Audi серии A6";
        }
    }
    public class AudiR8 : Auto
    {
        public override string GetType()
        {
            return "Audi серии R8";
        }
    }

    public class MainApp {
        public static void Main(){

            AutoPlant bmw = new BMW();
            Auto bmwi5 = bmw.CreateAuto("i5");
            AutoPlant audi = new Audi();
            Auto audir8 = audi.CreateAuto("R8");

            string i5 = bmwi5.GetType();
            string r8 = audir8.GetType();
        }
    }

}
}
