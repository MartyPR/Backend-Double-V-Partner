namespace Challenge_Double_V_Partners.Models
{
    public class ProductoDeseado
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int UserId { get; set; } // Puede ser un campo para identificar al usuario.
    }
}
