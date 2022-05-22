using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels;

public class PersonListModelView
{
    public List<PersonModelView> People { get; set; }
    public int Count { get; set; }
}