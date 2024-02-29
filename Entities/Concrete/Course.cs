using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDetails {  get; set; }

        // Bir kategori de birden çok kurs olabilir. fakat her kursun sadece kendine özgü kategorisi
        //vardır. O yüzden ilişkiyi kurs nesnesinde kurdum.
        public int CategoryId { get; set; }

        // Bir eğitmen de birden çok kurs verebilir. fakat her kursun sadece bir eğitmeni vardır
        //O yüzden ilişkiyi kurs nesnesinde kurdum.
        public int InstructorId { get; set; }

    }
}
