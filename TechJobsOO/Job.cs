using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        //TODO: Add the two necessary constructors.
        // TODO1: Code a constructor to initialize the id field with a unique value. This constructor should take no parameters.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        // TODO2: Code a second constructor that takes 5 parameters & assigns values to
        //        name, employerName, employerLocation, jobType, and jobCoreCompetency.
        //        Also, this constructor should call the first in order to initialize the id field.
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        //TODO: Generate Equals() and GetHashCode() methods.
        // TODO3: Generate the Equals() and GetHashCode() methods. Consider two Job objects equal when their id fields match.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        public override string ToString()
        {
            //return "________";

            //if(String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(EmployerName.Value) && String.IsNullOrEmpty(EmployerLocation.Value) && String.IsNullOrEmpty(JobType.Value) && String.IsNullOrEmpty(JobCoreCompetency.Value))
            //{
            //    return "OOPS! This job does not seem to exist.";
            //}

            if (String.IsNullOrEmpty(Name))
            {
                Name = "Data not avaliable";
            }

            if (String.IsNullOrEmpty(EmployerName.Value))
            {
                EmployerName.Value = "Data not avaliable";
            }

            if (String.IsNullOrEmpty(EmployerLocation.Value))
            {
                EmployerLocation.Value = "Data not avaliable";
            }

            if (String.IsNullOrEmpty(JobType.Value))
            {
                JobType.Value = "Data not avaliable";
            }

            if (String.IsNullOrEmpty(JobCoreCompetency.Value))
            {
                JobCoreCompetency.Value = "Data not avaliable";
            }


            return $"\nID: {Id} \nName: {Name} \nEmployer: {EmployerName.Value} " +
                    $"\nLocation: {EmployerLocation.Value} \nPosition Type: {JobType.Value} " +
                    $"\nCore Competency: {JobCoreCompetency.Value} \n";
            }


         }
}
