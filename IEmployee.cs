using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministradionAPI
{
    public interface IEmployee
    {
        public int Id { get; set; }
        string FirstName {  get; set; }
        string Lastname { get; set; }
        decimal Salary {  get; set; }

    }
}
