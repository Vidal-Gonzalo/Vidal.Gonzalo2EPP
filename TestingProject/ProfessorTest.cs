using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    [TestClass]
    public class ProfessorTest
    {
        Professor professor = new(51, "pro@gmail.com", "pro123", 52);

        #region ==
        [TestMethod]
        public void Equals_WhenProfessorIsNull_ShouldReturnFalse()
        {
            //Arr
            bool expected = false;
            SubjectInCourse subject = new SubjectInCourse(1, "testSubject");
            //Act
            bool actual = null == subject;
            //Ass
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Equals_WhenSubjectIsNull_ShouldReturnFalse()
        {
            //Arr
            bool expected = false;
            SubjectInCourse subject = new SubjectInCourse(1, "testSubject");
            //Act
            bool actual = professor == null;
            //Ass
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Equals_WhenSubjectProfessorEmailAndProfessorEmailAreEqual_ShouldReturnTrue()
        {
            //Arr
            bool expected = true;
            SubjectInCourse subject = new SubjectInCourse(1, "testSubject");
            subject.Professors.Add(professor);
            //Act
            bool actual = professor == subject;
            //Ass
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
