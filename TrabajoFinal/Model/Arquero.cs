namespace TrabajoFinal.Model
{
    public class Arquero : ISuperHeroe
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;

        public Arquero(string nombre) 
        {
            Nombre = nombre;
            PoderEspecial = "Flecha de Luz";
            Fuerza = 8;
        }

        public string Atacar()
        {
            return $"{Nombre} lanzó una {PoderEspecial}";
        }

        public string Defender()
        {
            return $"{Nombre} esquivó el ataque";
        }
    }
}
