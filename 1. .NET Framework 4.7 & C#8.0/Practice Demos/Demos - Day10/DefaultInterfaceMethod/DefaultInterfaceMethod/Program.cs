using System;

namespace DefaultInterfaceMethod
{
    interface Istudent
    {
       public void DressCode()
        {
            Console.WriteLine("white and Green");
        }
        void Name();
        int totalmarks(int maths,int science,int english)
        {
            return maths + science + english;
        }
    }
    
    class StuDetails:Istudent,Ischool
    {
        public void Name()
        {
            Console.WriteLine("JohnSmith");
        }
    }
    interface Ischool:Istudent
    {
        void Istudent.DressCode()
        {
            Console.WriteLine("Orange and yello overidden");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StuDetails obj = new StuDetails();
            obj.Name();

            Istudent stuobj = obj;
            int totalmarks = stuobj.totalmarks(70, 60, 80);
            Console.WriteLine(totalmarks);
            stuobj.DressCode();

            Ischool schoolobj = obj;
            schoolobj.DressCode();
        }
    }
}
