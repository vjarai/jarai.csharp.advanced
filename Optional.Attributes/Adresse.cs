

namespace Optional.Attributes
{
    internal class Adresse
    {
        [Required(ErrorMessage = "Name darf nicht leer sein.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Plz darf nicht leer sein.")]
        public string Plz { get; set; }

        [Required(ErrorMessage = "Ort darf nicht leer sein.")]
        public string Ort { get; set; }

        [Required(ErrorMessage = "Email darf nicht leer sein.")]
        [Email(ErrorMessage = "Email must @ enthalten.")]
        public string  Email { get; set; }
    }
}
