using NUnit.Framework;
using SchoolOopsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTests
{
    [TestFixture]
    public class SchoolDataTests
    {
        Student s = new Student();

        Subject sub = new Subject();

        Teacher ts = new Teacher();

        [TestCase("Ravi", ExpectedResult = true)]
        [TestCase("Sathiya", ExpectedResult = false)]
        [TestCase("ganga", ExpectedResult = false)]
        [TestCase("nandini", ExpectedResult = false)]
        [TestCase("gnanasekar", ExpectedResult = false)]
        public bool IsName(string search)
        {

            return s.Search(search);

        }

        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = true)]
        [TestCase("Biology", ExpectedResult = false)]
        [TestCase("English", ExpectedResult = true)]
        public bool IsSubject(string subj)
        {

            return sub.Search(subj);

        }

        [TestCase("Ram", ExpectedResult = true)]
        [TestCase("Sakthi", ExpectedResult = true)]
        [TestCase("Ganesh", ExpectedResult = true)]
        [TestCase("malaiyan", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }


    }
}