namespace SMPhotos.DAL
{
	public partial class Image
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int AlbumId { get; set; }
		public virtual Album Album { get; set; }
	}
}