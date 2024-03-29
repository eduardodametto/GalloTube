using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models;
[Table("VideoTag")]
public class VideoTag
{
    [Key, Column(Order = 1)]
    public int MovieId { get; set; }
    [ForeignKey("VideoId")]
    public Video Video{ get; set; }

    [Key, Column(Order = 2)]
    public byte TagId { get; set; }
    [ForeignKey("TagId")]
    public Tag Tag { get; set; }
}
