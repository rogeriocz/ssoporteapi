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

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetMedicationById(int id)
        //{
        //    var medication = await _medicationRepository.GetMedicationByIdAsync(id);
        //    if (medication == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(medication);
        //}

    }
}
