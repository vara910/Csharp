using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/songs")]
public class SongsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSongs()
    {
        var songs = new List<object>
        {
            new { Id = 1, Title = "Shape of You", Artist = "Ed Sheeran" },
            new { Id = 2, Title = "Levitating", Artist = "Dua Lipa" },
            new { Id = 3, Title = "Blinding Lights", Artist = "The Weeknd" },
            new { Id = 4, Title = "Perfect", Artist = "Ed Sheeran" }
        };

        return Ok(songs);
    }
}
