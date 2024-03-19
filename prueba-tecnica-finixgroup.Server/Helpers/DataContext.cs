namespace prueba_tecnica_finixgroup.Helpers;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using prueba_tecnica_finixgroup.Server.Models;
using System.Net.Http;
using System.Text.Json;
using System.Xml;

public class DataContext : DbContext {

    public DbSet<Bank> Banks { get; set; }

    protected readonly IConfiguration Configuration;
    public DataContext(IConfiguration configuration) {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        // in memory database used for simplicity, change to a real db for production applications
        options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        options.EnableSensitiveDataLogging();
    }

    // Fix banks validation but outside this method, just a temporal quick and dirty solution...
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // Generating timestams of OnCreate, OnUpdate & OnDelete

        Console.WriteLine("On model creating...");
        modelBuilder.Entity<Bank>()
            .Property(b => b.CreatedAt)
            .HasDefaultValueSql("date()");

        modelBuilder.Entity<Bank>()
            .Property(b => b.UpdatedAt)
            .HasDefaultValueSql("date()");

        // Generating unique id and GUID
        modelBuilder.Entity<Bank>()
            .Property(b => b.id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Bank>()
            .Property(b => b.uid)
            .HasConversion(
                v => v.ToString(),
                v => Guid.Parse(v))
            .HasDefaultValueSql("lower(hex(randomblob(16)))") // SQLite: Generate a random GUID
            .ValueGeneratedOnAdd();
    }
        public void SeedData() { 
            var banks = Seed();
            if(banks != null) {
                foreach(var bank in banks) {
                    var existingBank = Banks.Find(bank.id);

                    if(existingBank == null) {
                        Banks.Add(bank);
                    } else {
                        Entry(existingBank).CurrentValues.SetValues(bank);
                    }
                }
                SaveChanges();
            }
    }

    private Bank[] Seed() {
        Console.WriteLine("Seeding data...");
        using(var httpClient = new HttpClient()) {
            httpClient.BaseAddress = new Uri("https://random-data-api.com/api/v2/");
            HttpResponseMessage response = httpClient.GetAsync("banks?size=100").Result;

            if(response.IsSuccessStatusCode) {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                var banks = JsonSerializer.Deserialize<Bank[]>(jsonResponse);

                Console.WriteLine(jsonResponse);
                return banks;
            } else {
                Console.WriteLine("Failed to fetch data from the API. Status code: " + response.StatusCode);
                return null;
            }
        }
    }
   
    // O/*verriding "SaveChanges" for timestamp implementation, perfomance is compromised tho. 
    public override int SaveChanges() {
        var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
        foreach(var entry in entries) {
            if(entry.Entity is Bank myEntity) {                 // In case we are applying timestamps to Model 'Bank'
                myEntity.UpdatedAt = DateTime.Now;
            }
        }
        return base.SaveChanges();
    }
    
}