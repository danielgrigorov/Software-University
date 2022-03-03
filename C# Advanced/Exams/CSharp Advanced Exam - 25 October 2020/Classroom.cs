using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }
        public int Capacity { get; set; }

        public int Count => this.students.Count();

        public List<Student> Students
        {
            get => this.students;
        }

        public string RegisterStudent(Student student)
        {
            if (this.students.Count + 1 <= this.students.Capacity)
            {
                this.students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            var studentToDismiss = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (studentToDismiss == null)
            {
                return $"Student not found";
            }
            else
            {
                this.students.Remove(studentToDismiss);
                return $"Dismissed student {studentToDismiss.FirstName} {studentToDismiss.LastName}";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            var getSubjectInfo = this.students.Where(x => x.Subject == subject).ToList();

            if (getSubjectInfo.Count == 0)
            {
                return $"No students enrolled for the subject";
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var item in getSubjectInfo)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }

                return sb.ToString().TrimEnd();
            }
        }

        public int GetStudentsCount() => this.students.Count();

        public Student GetStudent(string firstName, string lastName)
        {
            var studentToGet = this.students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return studentToGet;
        }
    }
}
