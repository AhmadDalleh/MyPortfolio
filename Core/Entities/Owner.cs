namespace Core.Entities
{
   public class Owner : EntityBase 
    {
        public string FullName {  get; set; }

        public string Profil {  get; set; }

        public string Avater {  get; set; }

        public Address Address { get; set; }
    }
}
