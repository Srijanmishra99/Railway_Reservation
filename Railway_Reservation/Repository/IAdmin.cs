using Railway_Reservation.Model;

namespace Railway_Reservation.Repository

    {
        public class IAdmin : IAdminInterface
        {
            private List<Admin> _admins = new List<Admin>
        {
            new Admin { UserId = 1, PhoneNo = "8528041212", Password = "8528041212" }
        };
            public Admin Authenticate(string PhoneNo, string Pass)
            {
                return _admins.FirstOrDefault(u => u.PhoneNo.Equals(PhoneNo) && u.Password.Equals(Pass));
            }
        }
   }

