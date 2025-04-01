using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Interfaces
{
    public interface ICLSCompliant
    {
        int GetYearOfBirth(System.DateTime birthDate);
        string GetFullName(string firstName, string lastName);
        void DisplayInfo(string name, int age);
    }
}
