using System;
using System.Collections.Generic;
using Sem_3_T2009M.Controller;
using Sem_3_T2009M.Model;

namespace Sem_3_T2009M
{
    public enum StudenStatus
    {
        Vip = 2,
        Active = 1,
        Deactive = 0, 
        Delete = -1
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            //   var a = 1;//int
            // var b = "chinh";//string
            // var c = true;//bool
            //    var st = new Student
            //    {
            //        RollNumber = "A001",
            //        Birthday = DateTime.Parse("2021-12-20"),
            //        Email = "chinhduong@gmail.com",
            //        Phone = "0987654321",
            //        CreatedAt = DateTime.Now,//thời gian hiện tại
            //        FullName = "Duong Thi Chinh",
            //        Status = StudenStatus.Deactive //
            //    };

            //  //  Console.WriteLine(st.ToString());
            //  Console.WriteLine((int)st.Status);
            
            
          //  var st = new Student()
          //  {
          //      RollNumber = "A",
          //  }

          var stController = new StudentController();
          var st1 = stController.CreatedStudent();
          Console.WriteLine(st1.ToString());
        }
    }
}