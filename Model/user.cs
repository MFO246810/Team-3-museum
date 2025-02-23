using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team_3_mueseum.Model{

	public class user {
		public int UserID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
}
}