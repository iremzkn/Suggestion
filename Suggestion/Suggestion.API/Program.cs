using Microsoft.EntityFrameworkCore;
using Suggestion.Business.Abstract.PersonnelService;
using Suggestion.Business.Concrete.PersonnelService;
using Suggestion.Infrastructure.Contexts;
using Suggestion.Infrastructure.DataAccess.Abstract.Personnel;
using Suggestion.Infrastructure.DataAccess.Concrete.EntityFramework.Personnel;

var builder = WebApplication.CreateBuilder(args);

#region DbContext
builder.Services.AddDbContext<SuggestionContext>(options =>
{
    options.UseSqlServer("Data source=YavuzC-NB\\SQLEXPRESS;initial catalog=Suggestion;trusted_connection=true;TrustServerCertificate=true;");
});
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Personnel
builder.Services.AddScoped<IPersonnelRepository, PersonnelRepository>();
builder.Services.AddScoped<IPersonnelService, PersonnelService>();
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
