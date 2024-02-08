using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesApplication;

namespace TestGradeManager
{
    [TestClass]
    public class TestClassRoom
    {
        [TestMethod]
        public void TestConstructor()
        {
            ClassRoom room = new ClassRoom("room");
            Assert.AreEqual(0, room.StudentCount);
            Assert.IsNotNull(room.Students);
            Assert.AreEqual("room", room.Name);
            Assert.AreEqual(0, room.Students.Count);
        }

        [TestMethod]
        public void TestAddStudent()
        {
            ClassRoom room = new ClassRoom("room");
            room.AddStudent(new Student("Cody Sevier"));
            room.AddStudent("Test Student");
            Assert.AreEqual(2, room.StudentCount);
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            ClassRoom room = new ClassRoom("room");
            var cs = new Student("Cody Sevier");
            room.AddStudent(cs);
            room.AddStudent("Test Student");
            room.RemoveStudent(cs);
            room.RemoveStudent("Test Student");
            Assert.AreEqual(0, room.StudentCount);
        }

        [TestMethod]
        public void TestGetStudent()
        {
            ClassRoom room = new ClassRoom("room");
            var cs = new Student("Cody Sevier");
            room.AddStudent(cs);
            room.AddStudent("Test Student");
            var csg = room.GetStudent("Cody Sevier");
            var tsg = room.GetStudent("Test Student");
            Assert.AreEqual("Cody Sevier", csg.Name);
            Assert.AreEqual("Test Student", tsg.Name);
        }

        [TestMethod]
        public void TestGetTopStudentByAverage()
        {
            ClassRoom room = new ClassRoom("room");
            var cs = new Student("Cody Sevier");
            cs.Assign("peep");
            cs.GradeAssignment("peep", 100);
            room.AddStudent(cs);
            room.AddStudent("Test Student");
            var tsg = room.GetStudent("Test Student");
            tsg.Assign("peep");
            tsg.GradeAssignment("peep", 0);
            var top = room.GetTopStudentByAverage();
            Assert.AreEqual("Cody Sevier", top.Name);
        }

        [TestMethod]
        public void TestGetWorstStudentByAverage()
        {
            ClassRoom room = new ClassRoom("room");
            var cs = new Student("Cody Sevier");
            cs.Assign("peep");
            cs.GradeAssignment("peep", 100);
            room.AddStudent(cs);
            room.AddStudent("Test Student");
            var tsg = room.GetStudent("Test Student");
            tsg.Assign("peep");
            tsg.GradeAssignment("peep", 0);
            var worst = room.GetWorstStudentByAverage();
            Assert.AreEqual("Test Student", worst.Name);
        }

        [TestMethod]
        public void TestClassAverage()
        {
            ClassRoom room = new ClassRoom("room");
            var cs = new Student("Cody Sevier");
            cs.Assign("peep");
            cs.GradeAssignment("peep", 100);
            room.AddStudent(cs);
            room.AddStudent("Test Student");
            var tsg = room.GetStudent("Test Student");
            tsg.Assign("peep");
            tsg.GradeAssignment("peep", 0);
            Assert.AreEqual(50, room.ClassAverage());
        }
    }
}
