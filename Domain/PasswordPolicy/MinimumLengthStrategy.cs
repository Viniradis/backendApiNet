using System;

namespace CadastroUsuarioAPI.Domain.PasswordPolicy
{
    public class MinimumLengthStrategy : IPasswordPolicyStrategy
    {
        private readonly int _min;
        public MinimumLengthStrategy(int min = 8) => _min = min;
        public bool IsSatisfied(string password) => !string.IsNullOrEmpty(password) && password.Length >= _min;
        public string Describe() => $"Mínimo {_min} caracteres";
    }
}
