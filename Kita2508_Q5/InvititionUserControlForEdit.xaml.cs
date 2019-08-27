using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kita2508_Q5
{
    /// <summary>
    /// Interaction logic for InvititionUserControlForEdit.xaml
    /// </summary>
    public partial class InvititionUserControlForEdit : UserControl
    {
        List<Invitation> invitations = new List<Invitation>();
        public InvititionUserControlForEdit()
        {
            InitializeComponent();
            invitations.Add(new Invitation() { Id = 1, FirstName = "ForEdit", lastName = "Doe", Age = 10, Email = "abc@wee.com", IsMember = true, OrderValue = 230.7, Status = InvitationStatus.Shipped });
            invitations.Add(new Invitation() { Id = 2, FirstName = "Horm", lastName = "Goe", Age = 12, Email = "efg@wee.com", IsMember = false, OrderValue = 233.8, Status = InvitationStatus.New });
            invitations.Add(new Invitation() { Id = 3, FirstName = "Yohn", lastName = "Koe", Age = 13, Email = "hij@wee.com", IsMember = true, OrderValue = 236.9, Status = InvitationStatus.Processing });
            invitations.Add(new Invitation() { Id = 4, FirstName = "Lohn", lastName = "Aoe", Age = 16, Email = "klm@wee.com", IsMember = false, OrderValue = 239.0, Status = InvitationStatus.None });
            invitations.Add(new Invitation() { Id = 5, FirstName = "Rohn", lastName = "Boe", Age = 17, Email = "nop@wee.com", IsMember = true, OrderValue = 242.1, Status = InvitationStatus.Received });


            dgInvitaions.ItemsSource = invitations;
        }
    }
}
