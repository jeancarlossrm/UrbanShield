

// Classe que representa um usuario
public class Usuario
{
    // Property para armazenar o nome do usuario
    public string Nome { get; set; }
    // Property para armazenar o email do usuario
    public string Email { get; set; }
    // Property para armazenar a senha do usuario
    public string Senha { get; set; }
    // Construtor da classe
    public Usuario(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;

    }

}
