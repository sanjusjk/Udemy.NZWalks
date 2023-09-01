using System.ComponentModel.DataAnnotations;

namespace Udemy.NZWalks.API.Models.Domain
{
    public class Difficulty
    {
        public Guid Id{ get; set; }

        public string Name { get; set; }
    }
}
