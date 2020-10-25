using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> students;
        public int Capacity { get; set; }
        public int Count { get { return students.Count(); } }

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            var toRemove = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (toRemove != null)
            {
                students.Remove(toRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            bool hasStudents = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Subject == subject)
                {
                    sb.AppendLine($"{students[i].FirstName} {students[i].LastName}");
                    hasStudents = true;
                }
            }

            if (hasStudents)
            {
                return sb.ToString().Trim();
            }
            return "No students enrolled for the subject";
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
