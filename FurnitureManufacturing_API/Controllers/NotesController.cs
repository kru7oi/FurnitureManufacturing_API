using FurnitureManufacturing_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureManufacturing_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        FurnitureManufacturingContext db = new();

        public NotesController(FurnitureManufacturingContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetNotes()
        {
            try
            {
                var notes = await db.Notes
                .Include(n => n.User)
                .ToListAsync();

                var result = notes.Select(n => new NoteResponse
                {
                    Id = n.NoteId,
                    TitleUser = $"{n.Title} - {n.User.Login}",
                    Content = n.Content,
                    FormattedDate = n.CreatedAt.ToString("dd.MM.yyyy")
                }).ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = $"Ошибка подключения к базе данных: {ex.Message}" });
            }
        }
    }
}
