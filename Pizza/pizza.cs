using System;

namespace LEXTRAIT_Hugo_TP6_ST2TDR
{
	public class Pizza
	{
		private String name;
		private String size;
		private String dough;
		private String[] topping;

		public void setName(string name)
		{
			this.name = name;
		}

		public void setSize(string size)
		{
			this.size = size;
		}

		public void setDough(string dough)
		{
			this.dough = dough;
		}
		public void setTopping(string[] topping)
		{
			this.topping = topping;
		}

		override
		public String ToString()
		{
			String output = "Pizza {" + name + "}\nSize = " + size + ",\nDough = " + dough;
            if (topping.Length > 0) // if topings exists
            {
				output += ",\nTopping = ";
				foreach (var x in topping)
				{
					output += x + ", ";
				}
			}
			return output+ "\n-----------------------------\n";
		}
	}

}
