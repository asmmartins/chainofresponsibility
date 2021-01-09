﻿using Core.Domain.Shared.Validators;
using Core.Domain.Shared.ValueObjects;
using System.Collections.Generic;

namespace Core.Domain.Aggregates.Terminals.Localizations
{
    public class Localization : ValueObject
    {
        public string Latitude { get; private set; }
        public string Longitude { get; private set; }

        protected Localization() { }

        public static Localization Create(string latitude, string longitude)
        {
            var localization = new Localization()
            {
                Latitude = latitude?.Trim(),
                Longitude = longitude?.Trim()
            };

            localization.ValidateAndThrow(new CreateLocalizationValidator());

            return localization;
        }

        protected override IEnumerable<object> GetEqualsProperties()
        {
            yield return Latitude;
            yield return Longitude;
        }
    }
}
