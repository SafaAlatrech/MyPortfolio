namespace Core.Entities
{
   public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public int Avtar { get; set; }
        public Address Address { get; set; }

    }
}
