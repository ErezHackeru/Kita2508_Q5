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
    /// Interaction logic for InvitationUserControlCustomized.xaml
    /// </summary>
    public partial class InvitationUserControlCustomized : UserControl
    {
        List<Invitation> invitations = new List<Invitation>();
        public InvitationUserControlCustomized()
        {
            InitializeComponent();
            invitations.Add(new Invitation() { Id = 1, FirstName = "Custom", lastName = "Doe", Birthday = new DateTime(1974, 1, 17), Email = "abc@wee.com", IsMember = true, OrderValue = 230.7, Status = InvitationStatus.Shipped });
            invitations.Add(new Invitation() { Id = 2, FirstName = "Horm", lastName = "Goe", Birthday = new DateTime(1984, 2, 17), Email = "efg@wee.com", IsMember = false, OrderValue = 233.8, Status = InvitationStatus.New });
            invitations.Add(new Invitation() { Id = 3, FirstName = "Yohn", lastName = "Koe", Birthday = new DateTime(1994, 3, 17), Email = "hij@wee.com", IsMember = true, OrderValue = 236.9, Status = InvitationStatus.Processing });
            invitations.Add(new Invitation() { Id = 4, FirstName = "Lohn", lastName = "Aoe", Birthday = new DateTime(2004, 4, 17), Email = "klm@wee.com", IsMember = false, OrderValue = 239.0, Status = InvitationStatus.None });
            invitations.Add(new Invitation() { Id = 5, FirstName = "Rohn", lastName = "Boe", Birthday = new DateTime(2014, 5, 17), Email = "nop@wee.com", IsMember = true, OrderValue = 242.1, Status = InvitationStatus.Received });


            dgInvitaionsCustom.ItemsSource = invitations;
        }
    }
}
