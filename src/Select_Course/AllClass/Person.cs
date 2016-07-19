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
        public string First_Name_Fa{ get; set; }

        /// <summary>
        /// نام شخص به انگلیسی
        /// </summary>
        public string First_Name_Eng { get; set; }

        /// <summary>
        /// نام خانوادگی شخص به فارسی
        /// </summary>
        public string Last_Name_Fa { get; set; }

        /// <summary>
        /// نام خانوادگی شخص به انگلیسی
        /// </summary>
        public string Last_Name_Eng { get; set; }

        /// <summary>
        /// نام پدر شخص به فارسی
        /// </summary>
        public string Father_Name_Fa { get; set; }

        /// <summary>
        /// نام پدر شخص به انگلیسی
        /// </summary>
        public string Father_Name_Eng { get; set; }

        /// <summary>
        /// تاریخ تولد شخص به شمسی
        /// </summary>
        public DateTime Date_Of_Birth_Sh { get; set; }

        /// <summary>
        /// تاریخ تولد شخص به میلادی
        /// </summary>
        public DateTime Date_Of_Birth_Mi { get; set; }

        /// <summary>
        /// کد ملی شخص
        /// </summary>
        public long National_Code { get; set; }

        /// <summary>
        /// شماره شناسنامه شخص
        /// </summary>
        public long Birth_Certificate_Number { get; set; }

        /// <summary>
        /// محل صدور شناسنامه شخص
        /// </summary>
        public string Location_Register { get; set; }

        /// <summary>
        /// محل تولد شخص
        /// </summary>
        public string Place_Of_Birth { get; set; }

        /// <summary>
        /// سری و سریال شناسنامه شخص
        /// </summary>
        public string Series_and_serial_Of_Birth_Certificate { get; set; }

        /// <summary>
        /// تابعیت شخص
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// شماره گذرنامه شخص
        /// </summary>
        public long Passport_Number { get; set; }

        /// <summary>
        /// شماره کارت هویت شخص
        /// </summary>
        public long Identity_Card_Number { get; set; }

        /// <summary>
        /// دین شخص
        /// </summary>
        public string Religion { get; set; }

        /// <summary>
        /// مذهب شخص
        /// </summary>
        public string Religion_Of { get; set; }

        /// <summary>
        /// وضعیت تاهل شخص
        /// </summary>
        public bool Marriage { get; set; }

        /// <summary>
        /// ایمیل شخص
        /// </summary>
        public string Email { get; set; }
       
        /// <summary>
        /// آدرس شخص
        /// </summary>
        public struct Adress
        {
           public string Contry;
           public string United;
           public string City;
           public string full;
        }
        public Adress Addres { get; set; }

        /// <summary>
        /// شماره تلفن شخص
        /// </summary>
        public string Phone_Number { get; set; }
    }
}
