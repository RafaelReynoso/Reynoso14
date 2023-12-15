using Reynoso14.DataContext;
using Reynoso14.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reynoso14.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService() => _context = App.GetContext();

    }
}
