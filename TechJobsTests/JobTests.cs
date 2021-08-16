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

        //Employer acme;
        //Location desert;
        //PositionType qa;
        //CoreCompetency persistence;

        [TestInitialize]
        public void InitializeJobObjects()
        {
            empty1 = new Job();
            empty2 = new Job();

            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
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

        }
    }
}
