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
        string Noe_Diplom;
        /// <summary>
        /// تاریخ اخذ مدرک دیپلم دانشجو
        /// </summary>
        DateTime Tarikhe_Akhze_diplom;
        /// <summary>
        /// معدل دیپلم دانشجو
        /// </summary>
        short Moadel_Diplom;
        /// <summary>
        /// محل اخذ دیپلم که از اجزای زیر تشکیل شده است
        /// 1.شهر
        /// 2.ناحیه
        /// 3.نام دبیرستان
        /// </summary>
        struct Mahale_Akhze_diplom
        {
            string Shahr;
            string Nahiye;
            string Name_dabirestan;
        }
        /// <summary>
        /// متغیر محل اخذ دیپلم
        /// </summary>
        Mahale_Akhze_diplom Mahale_akhze_Diplom;
        /// <summary>
        /// نوع پیش دانشگاهی یکی از مقادیر زیر است
        /// 1.ریاضی و فیزیک
        /// 2.علوم تجربی
        /// 3.علوم انسانی
        /// </summary>
        string Noe_PishDaneshgahi;
        /// <summary>
        /// تاریخ اخذ مدرک پیش دانشگاهی دانشجو
        /// </summary>
        DateTime Tarikhe_Akhze_PishDaneshgahi;
        /// <summary>
        /// معدل پیش دانشگاهی دانشجو
        /// </summary>
        short Moadel_Pishdaneshgahi;
        /// <summary>
        /// محل اخذ پیش دانشگاهی که از اجزای زیر تشکیل شده است
        /// 1.شهر
        /// 2.ناحیه
        /// 3.نام دبیرستان
        /// </summary>
        struct Mahale_Akhze_Pishdaneshgahi
        {
            string Shahr;
            string Nahiye;
            string Name_dabirestan;
        }
        /// <summary>
        /// متغیر محل اخذ دیپلم
        /// </summary>
        Mahale_Akhze_Pishdaneshgahi Mahale_Akhze_PishDaneshgahi;
        

    }
}
