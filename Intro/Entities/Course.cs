using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class Course
{
	//Properties
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
    public double Price { get; set; }
}
