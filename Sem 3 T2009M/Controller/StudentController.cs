using System;
using System.Collections.Generic;
using Sem_3_T2009M.Model;

namespace Sem_3_T2009M.Controller
{
    public class StudentController
    {
        //hiển thị danh sách sinh viên
        public void printlistStudent(List<Student> students)
        {
            Console.WriteLine("Student List");
            Console.WriteLine("================================================================================");
            Console.WriteLine("RollNumber\t\t|Name\t\tIs New \t\tStatus");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public Student CreatedStudent()
        {
            Console.WriteLine("vui lòng nhập mã sinh viên");
            var rollNumber = Console.ReadLine();
            Console.WriteLine("vui lòng nhập tên sinh viên");
            var fullName = Console.ReadLine();
            Console.WriteLine("vui lòng nhập email");
            var email = Console.ReadLine();
            Console.WriteLine("vui long nhap số điện thoại");
            var phone = Console.ReadLine();
            Console.WriteLine("vui lòng nhập ngày sinh(yyyy-mm-dd)");
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("vui lòng nhập trạng thái, ");
            var status = (StudenStatus) Int32.Parse(Console.ReadLine());
            var student = new Student
            {
                RollNumber = rollNumber,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Status = status
            };
            return student;
        }
    
     }
}