

namespace Optional.Attributes
{
   
    internal class Adresse
    {
        [Required(ErrorMessage = "Name darf nicht leer sein.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Plz darf nicht leer sein.")]
        [Plz(ErrorMessage = "PLZ muss 5 zeichen enthalten.")]

        public string Plz { get; set; }

        [Plz]
        [Required(ErrorMessage = "Ort darf nicht leer sein.")]
        public string Ort { get; set; }

        [Required(ErrorMessage = "Email darf nicht leer sein.")]
        [Email(ErrorMessage = "Email must @ enthalten.")]
        public string  Email { get; set; }
    }
}
