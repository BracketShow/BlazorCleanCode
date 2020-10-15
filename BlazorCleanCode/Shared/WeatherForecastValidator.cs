using System;
using FluentValidation;

namespace BlazorCleanCode.Shared
{

    public class WeatherForecastValidator 
        : AbstractValidator<WeatherForecast>
    {
        public WeatherForecastValidator()
        {
            RuleFor(w => w.Summary)
                .NotEmpty();
            RuleFor(w => w.Date)
                .GreaterThan(DateTime.Now);
        }
    }

}
