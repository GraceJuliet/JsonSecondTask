using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTaskTwo.Models;
using Newtonsoft.Json;

namespace JsonTaskTwo.ViewModels
{
    public class MedicalViewModel : INotifyPropertyChanged
    {

        Medical ObjMedical;
        Sections ObjSections;



        public static Medical md = new Medical()
        {

        };


        public static string strResultJson = JsonConvert.SerializeObject(md);
       //Console.WriteLine(strResultJson);

       // var str=File.WriteAllText(@"C:\Users\Grace Juliet\Desktop\WPF-C# Tasks\medical.json",strResultJson);
        public MedicalViewModel()
        {
            ObjMedical = new Medical();

            ObjSections = new Sections();




        }




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
