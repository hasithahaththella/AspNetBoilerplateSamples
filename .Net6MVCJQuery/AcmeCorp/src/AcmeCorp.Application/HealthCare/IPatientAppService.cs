using System;
using Abp.Application.Services;
using AcmeCorp.HealthCare.Dto;

namespace AcmeCorp.HealthCare
{
    /// <summary>
    /// Ref :: https://aspnetboilerplate.com/Pages/Documents/Application-Services
    /// </summary>
    public interface IPatientAppService : IAsyncCrudAppService<PatientDto, Guid>
    {
    }
}
