using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select_Course.AllClass
{
    public class Dars_info
    {
        /// <summary>
        /// انواع درس نظر 
        ///1.اختیاری
        ///2.تخصصی
        ///3.عمومی
        /// </summary>
        public enum anvae_dars { Ekhtiyari, Takhasosi, Omumi }
        /// <summary>
        /// انواع درس را تعریف 
        ///1.اختیاری
        ///2.تخصصی
        ///3.عمومی
        /// </summary>
        public enum Noe_vahed { Amali, Teori, Amali_Teori }
        /// <summary>
        /// نوع درس از نظر تئوری و
        /// عملی و تخصصی و اختیاری و عمومی بودن
        /// و تعداد واحد های عملی و تئوری
        /// </summary>
        public anvae_dars noe_dars { get; set; }
        public Noe_vahed noe_vahed { get; set; }
        public int Tedade_Amali { get; set; }
        public int Tedade_Teori { get; set; }
    }
    public class Course
    {
        /// <summary>
        /// نام درس
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// کد درس
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// تعداد واحد درس
        /// </summary>
        public short tedade_Vahed { get; set; }
        /// <summary>
        /// منبع درس
        /// </summary>
        public string Manba { get; set; }
        /// <summary>
        /// اطلاعات درس از قبیل نوع درس
        /// </summary>
        public Dars_info noe_dars{ get; set; }
        /// <summary>
        /// اساتیدی که این درس توسط انان تدریس می شود
        /// </summary>
        public ICollection<Teacher> Teachers { get; set; }

    }
}
