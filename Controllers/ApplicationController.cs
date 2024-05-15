using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using CapitalPlacementAPI.Infrastructure.IRepositories;
using CapitalPlacementAPI.Models.Dtos;
using CapitalPlacementAPI.Models.Entities;

namespace CapitalPlacementAPI.Controller;
[Route("api/[controller]")]
[ApiController]
public class ApplicationController : ControllerBase
{
    private readonly IApplicationFormRepository _applicationFormRepository;
    private IMapper _mapper;
    public ApplicationController(IApplicationFormRepository applicationFormRepository, IMapper mapper)
    {
        _applicationFormRepository = applicationFormRepository;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ApplicationForm>>> GetApplicationForms()
    {
        return Ok(await _applicationFormRepository.GetAsync());
    }
     [HttpPost]
    public async Task<ActionResult<ApplicationForm>> PostApplicationForm(ApplicationFormDto applicationFormDto)
    {
        var applicationForm = new ApplicationForm
        {
            ProgramTitle = applicationFormDto.ProgramTitle,
            ProgramDescription = applicationFormDto.ProgramDescription,
            
            
        };

        var createdForm = await _applicationFormRepository.AddAsync(applicationForm);
        return CreatedAtAction(nameof(GetApplicationForms), new { id = createdForm.Id }, createdForm);
    }
     [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationForm(string id, ApplicationFormDto applicationFormDto)
        {
            var existingApplicationForm = await _applicationFormRepository.GetAsync(id);
            if (existingApplicationForm == null)
            {
                return NotFound();
            }

            existingApplicationForm.ProgramTitle = applicationFormDto.ProgramTitle;
            existingApplicationForm.ProgramDescription = applicationFormDto.ProgramDescription;

            await _applicationFormRepository.UpdateAsync(id, existingApplicationForm);
            return NoContent();
        }
}
