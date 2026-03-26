using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BussnisLayer_Clinic_;




namespace Clinic_Console
{
    internal class Program
    {
       
        

        //public static void FindPaitient(int PaitientID)
        //{
        //    clsPaitients Paitient1 = clsPaitients.GetPaitentByPatientID(PaitientID);
           
        //    if(Paitient1 != null )
        //    {
        //        Console.WriteLine("PatientID :" + Paitient1.PatientID);
        //        Console.WriteLine("FirstName :" + Paitient1.FirstName);
        //        Console.WriteLine("LastName  :" + Paitient1.LastName);
        //        Console.WriteLine("Email     :" + Paitient1.Email);
        //        Console.WriteLine("Phone     :" + Paitient1.Phone);
        //        Console.WriteLine("Date      :" + Paitient1.DateOfBirth);
        //        Console.WriteLine("Gendor    :" + Paitient1.Gendor);
        //        Console.WriteLine("Address   :" + Paitient1.Address);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Could'nt found Person with ID[" + PaitientID + "]");
        //    }
        //}

        //public static void AddNewPaitient()
        //{

        //    clsPaitients Paitient= new clsPaitients();

        //    Paitient.FirstName = "agf";
        //    Paitient.LastName = "asdf";
        //    Paitient.DateOfBirth = new DateTime(2000,2,1);
        //    Paitient.Gendor = "M";
        //    Paitient.Email = "asf@gamil.com";
        //    Paitient.Phone = "055754708105";
        //    Paitient.Address = "sf-asdf Arabia";

        //    if (Paitient.SavePaitient())
        //    {
        //        Console.WriteLine("Contact Saved Seccussfully With PaitientID="+Paitient.PatientID);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed Savein");
        //    }


        //}
       
        //public static void UpdatePaitient(int PaitientID)
        //{
        //    clsPaitient Paitient1 = clsPaitient.GetPatientByPatentID(PaitientID);
           
        //    Paitient1.FirstName = "Hisham";
        //    Paitient1.LastName = "Ammar";
        //    Paitient1.DateOfBirth = new DateTime(2011, 1, 12);
        //    Paitient1.Gendor = "M";
        //    Paitient1.Email = "HishamAmmar@gamil.com";
        //    Paitient1.Phone = "05544322";
        //    Paitient1.Address = "Dammam-Saudi Arabia";
        //    if(Paitient1.SavePateint())
        //    {
        //        Console.WriteLine("Paitient1 Updated Seccussfully");
        //    }else
        //    {
        //        Console.WriteLine("Filed Updated");
        //    }
        //}
        //public static void PatientList()
        //{

        //    DataTable Dt = clsPaitient.PatientList();

        //    foreach(DataRow row in Dt.Rows)
        //    {
        //        if (Dt != null)
        //        {
        //            Console.WriteLine($"PatientID :{row["PatientID"]}");
        //            Console.WriteLine($"PersonID : {row["PersonID"]} ");
        //            Console.WriteLine($"FirstName : {row["FirstName"]} ");
        //            Console.WriteLine($"LastName : {row["LastName"]} ");
        //            Console.WriteLine($"DateOfBirth : {row["DateOfBirth"]} ");
        //            Console.WriteLine($"Gender : {row["Gender"]} ");
        //            Console.WriteLine($"Email : {row["Email"]} ");
        //            Console.WriteLine($"Phone Number : {row["PhoneNumber"]} ");
        //            Console.WriteLine($"Address : {row["Address"]} ");


        //        }
        //    }





        //}

        //public static void DeletePatient(int PatientID)
        //{
        //    if(clsPaitients.DeletePaitient(PatientID))
        //    {
        //        Console.WriteLine("Delete Complate Seccussfully");
        //    }else
        //    {
        //        Console.WriteLine("Filed Delete");
        //    }
        //}

        //public static void FindDoctor(int DoctorID)
        //{
        //    clsDoctor Doctor1 = clsDoctor.GetDoctorByDoctorID(DoctorID);

        //    if (Doctor1 != null)
        //    {
        //        Console.WriteLine("DoctorID :" +  Doctor1.DoctorID);
        //        Console.WriteLine("Specailization :" + Doctor1.Specialization);
        //        Console.WriteLine("FirstName :" + Doctor1.FirstName);
        //        Console.WriteLine("LastName  :" + Doctor1.LastName);
        //        Console.WriteLine("Email     :" + Doctor1.Email);
        //        Console.WriteLine("Phone     :" + Doctor1.Phone);
        //        Console.WriteLine("Date      :" + Doctor1.DateOfBirth);
        //        Console.WriteLine("Gendor    :" + Doctor1.Gendor);
        //        Console.WriteLine("Address   :" + Doctor1.Address);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Could'nt found Person with ID[" + DoctorID + "]");
        //    }
        //}

        //public static void AddNewDoctor()
        //{

        //    clsDoctor Doctor = new clsDoctor();

        //    Doctor.FirstName = "sdfg";
        //    Doctor.LastName = "dsfg";
        //    Doctor.DateOfBirth = new DateTime(1997, 10, 23);
        //    Doctor.Gendor = "F";
        //    Doctor.Email = "fdg@Gamil.com";
        //    Doctor.Phone = "456765ds";
        //    Doctor.Address = "Dammam - Soudi Arabia";
        //    Doctor.Specialization = "Cardiology";

        //    if (Doctor.SaveDoctor())
        //    {
        //        Console.WriteLine("Contact Saved Seccussfully With DoctorID=" +Doctor.DoctorID);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed Saveing");
        //    }


        //}
        public static void ViewAppointment()
        {
            DataTable Dt = clsAppointment.AppointmentList();

            foreach(DataRow row in Dt.Rows)
            {
                if (Dt != null)
                {
                    Console.WriteLine($"DoctorID :{row["AppointmentID"]}");

                    Console.WriteLine($"PersonID : {row["PatientID"]} ");
                    Console.WriteLine($"FirstName : {row["DoctorID"]} ");
                    Console.WriteLine($"LastName : {row["AppointmentDateTime"]} ");
                    Console.WriteLine($"DateOfBirth : {row["AppointmentStatus"]} ");
                    Console.WriteLine($"Gender : {row["MedicalRecordID"]} ");
                    Console.WriteLine($"Email : {row["PaymentID"]} ");
                   
                    Console.WriteLine("\n\n\n");
                }
            }
        }

        public static void UpdateDoctor(int DoctorID)
        {
            clsDoctor Doctor = clsDoctor.GetDoctorByDoctorID(DoctorID);

            Doctor.FirstName = "Maha";
            Doctor.LastName = "Maher";
            Doctor.DateOfBirth = new DateTime(1998, 10, 23);
            Doctor.Gendor = "F";
            Doctor.Email = "Maha1998@Gamil.com";
            Doctor.Phone = "0554388223";
            Doctor.Address = "Dammam - Soudi Arabia";
            Doctor.Specialization = "Cardiology";
            if (Doctor.SaveDoctor())
            {
                Console.WriteLine("Doctor Updated Seccussfully");
            }
            else
            {
                Console.WriteLine("Filed Updated");
            }
        }
        public static void DoctorsList()
        {

            DataTable Dt = clsDoctor.DoctorList();

            foreach (DataRow row in Dt.Rows)
            {
                if (Dt != null)
                {
                    Console.WriteLine($"DoctorID :{row["DoctorID"]}");
                
                    Console.WriteLine($"PersonID : {row["PersonID"]} ");
                    Console.WriteLine($"FirstName : {row["FirstName"]} ");
                    Console.WriteLine($"LastName : {row["LastName"]} ");
                    Console.WriteLine($"DateOfBirth : {row["DateOfBirth"]} ");
                    Console.WriteLine($"Gender : {row["Gender"]} ");
                    Console.WriteLine($"Email : {row["Email"]} ");
                    Console.WriteLine($"Phone Number : {row["PhoneNumber"]} ");
                    Console.WriteLine($"Address : {row["Address"]} ");
                    Console.WriteLine($"Specailization : {row["Specialization"]} ");
                    Console.WriteLine("\n\n\n");
                }
            }





        }
        public static void Updateappointment()
        {
           clsAppointment appointmen=clsAppointment.FindAppointment(9);
            appointmen.PaitentID = 1;
            appointmen.DoctorID = 1;
            appointmen.AppointmentDateTime= DateTime.Now;
            appointmen.AppointmentStatus = "Complited";
            appointmen.MedicalRecordID = 1;
            appointmen.PaymentID = 1;

            if(appointmen.SaveAppointment())
            {
                Console.WriteLine("Saved seccuss");
            }else
            {
                Console.WriteLine("Fialed");
            }
        }

        public static void DeleteDoctor(int DoctorID)
        {
            if (clsDoctor.DeleteDoctor(DoctorID))
            {
                Console.WriteLine("Delete Complate Seccussfully");
            }
            else
            {
                Console.WriteLine("Filed Delete");
            }
        }

         
        static void Main(string[] args)
        {
            //ViewAppointment();
            Updateappointment();
            Console.ReadKey();
        }
    }
}
