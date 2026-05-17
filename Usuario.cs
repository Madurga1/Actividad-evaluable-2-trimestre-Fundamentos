class Usuario
{
    public string Email {get; set;}
    public string Contraseña {get; set;}
    public List<Entrenamiento> Entrenamientos { get; set; } = new List<Entrenamiento>();

    public Usuario(string email, string contraseña)
    {
        Email = email;
        Contraseña = contraseña;
    }
}
