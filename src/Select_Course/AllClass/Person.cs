using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Select_Course.AllClass
{
    public class Person
    {
        /// <summary>
        /// نام شخص به فارسی
        /// </summary>
        internal string First_Name_Fa;
        /// <summary>
        /// نام شخص به انگلیسی
        /// </summary>
        internal string First_Name_Eng;
        /// <summary>
        /// نام خانوادگی شخص به فارسی
        /// </summary>
        internal string Last_Name_Fa;
        /// <summary>
        /// نام خانوادگی شخص به انگلیسی
        /// </summary>
        internal string Last_Name_Eng;
        /// <summary>
        /// نام پدر شخص به فارسی
        /// </summary>
        internal string Father_Name_Fa;
        /// <summary>
        /// نام پدر شخص به انگلیسی
        /// </summary>
        internal string Father_Name_Eng;
        /// <summary>
        /// تاریخ تولد شخص به شمسی
        /// </summary>
        internal DateTime Date_Of_Birth_Sh;
        /// <summary>
        /// تاریخ تولد شخص به میلادی
        /// </summary>
        internal DateTime Date_Of_Birth_Mi;
        /// <summary>
        /// کد ملی شخص
        /// </summary>
        internal long National_Code;
        /// <summary>
        /// شماره شناسنامه شخص
        /// </summary>
        internal long Birth_Certificate_Number;
        /// <summary>
        /// محل صدور شناسنامه شخص
        /// </summary>
        internal string Location_Register;
        /// <summary>
        /// محل تولد شخص
        /// </summary>
        internal string Place_Of_Birth;
        /// <summary>
        /// سری و سریال شناسنامه شخص
        /// </summary>
        internal string Series_and_serial_Of_Birth_Certificate;
        /// <summary>
        /// تابعیت شخص
        /// </summary>
        internal string Nationality;
        /// <summary>
        /// شماره گذرنامه شخص
        /// </summary>
        internal long Passport_Number;
        /// <summary>
        /// شماره کارت هویت شخص
        /// </summary>
        internal long Identity_Card_Number;
        /// <summary>
        /// دین شخص
        /// </summary>
        internal string Religion;
        /// <summary>
        /// مذهب شخص
        /// </summary>
        internal string Religion_Of;
        /// <summary>
        /// وضعیت تاهل شخص
        /// </summary>
        internal bool Marriage;
        /// <summary>
        /// ایمیل شخص
        /// </summary>
        internal string Email;
        /// <summary>
        /// آدرس شخص
        /// </summary>
        internal struct Adress
        {
            string Contry;
            string United;
            string City;
            string full;
        }
        internal Adress Addres;
        /// <summary>
        /// شماره تلفن شخص
        /// </summary>
        internal string Phone_Number;
    }
}
