using CareerGuidance.Data;
using CareerGuidance.DataAccess.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Repositories
{
    public class MentorData : IMentorData
    {
        private readonly CareerGuidanceDBContext _context;
        public MentorData(CareerGuidanceDBContext context)
        {
            _context = context;
        }
    }
}
