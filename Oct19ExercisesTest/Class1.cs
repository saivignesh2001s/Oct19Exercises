using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Oct19Exercises;
using static Oct19Exercises.Provider;

namespace Oct19ExercisesTest
{
    [TestFixture]
    public class Enroltest
    {
        [TestCase]
        public void IsTrueEnroll()
        {
            student s = new student();
            s.rollno = 790;
            s.studname = "Jagan";
            s.course = Course.DotNet;
            enrollment r = new enrollment();
            r.enrolno = 908;
            r.fees = 1000;
            studentenrollment er = new studentenrollment();
            bool k = er.enrollstudent(s, r);
            Assert.That(k);

        }
    }
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }
    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }
}
