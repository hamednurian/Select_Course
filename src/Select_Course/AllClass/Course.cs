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
        internal enum anvae_dars { Ekhtiyari, Takhasosi, Omumi }
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
        anvae_dars noe_dars;
        Noe_vahed noe_vahed;
        int Tedade_Amali;
        int Tedade_Teori;
    }
    public class Course
    {
        Course()
        {
           
        }
        /// <summary>
        /// نام درس
        /// </summary>
        string Name;
        /// <summary>
        /// کد درس
        /// </summary>
        int Code;
        /// <summary>
        /// تعداد واحد درس
        /// </summary>
        short tedade_Vahed;
        /// <summary>
        /// منبع درس
        /// </summary>
        string Manba;

        Dars_info dars_information;
        static void Main(string[] args)
        {
            
        }
    }
}
