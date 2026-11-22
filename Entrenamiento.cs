class Entrenamiento
{
    public double Distancia {get; set;}
    public double Tiempo {get; set;}

    public Entrenamiento(double distancia, double tiempo)
    {
        Distancia = distancia;
        Tiempo = tiempo;
    }
    // Minutos por kilómetro (la distancia se valida como > 0 al registrar)
    public double Ritmo()
    {
        return Tiempo / Distancia;
    }

    public override string ToString()
    {
        return $"Distancia: {Distancia} km | Tiempo: {Tiempo} min | Ritmo: {Ritmo():F2} min/km";
    }
}