using BookClubApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClubApp.Entity.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; } //bir kitap bir yazara aittir
        public Author Author { get; set; } //navigation property

        public ICollection<Category> categories { get; set; } = new HashSet<Category>(); //bir kitap birden fazla kategoriye ait olabilir, bu yüzden ICollection kullanıyoruz.

    }
}
