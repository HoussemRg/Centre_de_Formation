using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation.Models
{
    public class Participation
    {
        public Participation() { }

        [Key]
        public int IdParticipation { get; set; }

        // Foreign key properties for the composite key of Session


        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}