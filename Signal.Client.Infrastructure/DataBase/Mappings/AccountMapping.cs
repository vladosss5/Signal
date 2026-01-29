using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Signal.Client.Core.DataBaseModels;

namespace Signal.Client.Infrastructure.DataBase.Mappings;

public class AccountMapping : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        throw new NotImplementedException();
    }
}