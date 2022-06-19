using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Suma
{
    [Required(ErrorMessage = "Campo Requerido!")]
    public int Numero1 { get; set; }
    [Required(ErrorMessage = "Campo Requerido!")]
    public int Numero2 { get; set; }
    [Editable(false)]
    public int Resultado { get; set; }

}