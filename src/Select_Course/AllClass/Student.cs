using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select_Course.AllClass
{
    public class Student:Person
    {
        /// <summary>
        /// نوع دیپلم یکی از مقادیر زیر است
        /// 1.ریاضی و فیزیک
        /// 2.علوم تجربی
        /// 3.علوم انسانی
        /// 4.معرف اسلامی
        /// 5.فنی و حرفه ای
        /// </summary>
        public string Noe_Diplom{ get; set; }

        /// <summary>
        /// تاریخ اخذ مدرک دیپلم دانشجو
        /// </summary>
        public DateTime Tarikhe_Akhze_diplom{ get; set; }

        /// <summary>
        /// معدل دیپلم دانشجو
        /// </summary>
        public short Moadel_Diplom{ get; set; }
        
        /// <summary>
        /// محل اخذ دیپلم که از اجزای زیر تشکیل شده است
        /// 1.شهر
        /// 2.ناحیه
        /// 3.نام دبیرستان
        /// </summary>
        public struct Mahale_Akhze_diplom
        {
            public string Shahr;
            public string Nahiye;
            public string Name_dabirestan;
        }
        /// <summary>
        /// متغیر محل اخذ دیپلم
        /// </summary>
        public Mahale_Akhze_diplom Mahale_akhze_Diplom{ get; set; }

        /// <summary>
        /// نوع پیش دانشگاهی یکی از مقادیر زیر است
        /// 1.ریاضی و فیزیک
        /// 2.علوم تجربی
        /// 3.علوم انسانی
        /// </summary>
        public string Noe_PishDaneshgahi{ get; set; }

        /// <summary>
        /// تاریخ اخذ مدرک پیش دانشگاهی دانشجو
        /// </summary>
        public DateTime Tarikhe_Akhze_PishDaneshgahi{ get; set; }

        /// <summary>
        /// معدل پیش دانشگاهی دانشجو
        /// </summary>
        public short Moadel_Pishdaneshgahi{ get; set; }
    
        /// <summary>
        /// محل اخذ پیش دانشگاهی که از اجزای زیر تشکیل شده است
        /// 1.شهر
        /// 2.ناحیه
        /// 3.نام دبیرستان
        /// </summary>
        public struct Mahale_Akhze_Pishdaneshgahi
        {
            public string Shahr;
            public string Nahiye;
            public string Name_dabirestan;
        }
        /// <summary>
        /// متغیر محل اخذ دیپلم
        /// </summary>
        public Mahale_Akhze_Pishdaneshgahi Mahale_Akhze_PishDaneshgahi{ get; set; }
        /// <summary>
        /// لیست درس های انتخاب شده توسط دانشجو
        /// </summary>
        public ICollection<SelectedCourse> selected_courses{ get; set;}

    }
}
