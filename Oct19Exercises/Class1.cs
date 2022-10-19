using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Oct19Exercises
{
    public enum Course
    {
        AIML,
        DotNet,
        Java
    }
    public class student
    {
        public int rollno
        {
            get;
            set;
        }
        public string studname
        {
            get;
            set;
        }
        public Course course
        {
            get;
            set;
        }
    }
    public class enrollment
    {
        public int enrolno
        {
            get;
            set;
        }
        public int fees
        {
            get;
            set;
        }
    }
    public class studentenrollment
    {
        public bool enrollstudent(student s,enrollment r)
        {
            if (r.fees > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public interface IExtensionManager
    {
        bool CheckExtension(string FileName);
    }

    public class ExtensionManager : IExtensionManager
    {
        public bool CheckExtension(string FileName)
        {
            //Some complex business logic might goes here. May be DB operation or file system handling  
            return false;
        }
    }
    public class StubExtensionManager : IExtensionManager
    {
        public bool CheckExtension(string FileName)
        {
            return true;
        }
    }
    public class FileChecker
    {
        IExtensionManager objmanager = null;
        //Default constructor  
        public FileChecker()
        {
            objmanager = new ExtensionManager();
        }
        //parameterized constructor  
        public FileChecker(IExtensionManager tmpManager)
        {
            objmanager = tmpManager;
        }

        public Boolean CheckFile(String FileName)
        {
            return objmanager.CheckExtension(FileName);
        }
    }
} 


