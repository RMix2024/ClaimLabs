using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesApplication;

namespace TestGradeManager
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void TestStudentConstructor()
        {
            Student student = new Student("Cody Sevier");
            Assert.AreEqual("Cody Sevier", student.Name);
            Assert.IsNotNull(student.Assignments);
            Assert.AreEqual(0, student.Assignments.Count);
            Assert.AreEqual(0, student.Average);
            Assert.AreEqual(true, student.HasCompletedAllAssignments);
        }

        [TestMethod]
        public void TestStudentAssign()
        {
            Student student = new Student("Cody Sevier");
            student.Assign("peep");
            student.Assign("test");
            Assert.AreEqual(2, student.Assignments.Count);
            Assert.AreEqual(false, student.HasCompletedAllAssignments);
            Assert.AreEqual(0, student.Average);
        }

        [TestMethod]
        public void TestStudentUnassign()
        {
            Student student = new Student("Cody Sevier");
            student.Assign("peep");
            student.Assign("test");
            student.Unassign("peep");
            student.Unassign("test");
            Assert.AreEqual(0, student.Assignments.Count);
            Assert.AreEqual(true, student.HasCompletedAllAssignments);
            Assert.AreEqual(0, student.Average);
        }

        [TestMethod]
        public void TestStudentGrade()
        {
            Student student = new Student("Cody Sevier");
            student.Assign("peep");
            student.Assign("test");
            student.GradeAssignment("peep", 12);
            student.GradeAssignment("test", 12);
            Assert.AreEqual(2, student.Assignments.Count);
            Assert.AreEqual(true, student.HasCompletedAllAssignments);
            foreach(var ass in student.Assignments)
            {
                Assert.IsTrue(ass.IsComplete);
            }
            Assert.AreEqual(12, student.Average);
        }

        [TestMethod]
        public void TestStudentAverage()
        {
            Student student = new Student("Cody Sevier");
            student.Assign("peep");
            student.Assign("test");
            student.Assign("money"); // an ungraded assignment wont be considered.
            student.GradeAssignment("peep", 50);
            student.GradeAssignment("test", 100);
            Assert.AreEqual(75, student.Average);
        }

        [TestMethod]
        public void TestStudentTopAssingment()
        {
            Student student = new Student("Cody Sevier");
            student.Assign("peep");
            student.Assign("test");
            student.GradeAssignment("peep", 50);
            student.GradeAssignment("test", 100);
            Assignment top = student.TopAssignment();
            Assert.AreEqual("test", top.Name);
            Assert.AreEqual(100, top.Grade);
        }

        [TestMethod]
        public void TestStudentWorstAssingment()
        {
            Student student = new Student("Cody Sevier");
            student.Assign("peep");
            student.Assign("test");
            student.GradeAssignment("peep", 50);
            student.GradeAssignment("test", 100);
            Assignment worst = student.WorstAssignment();
            Assert.AreEqual("peep", worst.Name);
            Assert.AreEqual(50, worst.Grade);
        }

        [TestMethod]
        public void TestCompareStudents()
        {
            Student cody = new Student("Cody Sevier");
            Student ash = new Student("Ash");
            cody.Assign("peep");
            ash.Assign("peep");
            cody.GradeAssignment("peep", 50);
            ash.GradeAssignment("peep", 100);
            bool result = cody < ash;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestOperators()
        {
            Student cody = new Student("Cody Sevier");
            Student ash = new Student("Ash");
            Student spud = new Student("spud");
            cody.Assign("peep");
            ash.Assign("peep");
            spud.Assign("peep");
            cody.GradeAssignment("peep", 50);
            ash.GradeAssignment("peep", 100);
            spud.GradeAssignment("peep", 100);
            Assert.IsTrue(ash > cody);
            Assert.IsTrue(cody < ash);
        }
    }
}
