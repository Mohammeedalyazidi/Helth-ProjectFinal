using Helth_ProjectFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Helth_ProjectFinal.Controllers
{
    public class PedometerController : Controller
    {
        private readonly PedometerDbContext _context;

        public PedometerController(PedometerDbContext context)
        {
            _context = context;
        }

        public ActionResult Steps()
        {
            return View(new StepsModel());
        }

        [HttpPost]
        public ActionResult Steps(StepsModel model)
        {
            // Calculate the calories burned based on the number of steps
            const double STEP_CONST = 0.04;
            model.CaloriesBurned = model.Steps * STEP_CONST;

            // Add the model to the database
            _context.steps.Add(model);
            _context.SaveChanges();

            // Update the model and return the view with the updated data
            return View(model);
        }


        public async Task<IActionResult> Details()
        {
            List<StepsModel> records = await _context.steps.ToListAsync();
            return View(records);
        }
    }

}