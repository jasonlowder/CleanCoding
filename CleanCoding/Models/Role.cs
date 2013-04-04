using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.Models
{
    public interface Role
    {
        PermisionCollection Permisions { get; set; }
        string Description { get; set; }
        User UserProfile { get; set; }
    }
}
