using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class StudentNotFoundException : NotFoundException
    {
        public StudentNotFoundException(Guid id)
            : base($"The Student with id: {id} doesn't exist in the database.")
        {
        }
    }
}