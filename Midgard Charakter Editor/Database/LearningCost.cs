using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midgard_Charakter_Editor.Database
{
	public class LearningCost
	{
		public int Id { get; set; }
		public int Value { get; set; }
		public int Easy { get; set; }
		public int Normal { get; set; }
		public int Hard { get; set; }
		public int VeryHard { get; set; }
		public Category Category { get; set; }
	}
}
