﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Admin : User
    {
        #region Fields
        #endregion

        #region Builders
        public Admin(int id, string email, string password, int role) : base(id, email, password, role)
        {
        }
        #endregion

        public Admin()
        {
            _email = "";
            _password = "";
        }

        #region Props
        public new int Id { get { return _id; } }
        #endregion

        #region Methods


        public bool RegisterSubject(Delegate register, List<Subject> subjectList, string name, short period, short correlativeId)
        {
            bool r = false;
            if (subjectList is not null && name != "" && period > 0 && correlativeId > 0)
            {
                r = (bool)register.DynamicInvoke(name, period, correlativeId);
                if (r)
                    subjectList.Clear();
            }
            return r;
        }

        public bool AssignProfessorToSubject(Delegate assign, List<SubjectInCourse> subjectList, int userId, string subjectName, int status)
        {
            bool r = false;
            if (subjectList is not null && subjectName != "" && userId > 0 && status >= 0 && status <= 1)
            {
                r = (bool)assign.DynamicInvoke(userId, subjectName, status);
                if (r) 
                    subjectList.Clear(); 
            }
            return r;
        }


        public short GetNewSubjectId(List<Subject> subjectList)
        {
            int max = 0;
            foreach (Subject subject in subjectList)
            {
                if (subject.Id > max)
                    max = subject.Id;
            }

            return (short)(max += 1);
        }

        public Student FindStudentByEmail(List<Student> students, string email)
        {
            if (students is not null && email is not null)
            {
                foreach (Student student in students)
                {
                    if (student.Email == email)
                    {
                        return student;
                    }
                }
            }

            return null;
        }

        public SubjectInCourse FindSubjectByName(List<SubjectInCourse> subjectsInCourse, string name, Student student)
        {
            if (name != "" && student is not null)
            {
                foreach (SubjectInCourse subject in subjectsInCourse)
                {
                    if (subject.Name == name)
                    {
                        SubjectInCourse subjectInCourse = new();
                        subjectInCourse = subject;
                        return subjectInCourse;
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
