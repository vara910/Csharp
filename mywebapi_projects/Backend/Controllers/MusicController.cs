using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/music")]
[ApiController]
public class MusicController : ControllerBase
{
    [HttpGet("recommend")]
    public IActionResult GetRecommendedSongs([FromQuery] string mood)
    {
        var recommendations = new Dictionary<string, List<string>>
        {
            { "happy", new List<string> { "Happy - Pharrell Williams", "Can't Stop the Feeling - Justin Timberlake" } },
            { "sad", new List<string> { "Someone Like You - Adele", "Fix You - Coldplay" } },
            { "energetic", new List<string> { "Eye of the Tiger - Survivor", "Uptown Funk - Bruno Mars" } },
            { "relaxed", new List<string> { "Weightless - Marconi Union", "Slow Dancing in a Burning Room - John Mayer" } }
        };

        return recommendations.ContainsKey(mood) ? Ok(recommendations[mood]) : Ok(new List<string>());
    }
}
