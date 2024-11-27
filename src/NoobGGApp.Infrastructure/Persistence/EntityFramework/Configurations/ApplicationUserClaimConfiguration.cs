﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoobGGApp.Domain.Identity;

namespace NoobGGApp.Infrastructure.Persistence.EntityFramework.Configurations;

public sealed class ApplicationUserClaimConfiguration : IEntityTypeConfiguration<ApplicationUserClaim>
{
    public void Configure(EntityTypeBuilder<ApplicationUserClaim> builder)
    {
        // Primary key
        builder.HasKey(rc => rc.Id);

        // Maps to the AspNetUserClaims table
        builder.ToTable("application_user_claims");
    }
}
