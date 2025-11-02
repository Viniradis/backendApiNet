namespace CadastroUsuarioAPI.Domain.Validation
{
    public static class LoginValidator
    {
        public static bool IsValid(string login, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(login))
            {
                error = "Login vazio";
                return false;
            }
            if (login.Length < 3 || login.Length > 50)
            {
                error = "Login deve ter entre 3 e 50 caracteres";
                return false;
            }
            return true;
        }
    }
}
