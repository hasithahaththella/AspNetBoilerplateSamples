using Abp.Application.Services;
using Abp.Domain.Repositories;
using AcmeCorp.HealthCare.Dto;
using System;

namespace AcmeCorp.HealthCare
{
    /// <summary>
    /// Ref :: https://aspnetboilerplate.com/Pages/Documents/Application-Services
    /// </summary>
    public class PatientAppService : AsyncCrudAppService<Patient, PatientDto, Guid>, IPatientAppService
    {
        public PatientAppService(IRepository<Patient, Guid> repository) : base(repository)
        {
                
        }
    }
}
