using System.Collections.Generic;
using AcmeCorp.Roles.Dto;

namespace AcmeCorp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
