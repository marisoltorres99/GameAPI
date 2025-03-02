namespace TrabajoFinal.Model
{
    public static class SuperHeroeFactory
    {
        public static ISuperHeroe CrearSuperHeroe(string nombre, string tipo)
        {
            switch (tipo.ToLower())
            {
                case "arquero":
                    return new Arquero(nombre);
                case "mago":
                    return new Mago(nombre);
                case "guerrero":
                    return new Guerrero(nombre);
                default:
                    throw new ArgumentException("Tipo de héroe no soportado");
            }

        }
    }
}
