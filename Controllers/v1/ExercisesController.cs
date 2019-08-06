using System.Collections.Generic;
using System.Threading.Tasks;
using Gymlog.Domain.Models;
using Gymlog.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gymlog.Api.Controllers.v1
{
    [
        ApiController,
        Route("api/v1/Exercises")
    ]
    public class ExercisesControllers: ControllerBase
    {
        private ExerciseContext _context;
        public ExercisesControllers(ExerciseContext context)
        {
            _context = context;
            _context.InitDefaults();
        }

        public async Task<ActionResult<IEnumerable<Exercise>>> Get() => await _context.Exercises.ToListAsync();
    }
}