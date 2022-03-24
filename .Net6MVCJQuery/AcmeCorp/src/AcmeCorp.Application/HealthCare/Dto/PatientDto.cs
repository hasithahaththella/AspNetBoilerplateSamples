using Abp.AutoMapper;
using System;
using Abp.Application.Services.Dto;

namespace AcmeCorp.HealthCare.Dto
{
    [AutoMap(typeof(Patient))]
    public class PatientDto : EntityDto<Guid>
    {
        public string PatientId { get; set; }

        public string PatientName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
    }
}
