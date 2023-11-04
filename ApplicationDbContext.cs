using Microsoft.EntityFrameworkCore;
// ################## Configuração do Banco de dados usando EntityFrameworkCore
public class ApplicationDbContext: DbContext {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Fluent API - é precisso rodar as migrations para aplicar as config abaixo.(msm que ja tenha rodado antes)
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(500).IsRequired(false);
        builder.Entity<Product>()
            .Property(p => p.Name).HasMaxLength(150).IsRequired();
        builder.Entity<Product>()
            .Property(p => p.Code).HasMaxLength(20).IsRequired();

        builder.Entity<Tag>()
            .Property(p => p.Name).HasMaxLength(10).IsRequired();
    }
}
