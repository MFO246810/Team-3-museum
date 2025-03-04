using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team_3_mueseum.Model{

	public class user {
		[Key]
		public int user_id { get; set; }
		public string username{get; set;} 
		public string Email { get; set; }
		public string Password { get; set; }
}
}