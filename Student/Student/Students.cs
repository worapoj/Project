using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Students
    {
        public string name = "Panda";
        public double score = 100.0;
        public DateTime birthday = DateTime.Now;

        public Students() {
            //read Students data from txt file
            string file = System.IO.File.ReadAllText(@"c:\s1.txt");
            //string file = System.IO.File.ReadAllText("c:\\s1.txt");
            string[] stuData = file.Split(' ');
            this.name = stuData[0];
            this.score = double.Parse(stuData[1]);
        }
    }
}
