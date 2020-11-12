namespace API.Entities
{
    public class AppUser
    {
        // EF prepoznaje "Id" i automatski ga postavlja kao id po konvenciji
        public int Id { get; set; }
        public string UserName { get; set; }
       
    }
}