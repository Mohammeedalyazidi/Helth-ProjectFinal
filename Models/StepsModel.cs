namespace Helth_ProjectFinal.Models
{
    public class StepsModel
    {
        public int Id { get; set; }
        public int Steps { get; set; }
        public double CaloriesBurned { get; set; }
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
