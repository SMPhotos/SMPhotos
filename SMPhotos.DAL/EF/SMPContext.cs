using System.Data.Entity;

namespace SMPhotos.DAL
{
	public class SMPContext : DbContext
	{
		public SMPContext()
			: base("name=SMPContext")
		{
		}

		public virtual DbSet<Album> Album { get; set; }
		public virtual DbSet<Image> Image { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			modelBuilder.Configurations.Add(new UserMap());
			modelBuilder.Configurations.Add(new ImageMap());
			modelBuilder.Configurations.Add(new AlbumMap());
		}
	}
}
