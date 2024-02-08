using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesApplication;

namespace TestGradeManager
{
    [TestClass]
    public class TestAssignment
    {
        [TestMethod]
        public void TestAssingmentConstructor()
        {
            Assignment ass = new Assignment("Lab1");
            Assert.AreEqual(ass.Grade, 0);
            Assert.AreEqual(ass.Name, "Lab1");
            Assert.AreEqual(ass.IsComplete, false);
        }

        [TestMethod]
        public void TestAssingmentConstructorGrade()
        {
            Assignment ass = new Assignment("Lab1", 89.2);
            Assert.AreEqual(ass.Grade, 89.2);
            Assert.AreEqual(ass.Name, "Lab1");
            Assert.AreEqual(ass.IsComplete, true);
        }

        [TestMethod]
        public void TestGradeSetMarksItComplete()
        {
            Assignment ass = new Assignment("Lab1");
            Assert.AreEqual(ass.IsComplete, false);
            ass.Grade = 98.2;
            Assert.AreEqual(ass.IsComplete, true);
        }

        [TestMethod]
        public void TestOperators()
        {
            Assignment ass = new Assignment("Lab1");
            ass.Grade = 99;
            Assignment ass1 = new Assignment("Lab1");
            ass1.Grade = 44;
            Assert.IsTrue(ass > ass1);
            Assert.IsFalse(ass < ass1);
        }
    }
}
