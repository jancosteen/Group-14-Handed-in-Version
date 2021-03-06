﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserDetailsDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName1 { get; set; }
        public string UserSurname { get; set; }
        public string UserContactNumber { get; set; }
        public int? UserRoleIdFk { get; set; }
        public int? EmployeeIdFk { get; set; }

        public virtual EmployeeDto EmployeeIdFkNavigation { get; set; }
        public virtual UserRoleDto UserRoleIdFkNavigation { get; set; }
        public virtual ICollection<ReservationDto> Reservation { get; set; }
    }
}
