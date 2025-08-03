using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class Categoria : IValidatableObject
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }

    [MaxLength(100)] // atributo referente ao EF Core
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    [PrimeiraLetraMaiuscula(ErrorMessage = "minha mensagem")]
    [BindNever]
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    [Required(ErrorMessage = "campo obrigatório")]
    [RegularExpression("", ErrorMessage = "valor inválido")]
    [Range(1, 10, ErrorMessage = "o valor deve estar entre {1} e {2}")]
    [CreditCard]
    [Url]
    [Phone]
    [Compare("<outra propriedade>")]
    [StringLength(10, MinimumLength = 4)]
    public int Ignorar { get; set; }

    public ICollection<Produto>? Produtos { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // throw new NotImplementedException();

        if (!string.IsNullOrEmpty(this.Nome))
        {
            var primeiraLetra = this.Nome[0].ToString();
            if (primeiraLetra != primeiraLetra.ToUpper())
            {
                yield return new ValidationResult("A primeira letra deve ser maiúscula", new[] { nameof(this.Nome) });
            }
        }
    }
}