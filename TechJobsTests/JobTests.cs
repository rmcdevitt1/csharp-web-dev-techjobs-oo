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

        //IDK IF THIS STUFF IS NEEDED//

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
            Assert.IsTrue(empty1.Id - empty2.Id == 1);
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
    }
}
