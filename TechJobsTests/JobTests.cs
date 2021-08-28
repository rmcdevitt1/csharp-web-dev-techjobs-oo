using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        Job empty1;
        Job empty2;
        Job testJob;

        Employer acme;
        Location desert;
        PositionType qualityControl;
        CoreCompetency persistence;

        [TestInitialize]
        public void InitializeJobObjects()
        {

            acme = new Employer("ACME");
            desert = new Location("Desert");
            qualityControl = new PositionType("Quality Control");
            persistence = new CoreCompetency("Persistence");

            testJob = new Job("Product tester", acme, desert, qualityControl, persistence);


            empty1 = new Job();
            empty2 = new Job();

        }


        [TestMethod]
        public void TestSettingJobId()
        {
            //Use Assert statements to test that the ID values for the two objects are NOT the same and differ by 1.
            Assert.IsTrue(empty1.Id != empty2.Id);
            Assert.IsTrue(empty2.Id - empty1.Id == 1);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Use Assert statements to test that the constructor correctly assigns the value of each field.
            Assert.IsTrue(testJob.Name == "Product tester");
            Assert.IsTrue(testJob.EmployerName.Value == "ACME");
            Assert.IsTrue(testJob.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(testJob.JobType.Value == "Quality Control");
        }

        public void TestJobsForEquality()
        {
            Job testEquality1 = new Job("Name", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Job testEquality2 = new Job("Name", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Assert.AreNotEqual(testEquality1, testEquality2);
        }


        [TestMethod]
        public void TestJobsToString()
        {
            //TODO: When passed a Job object, it should return a string that contains a blank line before and after the job information.
            //Assert.IsTrue(testJob.ToString().Contains("________"));

            //TODO: The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line.
            Assert.IsTrue(testJob.ToString().Contains($"ID: " + testJob.Id));
            Assert.IsTrue(testJob.ToString().Contains($"Name: " + testJob.Name));
            Assert.IsTrue(testJob.ToString().Contains($"Employer: " + testJob.EmployerName.Value));
            Assert.IsTrue(testJob.ToString().Contains($"Location: " + testJob.EmployerLocation.Value));
            Assert.IsTrue(testJob.ToString().Contains($"Position Type: " + testJob.JobType.Value));
            Assert.IsTrue(testJob.ToString().Contains($"Core Competency: " + testJob.JobCoreCompetency.Value));
        }

        [TestMethod]
        public void TestJobsToString2()
        {
            //TODO: If a field is empty, the method should add, “Data not available” after the label.
            Job jobToStringTest2 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Name: Data not avaliable"));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Employer: Data not available"));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Location: Data not available"));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Position Type: Data not available"));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Core Competency: Data not available"));
        }

        //TODO: (Bonus) If a Job object ONLY contains data for the id field, the method should return, “OOPS! This job does not seem to exist.”
        [TestMethod]
        //public void TestJobsToStringBonus()
        //{
        //    Job jobToStringTestBonus = new Job(); //instantiating a Job with no parameters means it only has an ID!
        //    Assert.AreEqual(jobToStringTestBonus.ToString(), "OOPS! This job does not seem to exist.");

        //}
    }
}
