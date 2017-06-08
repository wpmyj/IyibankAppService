using System;
using System.Collections.Generic;
using System.Text;

namespace IyibankAppService.Models.Models
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
