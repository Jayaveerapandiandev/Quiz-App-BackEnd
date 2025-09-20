using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Email { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public int Score { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public int  time { get; set; }


    }

    public class particpantResult {
        public int participantId { get; set; }

        public int score { get; set; }

        public int timeTaken { get; set; }
    }

}
