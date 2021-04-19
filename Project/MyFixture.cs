using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fitnesse.fixtures;

namespace Project
{
    public class MyFixture : fit.ColumnFixture
    {
        InsuranceService insurance = new InsuranceService();
        public int age;
        public string gender;

        public MyFixture()
        {

        }

        public double CalcPremium()
        {
            return insurance.CalcPremium(age, gender);
        }

    }
}
