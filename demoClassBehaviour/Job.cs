using System;
using System.Collections.Generic;

namespace demoClassBehaviour
{
    public class Job
    {
        public string Name { get; set; }
        public string Employer { get; set; }
        public string Location { get; set; }
        public string PositionType { get; set; }
        public string CoreCompentency { get; set; }

        public Job() { }

        public string ToMultilineString()
        {
            string result = "*****" + Environment.NewLine;
            result += "Name:     " + Name + Environment.NewLine;
            result += "Employer: " + Employer + Environment.NewLine;
            result += "Location: " + Location + Environment.NewLine;
            result += "Position Type: " + PositionType + Environment.NewLine;
            result += "Core Competency: " + CoreCompentency + Environment.NewLine;
            result += "*****";

            return result;
        }

        public override string ToString()
        {
            return Name + " - " + Employer + " - " + Location;
        }

        public static List<Job> CreateJobList()
        {
            List<Job> result = new List<Job>();

            result.Add(new Job
            {
                Name = "Java Developer",
                Employer = "Obstacle",
                Location = "Redwood City",
                PositionType = "Back end developer",
                CoreCompentency = "Java"
            });

            result.Add(new Job
            {
                Name = "Junior C# Developer",
                Employer = "Dnl-Core",
                Location = "Waarder",
                PositionType = "Fully stuck developer",
                CoreCompentency = "C#, ASP.NET"
            });

            result.Add(new Job
            {
                Name = "Objective C developer",
                Employer = "Apple",
                Location = "Cupertino",
                PositionType = "Short stick developer",
                CoreCompentency = "Objective C"
            });

            result.Add(new Job
            {
                Name = "Integration Tester",
                Employer = "Microsoft",
                Location = "St Louis",
                PositionType = "Automated Software Testing",
                CoreCompentency = "PowerShell, C#, Visual Studio"
            });

            return result;
        }
    }
}
