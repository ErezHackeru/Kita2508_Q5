using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kita2508_Q5
{
    public class Invitation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public double OrderValue { get; set; }
        public InvitationStatus Status { get; set; }
        public DateTime Birthday { get; set; }
                
    }

    public enum InvitationStatus
    {
        Received=1,
        Processing=2,
        New=3,
        Shipped=4,
        None=5
    }
}
