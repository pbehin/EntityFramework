﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Microsoft.Data.Entity.Metadata.Internal;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Metadata.ModelConventions
{
    public class ConcurrencyCheckAttributeConvention : PropertyAttributeConvention<ConcurrencyCheckAttribute>
    {
        public override void Apply(InternalPropertyBuilder propertyBuilder, ConcurrencyCheckAttribute attribute)
        {
            Check.NotNull(propertyBuilder, nameof(propertyBuilder));
            Check.NotNull(attribute, nameof(attribute));

            propertyBuilder.ConcurrencyToken(true, ConfigurationSource.DataAnnotation);
        }
    }
}
