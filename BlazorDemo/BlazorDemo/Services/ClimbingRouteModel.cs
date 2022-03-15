using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Services
{
    public class ClimbingRouteModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Grade { get; set; }

        public int SendCounter { get; set; }
    }
}
