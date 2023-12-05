namespace MonAPI.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Pseudo { get; set; } = string.Empty;//pour eviter nullable

        public DateTime DateNaiss { get; set; }

        //constructeur
        public Utilisateur (int id, string pseudo, DateTime dateNaiss)
        {
            Id = id;
            Pseudo = pseudo;
            DateNaiss = dateNaiss;
        }
    }
}
