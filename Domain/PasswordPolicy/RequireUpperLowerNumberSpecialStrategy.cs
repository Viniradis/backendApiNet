using System;
using System.Linq;

namespace CadastroUsuarioAPI.Domain.PasswordPolicy
{
    public class RequireUpperLowerNumberSpecialStrategy : IPasswordPolicyStrategy
    {
        public bool IsSatisfied(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));
            return hasUpper && hasLower && hasDigit && hasSpecial;
        }

        public string Describe() => "Deve conter letra maiúscula, minúscula, número e caractere especial";
    }
}
