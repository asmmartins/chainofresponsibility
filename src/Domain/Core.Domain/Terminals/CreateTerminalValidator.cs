using FluentValidation;

namespace Core.Domain.Terminals
{
    internal class CreateTerminalValidator : AbstractValidator<Terminal> 
    {
        public CreateTerminalValidator() 
        {
            AddIdRule();
            AddNameRule();            
            AddLocalizationRule();
        }

        private void AddIdRule()
        {
            RuleFor(t => t.Id).NotNull();
            RuleFor(t => t.Id).NotEmpty();
        }

        private void AddNameRule()
        {
            RuleFor(t => t.Name).NotNull();
            RuleFor(t => t.Name).NotEmpty();
        }        

        private void AddLocalizationRule()
        {
            RuleFor(t => t.Localization).NotNull();            
        }
    }
}
