using System;
using System.Collections.Generic;

namespace Cyberozunu.WebApi.Models
{
    public partial class StudentDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string RollNumber { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
