using FluentValidation;
using ApiProjectKampi.WebApi.Entities;
namespace ApiProjectKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin")
                                       .MinimumLength(2).WithMessage("Ürün Adı en az 2 karakter olmalıdır!")
                                       .MaximumLength(50).WithMessage("Ürün Adı en fazla 50 karakter olmalıdır!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez")
                                             .MaximumLength(500).WithMessage("Ürün Açıklaması en fazla 500 karakter olmalıdır!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyatı boş geçmeyin")
                                .GreaterThan(0).WithMessage("Fiyat 0'dan küçük olamaz!");
                                


        }
    }
}
