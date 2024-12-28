using System;

namespace PropertyPatterns
{

   public  class Result
    {

        public int Marks { get; set; }
        public string  Grade { get; set; }

    }

    public static class PropertyPaternDemo
    {
        public static bool Is60MarksHighAndGradePass(Result res)
        {
            return res is { Marks: 60, Grade: "Pass" };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result obj = new Result();
            obj.Marks = 60;
            bool res=PropertyPaternDemo.Is60MarksHighAndGradePass(obj);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
