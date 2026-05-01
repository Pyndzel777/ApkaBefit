using System.ComponentModel.DataAnnotations;

namespace befitlaurent.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Display (Name ="Waga")]
        public int Weight { get; set; }
        [Display(Name = "Liczba Serii")]
        public int NumOfSeries { get; set; }
        [Display(Name = "Liczba Powtórzeń")]
        public int NumOfReps { get; set; }
        [Display(Name = "Typ Ćwiczenia")]
        public int ExerciseTypeId { get; set; }
        public virtual ExerciseType? ExerciseType { get; set; }
        [Display(Name = "Sesja")]
        public int SessionId {  get; set; }
        public virtual Session? Session { get; set; }
    }
}
