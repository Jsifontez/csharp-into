using System;
using System.Text;

namespace ObjectMethods
{
    public class Student
    {
      public string name;
      public string major;
      public double gpa;
      public Student(string aName, string aMajor, double aGpa)
      {
        name = aName;
        major = aMajor;
        gpa = aGpa;
      }

      // methods
      public bool HasHonors()
      {
        if (gpa >= 3.5)
        {
          return true;
        }
        return false;
        // all the code above can replace by
        // return gpa >= 3.5;
      }
    }
}