using System;
using System.Collections.Generic;
using System.Text;

namespace Doctor
{
    class Doctor:Human
    {

        public Doctor(int no , string name , string surname , string gender , string speciality , int experience):base(name , surname , gender)
        {
            this.No = no;
            this.Speciality = speciality;
            this.Experience = experience;
        }


        public int No;
        public string Speciality;
        public int Experience;

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nNo: {this.No}\nSpeciality: {this.Speciality}\nExperience: {this.Experience}\n==============================================================================";
        }

        
    }
}
