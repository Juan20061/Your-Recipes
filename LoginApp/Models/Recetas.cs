using SQLite;
using LoginApp.Models;


namespace LoginApp.Models
{
    [Table("receta")]
    public class Recetas
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("ruta_imagen")]
        public string? Imagen { get; set; }

        [Column("nombre_receta")]
        public string? NombreReceta { get; set; }

        [Column("ingredientes")]
        public string? Ingredientes { get; set; }

        [Column("pasos")]
        public string? Pasos { get; set; }

       

        [Column("tiempo_preparacion")]
        public string? TiempoPreparacion { get; set; }

        [Column("dificultad")]
        public int Dificultad { get; set; }
    }

}
