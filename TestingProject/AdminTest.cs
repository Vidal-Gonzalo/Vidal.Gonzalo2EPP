using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;

namespace TestingProject
{
    [TestClass]
    public class AdminTest
    {
        Admin admin = new Admin(51, "adm@gmail.com", "adm123", 52);
        #region FindStudentByEmail
        [TestMethod]
        public void FindStudentByEmail_WhenTheresNoCoincidence_ShouldReturnNull()
        {
            //Arrange
            List<Student> students = new List<Student>();
            students.Add(new(50, "test@gmail.com", "test123", 5));
            //Act
            Student actual = admin.FindStudentByEmail(students, "test");
            //Assert
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void FindStudentByEmail_WhenTheresCoincidence_ShouldReturnStudent()
        {
            //Arrange
            Student expected = new Student(50, "test@gmail.com", "test123", 5);
            List<Student> students = new List<Student>();
            students.Add(expected);
            //Act
            Student actual = admin.FindStudentByEmail(students, "test@gmail.com");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindStudentByEmail_WhenTheresNoEmail_ShouldReturnNull()
        {
            //Arrange
            string email = "";
            List<Student> students = new List<Student>();
            //Act
            Student actual = admin.FindStudentByEmail(students, email);
            //Assert
            Assert.AreEqual(null, actual);
        }
        #endregion

        #region FindSubjectByName
        [TestMethod]
        public void FindSubjectByName_WhenTheresNoName_ShouldReturnNull()
        {
            //Arrange
            string name = "";
            List<SubjectInCourse> subjects = new List<SubjectInCourse>();
            Student student = new(50, "test@gmail.com", "test123", 5);
            //Act
            SubjectInCourse actual = admin.FindSubjectByName(subjects, name, student);
            //Assert
            Assert.AreEqual(null, actual);
        }
        [TestMethod]
        public void FindSubjectByName_WhenTheresNoCoincidence_ShouldReturnNull()
        {
            //Arrange
            string name = "Cartoons";
            List<SubjectInCourse> subjects = new List<SubjectInCourse>();
            Student student = new(50, "test@gmail.com", "test123", 5);
            //Act
            SubjectInCourse actual = admin.FindSubjectByName(subjects, name, student);
            //Assert
            Assert.AreEqual(null, actual);
        }
        [TestMethod]
        public void FindSubjectByName_WhenTheresCoincidence_ShouldReturnSubject()
        {
            //Arrange
            string name = "Cartoons";
            List<SubjectInCourse> subjects = new List<SubjectInCourse>();
            SubjectInCourse expected = new(1, name);
            Student student = new(50, "test@gmail.com", "test123", 5);
            subjects.Add(expected);

            //Act
            SubjectInCourse actual = admin.FindSubjectByName(subjects, name, student);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region FindProfessorByEmail
        public void FindProfessorByEmail_WhenTheresCoincidence_ShouldReturnProfessor()
        {
            //Arrange
            string email = "test@gmail.com";
            List<Professor> professors = new List<Professor>();
            Professor expected = new(50, "test@gmail.com", "test123", 10);
            professors.Add(expected);

            //Act
            Professor actual = admin.FindProfessorByEmail(email, professors);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindProfessorByEmail_WhenTheresNoCoincidence_ShouldReturnNull()
        {
            //Arrange
            string email = "Cartoon@gmail.com";
            List<Professor> professors = new List<Professor>();
            Professor professor = new(50, "test@gmail.com", "test123", 10);
            professors.Add(professor);

            //Act
            Professor actual = admin.FindProfessorByEmail(email, professors);

            //Assert
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void FindProfessorByEmail_WhenTheresNoEmail_ShouldReturnNull()
        {
            //Arrange
            string email = "";
            List<Professor> professors = new List<Professor>();
            Professor expected = new(50, "test@gmail.com", "test123", 10);
            professors.Add(expected);

            //Act
            Professor actual = admin.FindProfessorByEmail(email, professors);

            //Assert
            Assert.AreEqual(null, actual);
        }
        #endregion

        #region FindSubjectById
        [TestMethod]
        public void FindSubjectById_WhenTheresCoincidence_ShouldReturnSubject()
        {
            //Arrange
            short id = 50;
            List<Subject> subjects = new List<Subject>();
            Subject expected = new(50, "pepito", 1, 2);
            subjects.Add(expected);

            //Act
            Subject actual = admin.FindSubjectById(id, subjects);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindSubjectById_WhenTheresNoCoincidence_ShouldReturnNull()
        {
            //Arrange
            List<Subject> subjects = new List<Subject>();
            Subject subject = new(56, "formis", 1, 2);
            subjects.Add(subject);

            //Act
            Subject actual = admin.FindSubjectById(54, subjects);

            //Assert
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void FindSubjectById_WhenIdIsLowerThanZero_ShouldReturnNull()
        {
            //Arrange
            short id = -5;
            List<Subject> subjects = new List<Subject>();
            Subject subject = new(56, "formis", 1, 2);
            subjects.Add(subject);

            //Act
            Subject actual = admin.FindSubjectById(id, subjects);

            //Assert
            Assert.AreEqual(null, actual);
        }
        #endregion

        #region SerializeToJson
        [TestMethod]
        public void SerializeToJson_WhenStudentsCountIsLessOrEqualToZero_ShouldReturnFalse()
        {
            //Arr
            bool expected = false;
            List<Student> students = new List<Student>();
            //Act
            bool actual = admin.SerializeToJson(students);
            //Ass
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeToJson_WhenStudentsCountIsMoreThanZero_ShouldReturnTrue()
        {
            //Arr
            bool expected = true;
            List<Student> students = new List<Student>();
            students.Add(new(66, "testmethod@gmail.com", "testmethod123", 50));
            //Act
            bool actual = admin.SerializeToJson(students);
            //Ass
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region SerializeToCsv
        [TestMethod]
        public void SerializeToCsv_WhenStudentsCountIsLessOrEqualToZero_ShouldReturnFalse()
        {
            //Arr
            bool expected = false;
            List<Student> students = new List<Student>();
            //Act
            bool actual = admin.SerializeToCsv(students);
            //Ass
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeToCsv_WhenStudentsCountIsMoreThanZero_ShouldReturnTrue()
        {
            //Arr
            bool expected = true;
            List<Student> students = new List<Student>();
            students.Add(new(66, "testmethod@gmail.com", "testmethod123", 50));
            //Act
            bool actual = admin.SerializeToCsv(students);
            //Ass
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
