﻿using CareerGuidance.Data;
using CareerGuidance.DataAccess.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Repositories
{
    public class AddressData : IAddressData
    {
        private readonly CareerGuidanceDBContext _context;
        public AddressData(CareerGuidanceDBContext context)
        {
            _context = context;
        }
    }

}
