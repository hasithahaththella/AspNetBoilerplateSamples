using System.Collections.Generic;
using AcmeCorp.Roles.Dto;

namespace AcmeCorp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
