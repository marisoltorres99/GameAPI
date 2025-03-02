namespace TrabajoFinal.Model
{
    public class Guerrero: ISuperHeroe
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;

        public Guerrero(string nombre)
        {
            Nombre = nombre;
            PoderEspecial = "Hacha Pesada";
            Fuerza = 5;
        }

        public string Atacar()
        {
            return $"{Nombre} ejecutó el ataque {PoderEspecial}";
        }

        public string Defender()
        {
            return $"{Nombre} se defendió con su escudo";
        }
    }
}
