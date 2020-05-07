namespace Domain
{
    public class Combos
    {
        public int IdCliente { get; set; }
        public string NombreCli { get; set; }
        public string ApellidoCli { get; set; }
        public int IdProducto { get; set; }
        public string NombreP { get; set; }
        public int PrecioP { get; set; }
        public int CantidadP { get; set; }

        public Combos(int idC, string nomC, string apeC, int idP,string nomP,int preP, int cantP )
        {
            this.IdCliente = idC;
            this.NombreCli = nomC;
            this.ApellidoCli = apeC;
            this.IdProducto = idP;
            this.NombreP = nomP;
            this.PrecioP = preP;
            this.CantidadP = cantP;
        }
        public Combos() { }

    }
}
