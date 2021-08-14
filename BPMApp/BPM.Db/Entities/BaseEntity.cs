using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BpmApp.Db.Entities
{
    public abstract class BaseEntity
    {
        [Key] // это ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // генерится базой
        public Guid Id { get; set; }
    }
}
