using ClubBrugge.Erp.Application;
using ClubBrugge.Erp.Application.Matches.Queries;
using ClubBrugge.Erp.Domain.Dtos;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
        // Register GraphQL types and add the GraphQL server
        builder.Services
            .AddGraphQLServer()
            .AddQueryType<RootQuery>()
            .AddType<ClubBrugge.Erp.Domain.Dtos.MatchType>()
            .AddType<CompetitionType>()
            .AddType<SeasonType>()
            .AddType<HomeTeamType>()
            .AddType<AwayTeamType>()
            .AddType<CompetitionStageType>()
            .AddType<StadiumType>()
            .AddType<RefereeType>()
            .AddType<CountryType>()
            .AddType<ManagerType>()
            .AddType<MatchPlayerStatsType>();

        var app = builder.Build();

        // Seeder
        //using (var scope = app.Services.CreateScope())
        //{
        //    ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        //    await DataSeeder.LoadMatchDataAsync(dbContext);
        //    await DataSeeder.LoadMatchPlayerStatsDataAsync(dbContext);
        //}

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.UseCors();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGraphQL();
        });

        app.Run();
    }
}