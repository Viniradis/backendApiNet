using System.Collections.Generic;
using System.Linq;

namespace CadastroUsuarioAPI.Domain.PasswordPolicy
{
    public interface IPasswordPolicyService
    {
        (bool IsValid, IEnumerable<string> FailedRules) Validate(string password);
    }

    public class PasswordPolicyService : IPasswordPolicyService
    {
        private readonly IEnumerable<IPasswordPolicyStrategy> _strategies;
        public PasswordPolicyService(IEnumerable<IPasswordPolicyStrategy> strategies)
        {
            _strategies = strategies;
        }

        public (bool IsValid, IEnumerable<string> FailedRules) Validate(string password)
        {
            var failed = new List<string>();
            foreach (var s in _strategies)
            {
                if (!s.IsSatisfied(password)) failed.Add(s.Describe());
            }
            return (!failed.Any(), failed);
        }
    }
}
