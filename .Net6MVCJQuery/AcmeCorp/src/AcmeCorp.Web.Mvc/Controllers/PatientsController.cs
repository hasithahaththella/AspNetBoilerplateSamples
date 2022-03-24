using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using AcmeCorp.Authorization;
using AcmeCorp.Controllers;
using AcmeCorp.HealthCare;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AcmeCorp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Patients)]
    public class PatientsController : AcmeCorpControllerBase
    {
        private readonly IPatientAppService _patientAppService;
        public PatientsController(IPatientAppService patientAppService)
        {
            _patientAppService = patientAppService;
        }

        public async Task<ActionResult> Index(int? skip = 0, int? take = 10)
        {
            var allPatients = await _patientAppService.GetAllAsync(new PagedAndSortedResultRequestDto
            {
                MaxResultCount = take.Value,
                SkipCount = skip.Value,
                Sorting = "PatientId"
            });

            return View(allPatients);
        }

        public async Task<ActionResult> EditModal(Guid patientId)
        {
            var patient = await _patientAppService.GetAsync(new EntityDto<Guid>(patientId));
            return PartialView("_EditModal", patient);
        }
        
    }
}
