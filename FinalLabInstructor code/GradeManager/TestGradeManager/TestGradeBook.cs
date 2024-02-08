using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesApplication;

namespace TestGradeManager
{
    [TestClass]
    public class TestGradeBook
    {
        [TestMethod]
        public void TestConstructor()
        {
            GradeBook gb = new GradeBook();
            Assert.AreEqual(gb.Assignments.Count, 0);
            Assert.AreNotEqual(null, gb.Assignments);
        }

        [TestMethod]
        public void TestAddAssignment()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment(new Assignment("Lab1"));
            Assert.AreEqual(1, gb.Assignments.Count);
        }

        [TestMethod]
        public void TestGetAssignment()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment(new Assignment("Lab1"));
            Assert.AreEqual(gb.Assignments.Count, 1);
            Assignment assign = gb.GetAssignment("Lab1");
            Assert.AreEqual("Lab1", assign.Name);
        }

        [TestMethod]
        public void TestAddAssignmentByName()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment("Lab1");
            Assert.AreEqual(1, gb.Assignments.Count);
        }

        [TestMethod]
        public void TestRemoveAssignmentByObject()
        {
            GradeBook gb = new GradeBook();
            var ass = new Assignment("Lab1");
            gb.AddAssignment(ass);
            gb.RemoveAssignment(ass);
            Assert.AreEqual(0, gb.Assignments.Count);
        }

        [TestMethod]
        public void TestRemoveAssignmentByName()
        {
            GradeBook gb = new GradeBook();
            var ass = new Assignment("Lab1");
            gb.AddAssignment(ass);
            gb.RemoveAssignment("Lab1");
            Assert.AreEqual(0, gb.Assignments.Count);
        }

        [TestMethod]
        public void TestGradeAssignment()
        {
            GradeBook gb = new GradeBook();
            var ass = new Assignment("Lab1");
            gb.AddAssignment(ass);
            gb.GradeAssignment(ass.Name, 93);
            ass = gb.GetAssignment("Lab1");
            Assert.AreEqual(93, ass.Grade);
        }

        [TestMethod]
        public void TestGradeAssignmentThroughRef()
        {
            GradeBook gb = new GradeBook();
            var ass = new Assignment("Lab1");
            gb.AddAssignment(ass);
            ass = gb.GetAssignment("Lab1");
            Assert.AreEqual(ass.Grade, 0);
            ass.Grade = 93;
            ass = gb.GetAssignment("Lab1");
            Assert.AreEqual(93, ass.Grade);
        }

        [TestMethod]
        public void TestTopGrade()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment(new Assignment("Lab1", 95.32));
            gb.AddAssignment(new Assignment("Lab2", 32));
            gb.AddAssignment(new Assignment("Lab3", 45.2));
            Assert.AreEqual(95.32, gb.TopAssignment().Grade);        
        }

        [TestMethod]
        public void TestWorstGrade()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment(new Assignment("Lab1", 95.32));
            gb.AddAssignment(new Assignment("Lab2", 32));
            gb.AddAssignment(new Assignment("Lab3", 45.2));
            Assert.AreEqual(32, gb.WorstAssignment().Grade);
        }

        [TestMethod]
        public void TestAreAllAssignmentsCompleteTrue()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment(new Assignment("Lab1", 95.32));
            gb.AddAssignment(new Assignment("Lab2", 32));
            gb.AddAssignment(new Assignment("Lab3", 45.2));
            Assert.IsTrue(gb.AreAllAssingmentsComplete);
        }

        [TestMethod]
        public void TestAreAllAssignmentsCompleteFalse()
        {
            GradeBook gb = new GradeBook();
            gb.AddAssignment(new Assignment("Lab1"));
            gb.AddAssignment(new Assignment("Lab2", 32));
            gb.AddAssignment(new Assignment("Lab3", 45.2));
            Assert.IsFalse(gb.AreAllAssingmentsComplete);
        }
    }
}
