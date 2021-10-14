using System;

namespace Sem_3_T2009M.Model
{
    public class Student
    {
        public string RollNumber { get; set;}
        public string FullName { get; set;}
        public DateTime Birthday { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}
        public DateTime CreatedAt { get; set;}
        public StudenStatus Status { get; set; }

        public bool isNewStudent()
        {
            return DateTime.Now.CompareTo(CreatedAt.AddMonths(2)) <= 0;
        }
        public bool isDeactive()
        {
            return Status == StudenStatus.Deactive;
        }
        
        public override string ToString()
        {
            return $"{RollNumber,-30}{"|",10}{FullName,-30}{"|",10}{isNewStudent(),-30}{"|",10}{Status,-30}";
        }
    }
}