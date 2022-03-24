using Abp.Domain.Entities.Auditing;
using System;

namespace AcmeCorp.HealthCare
{
    /// <summary>
    /// Refer : https://aspnetboilerplate.com/Pages/Documents/Entities?searchKey=entity
    /// </summary>
    public class Patient : FullAuditedEntity<Guid>
    {
        public string PatientId { get; set; }

        public string PatientName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
