namespace WebMovie.Models
{
	public class Review
	{
		public int Id { get; set; }
		public int MovieId { get; set; }
		public int CustomerId { get; set; }
		public string ReviewText {  get; set; }
		public byte Rating { get; set; }
		//public Review Review { get; set; }
	}
}
