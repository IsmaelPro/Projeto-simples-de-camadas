using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }
        public string CreatedBy { get; set; }
        public string ModifyBy { get; set; }
    }
}