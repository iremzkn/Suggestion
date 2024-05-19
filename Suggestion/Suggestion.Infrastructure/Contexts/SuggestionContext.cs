using Microsoft.EntityFrameworkCore;
using Suggestion.Domain.Entities.PersonnelEntity;

namespace Suggestion.Infrastructure.Contexts;

public class SuggestionContext : DbContext
{
    public SuggestionContext()
    {
    }

    public SuggestionContext(DbContextOptions<SuggestionContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data source=YavuzC-NB\\SQLEXPRESS;initial catalog=Suggestion;trusted_connection=true;TrustServerCertificate=true;");
    }
    public virtual DbSet<PersonnelEntity> Personnel { get; set; }
}
