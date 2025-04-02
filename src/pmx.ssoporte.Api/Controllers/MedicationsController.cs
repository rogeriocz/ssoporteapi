using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pmx.ssoporte.Application.Interfaces.FharmacyMedication;
using pmx.ssoporte.Domain.Entities;

namespace pmx.ssoporte.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationsController : ControllerBase
    {
        private readonly IMedicationRepository _medicationRepository;

        public MedicationsController(IMedicationRepository medicationRepository)
        {
            _medicationRepository = medicationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetMedication()
        {
            var medications = await _medicationRepository.GetAllMedicationsAsync();
            return Ok(medications);
        }

    }
}
