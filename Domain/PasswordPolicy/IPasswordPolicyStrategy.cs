namespace CadastroUsuarioAPI.Domain.PasswordPolicy
{
    public interface IPasswordPolicyStrategy
    {
        bool IsSatisfied(string password);
        string Describe();
    }
}
