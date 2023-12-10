namespace API.Entities; // immer name Spacing nutzen wo/welcher Ordner man das her hat das macht er nicht automatisch


public class AppUser
{
    public int Id { get; set; }
    // [Required]
    public string UserName { get; set; }
    public byte[] PasswordHash { get; set; } 
    public byte[] PasswordSalt { get; set; } 


}
