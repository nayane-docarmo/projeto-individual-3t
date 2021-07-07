using Gerenciar_API.Domains;
using Microsoft.EntityFrameworkCore;

namespace API_Gerenciar.Context
{
    public class GerenciarContext : DbContext
    {
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sala_Equipamento> Sala_Equipamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CAKSN4N\SQLEXPRESS;Initial Catalog=Gerenciar;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
//criado os dominios se cria o contexto para criar as tabelas 
//console gerenciador de pacotes--
//comando para criar as tabelas/migrations : Add-Migration InitialCreate 
//comando para criar o database (ex Gerenciar) : update-database
