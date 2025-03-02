namespace TrabajoFinal.Model
{
    public class Mago : ISuperHeroe
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;

        public Mago(string nombre)
        {
            Nombre = nombre;
            PoderEspecial = "Bola de Fuego";
            Fuerza = 5;
        }

        public string Atacar()
        {
            return $"{Nombre} lanzó el poder {PoderEspecial}";
        }

        public string Defender()
        {
            return $"{Nombre} se defendió con un escudo mágico";
        }
    }
}
