using ECommerceAPI.Application.ViewModels.ProductVMs;
using FluentValidation;

namespace ECommerceAPI.Application.Validators.Products
{
    public class ProductCreateValidator : AbstractValidator<ProductCreateVM>
    {
        public ProductCreateValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Fill the name area!")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Product name can be between 5 and 150 characters. ");

            RuleFor(product => product.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Fill the stock area!")
                .Must(stock => stock >= 0)
                    .WithMessage("Product's stock information cannot be negative!");

            RuleFor(product => product.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Fill the price area!")
                .Must(price => price >= 0)
                    .WithMessage("Product's price information cannot be negative!");

        }   
    }
}
