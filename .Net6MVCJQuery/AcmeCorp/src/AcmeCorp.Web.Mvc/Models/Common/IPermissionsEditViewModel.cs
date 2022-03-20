using System.Collections.Generic;
using AcmeCorp.Roles.Dto;

namespace AcmeCorp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}