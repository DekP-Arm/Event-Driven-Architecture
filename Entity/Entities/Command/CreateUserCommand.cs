namespace EDA.Command
{
    public class CreateUserCommand
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }
    }
}