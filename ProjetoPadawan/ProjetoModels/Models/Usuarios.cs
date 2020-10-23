namespace ProjetoModels.Models
{
    public class Usuarios : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Acesso { get; set; }
    }
}
