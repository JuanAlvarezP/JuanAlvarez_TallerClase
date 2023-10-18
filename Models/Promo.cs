namespace JuanAlvarez_TallerClase.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? PromoName { get; set; }
        public string? PromoDescription { get; set; }
        public int id { get; set; }
        public Burger? Burger { get; set; }
    }
}
