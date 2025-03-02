namespace TrabajoFinal.Model
{
    public interface ISuperHeroe
    {
        string Nombre { get; set; }
        string PoderEspecial { get; set; }
        int Fuerza { get; set; }
        int Salud { get; set; }

        string Atacar();
        string Defender();
    }
}
