/* 

// ********** 
// MANUAL TEST

using System;
using System.Collections.Generic;
using System.Text;
using Classes;

//****** Patient List
Patient patient1 = new Patient("Rafael", "Nadal", "diabetes");
Patient patient2 = new Patient("Novak", "Djokovic");
Patient patient3 = new Patient("Roger", "Federer", "short-sighted");




// Display individual patient information
patient1.DisplayInformation();
Console.WriteLine("");
patient2.DisplayInformation();
Console.WriteLine("");
patient3.DisplayInformation();
Console.WriteLine("");

// Update patient
patient1.updateUser("Rafa", "Nadal", "");
patient1.DisplayInformation();

Console.WriteLine("");

// Display patient list
Console.WriteLine(Patient.DisplayPatientList());
patient1.DisplayInformation();

// Remove a patient and display the list again
patient3.RemoveUser();
patient2.RemoveUser();
// patient1.RemoveUser();
Console.WriteLine(Patient.DisplayPatientList());

//****** Doctor List
List<Doctor> doctors = new List<Doctor>
{
    new Doctor("John", "Doe", "Cardiology"),
    new Doctor("Jane", "Smith", "Dermatology"),
    new Doctor("Emily", "Jones", "Emergency Medicine"),
    new Doctor("Michael", "Brown", "Family Medicine"),
    new Doctor("Sarah", "Davis", "Internal Medicine"),
    new Doctor("David", "Wilson", "Neurology"),
    new Doctor("Laura", "Garcia", "Obstetrics and Gynecology (OB/GYN)"),
    new Doctor("James", "Martinez", "Ophthalmology"),
    new Doctor("Anna", "Hernandez", "Pediatrics"),
    new Doctor("Robert", "Lopez", "Psychiatry")
};

foreach (var doctor in doctors)
{
    doctor.AddUser();
}

Console.WriteLine(Doctor.DisplayDoctorList());

//***** List of nurse
List<Nurse> nurses = new List<Nurse>
{
    new Nurse("Alice", "Johnson", "Cardiac Care Unit (CCU)"),
    new Nurse("Bella", "Williams", "Critical Care Unit (ICU)"),
    new Nurse("Catherine", "Brown", "Emergency Department (ED)"),
    new Nurse("Daisy", "Miller", "Geriatric Nursing"),
    new Nurse("Ella", "Davis", "Labor and Delivery (L&D)"),
    new Nurse("Fiona", "Wilson", "Medical-Surgical Nursing"),
    new Nurse("Grace", "Moore", "Neonatal Intensive Care Unit (NICU)"),
    new Nurse("Hannah", "Taylor", "Oncology Nursing"),
    new Nurse("Ivy", "Anderson", "Operating Room (OR)"),
    new Nurse("Julia", "Thomas", "Pediatric Nursing")
};

foreach (var nurse in nurses)
{
    nurse.AddUser();
}

Console.WriteLine(Nurse.DisplayNurseList());

// List of nurse department
List<string> nurseDepartments = new List<string>
{
    "Cardiac Care Unit (CCU)",
    "Critical Care Unit (ICU)",
    "Emergency Department (ED)",
    "Geriatric Nursing",
    "Labor and Delivery (L&D)",
    "Medical-Surgical Nursing",
    "Neonatal Intensive Care Unit (NICU)",
    "Oncology Nursing",
    "Operating Room (OR)",
    "Pediatric Nursing",
    "Post-Anesthesia Care Unit (PACU)",
    "Psychiatric Nursing",
    "Rehabilitation Nursing"
};

//****** Appointments


// Create Doctors
Doctor doctor1 = doctors[0];
Doctor doctor2 = doctors[1];
Doctor doctor3= doctors[2];

// Create DateTimes
DateTime dateTime1 = new DateTime(2024, 8, 7, 10, 0, 0);
DateTime dateTime2 = new DateTime(2024, 8, 8, 16, 0, 0);
DateTime dateTime3 = new DateTime(2024, 9, 9, 20, 0, 0);
DateTime dateTime4 = new DateTime(2024, 10, 12, 9, 0, 0);
DateTime dateTime5 = new DateTime(2024, 11, 15, 9, 0, 0);
DateTime dateTime6 = new DateTime(2024, 12, 25, 9, 0, 0);

// Test creating appointments
Appointment appointment1 = new Appointment(patient1, doctor1, dateTime1);
Appointment appointment2 = new Appointment(patient1, doctor2, dateTime2);
Appointment appointment3 = new Appointment(patient2, doctor1, dateTime3);
Appointment appointment4 = new Appointment(patient2, doctor2, dateTime4);

// Display Appointments
Console.WriteLine("Appointments after creation:");
Console.WriteLine(Appointment.DisplayAppointments(patient2));
Console.WriteLine(Appointment.DisplayAppointments(doctor2));


// Test updating an appointment
appointment1.updateAppointment(patient1, doctor1, dateTime5);
Console.WriteLine("\nAppointments after update:");
Console.WriteLine(Appointment.DisplayAppointments(patient1));

// Test removing an appointment
appointment1.removeAppointment();
Console.WriteLine("\nAppointments after removal:");
Console.WriteLine(Appointment.DisplayAppointments(patient2));

//****** Medical Records
// Test creating medical records
MedicalRecord record1 = new MedicalRecord(patient1, doctor1, "Flu", "Rest and hydration");
MedicalRecord record2 = new MedicalRecord(patient2, doctor2, "Allergy", "Antihistamines");

// Display medical records
Console.WriteLine("\nMedical Records after creation:");
Console.WriteLine(MedicalRecord.DisplayMedicalRecords(patient1));
Console.WriteLine(MedicalRecord.DisplayMedicalRecords(patient2));

// Test updating a medical record
record1.updateMedicalRecord("Severe Flu", "Rest, hydration, and antiviral medication");
Console.WriteLine("\nMedical Records after update:");
Console.WriteLine(MedicalRecord.DisplayMedicalRecords(patient1));

// Test removing a medical record
record1.removeMedicalRecord();
Console.WriteLine("\nMedical Records after removal:");
Console.WriteLine(MedicalRecord.DisplayMedicalRecords(patient1));

// *******

*/




using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Classes;

namespace MyHospitalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string? readResult;
            string menuSelection = "";
            string secondMenuSelection = "";
            string role = "";
            string firstName = "";
            string lastName = "";
            string specialty = "";
            string department = "";
            string appSelection = "";
            string redSelection = "";
            int index;
            Client client = new Client();


            // List of Doctors
            List<Doctor> doctors = new List<Doctor>
            {
                new Doctor("John", "Doe", "Cardiology"),
                new Doctor("Jane", "Smith", "Dermatology"),
                new Doctor("Emily", "Jones", "Emergency Medicine"),
                new Doctor("Michael", "Brown", "Family Medicine"),
                new Doctor("Sarah", "Davis", "Internal Medicine"),
                new Doctor("David", "Wilson", "Neurology"),
                new Doctor("Laura", "Garcia", "Obstetrics and Gynecology (OB/GYN)"),
                new Doctor("James", "Martinez", "Ophthalmology"),
                new Doctor("Anna", "Hernandez", "Pediatrics"),
                new Doctor("Robert", "Lopez", "Psychiatry")
            };

            foreach (var doctor in doctors)
            {
                doctor.AddUser();
            }

            // Doctor Specialty List
            List<string> medicalSpecialties = new List<string>
            {
                "allergy and immunology",
                "anesthesiology",
                "dermatology",
                "emergency medicine",
                "family medicine",
                "internal medicine",
                "neurology",
                "obstetrics and gynecology",
                "ophthalmology",
                "pediatrics",
                "psychiatry",
                "radiology",
                "surgery"
            };

            // List of Nurses
            List<Nurse> nurses = new List<Nurse>
            {
                new Nurse("Alice", "Johnson", "Cardiac Care Unit (CCU)"),
                new Nurse("Bella", "Williams", "Critical Care Unit (ICU)"),
                new Nurse("Catherine", "Brown", "Emergency Department (ED)"),
                new Nurse("Daisy", "Miller", "Geriatric Nursing"),
                new Nurse("Ella", "Davis", "Labor and Delivery (L&D)"),
                new Nurse("Fiona", "Wilson", "Medical-Surgical Nursing"),
                new Nurse("Grace", "Moore", "Neonatal Intensive Care Unit (NICU)"),
                new Nurse("Hannah", "Taylor", "Oncology Nursing"),
                new Nurse("Ivy", "Anderson", "Operating Room (OR)"),
                new Nurse("Julia", "Thomas", "Pediatric Nursing")
            };

            foreach (var nurse in nurses)
            {
                nurse.AddUser();
            }


            List<string> nurseDepartments = new List<string>
            {
                "Cardiac Care Unit (CCU)",
                "Critical Care Unit (ICU)",
                "Emergency Department (ED)",
                "Geriatric Nursing",
                "Labor and Delivery (L&D)",
                "Medical-Surgical Nursing",
                "Neonatal Intensive Care Unit (NICU)",
                "Oncology Nursing",
                "Operating Room (OR)",
                "Pediatric Nursing",
                "Post-Anesthesia Care Unit (PACU)",
                "Psychiatric Nursing",
                "Rehabilitation Nursing"
            };


            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the MyHospital app. Your options are:");
                Console.WriteLine(" 1. Create profile (available)");
                Console.WriteLine(" 2. Log In (N/A)");
                Console.WriteLine(" 3. Check Doctors List (available)");
                Console.WriteLine(" 4. Check Nurses List (available)");
                Console.WriteLine("Enter your selection number, or type \"exit\" to exit the program");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                switch (menuSelection)
                {
                    // Create Profile
                    case "1":


                        do
                        {
                            Console.WriteLine("\nWhat is your first name?");
                            firstName = Console.ReadLine();
                        } while (firstName == "");

                        do
                        {
                            Console.WriteLine("\nWhat is your last name?");
                            lastName = Console.ReadLine();
                        } while (lastName == "");



                        Console.WriteLine("\nSelect your role number:");
                        Console.WriteLine(" 1. Patient");
                        Console.WriteLine(" 2. Doctor");
                        Console.WriteLine(" 3. Nurse");

                        role = Console.ReadLine();
                        if (role != null)
                        {
                            role = role.ToLower();
                        }


                        switch (role)
                        {
                            case "1":
                                Console.WriteLine("\nWhat is your medical history?");
                                string medicalHistory = Console.ReadLine();
                                Console.WriteLine("\nYour profile has been created!\n");

                                // Create a client variable

                                client.CreateUser(UserRole.Patient, firstName, lastName);

                                User currentUser = client.GetUser();
                                if (currentUser is Patient patientUser)
                                {
                                    patientUser.MedicalHistory = medicalHistory;
                                }

                                break;

                            case "2":
                                Console.WriteLine("\nHere are the list of our specialties:");
                                for (int i = 0; i < medicalSpecialties.Count; i++)
                                {
                                    Console.WriteLine($" {i + 1}. {medicalSpecialties[i]}");
                                }
                                Console.WriteLine("\nWhat is your specialty?");
                                specialty = Console.ReadLine();
                                index = int.Parse(specialty);
                                Console.WriteLine("\nYour profile has been created!\n");

                                client.CreateUser(UserRole.Doctor, firstName, lastName);

                                currentUser = client.GetUser();
                                if (currentUser is Doctor doctorUser)
                                {
                                    doctorUser.Specialty = medicalSpecialties[index - 1];
                                }


                                break;

                            case "3":
                                Console.WriteLine("\nHere are the list of our specialties:");
                                for (int i = 0; i < nurseDepartments.Count; i++)
                                {
                                    Console.WriteLine($" {i + 1}. {nurseDepartments[i]}");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("\nWhat is your department?");
                                department = Console.ReadLine();
                                index = int.Parse(department);
                                Console.WriteLine("\nYour profile has been created!\n");

                                // Nurse nurse = new Nurse(firstName, lastName, nurseDepartments[index - 1]);

                                client.CreateUser(UserRole.Nurse, firstName, lastName);


                                currentUser = client.GetUser();
                                if (currentUser is Nurse nurseUser)
                                {
                                    nurseUser.Department = nurseDepartments[index - 1];
                                }

                                break;

                            default:
                                Console.WriteLine("Invalid selection, please try again\n");
                                break;
                        }

                        break;

                    // Log In
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Feature will be updated soon");
                        break;

                    // Doctor List
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine(Doctor.DisplayDoctorList());
                        break;

                    //Nurse List
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine(Nurse.DisplayNurseList());
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }

                if (menuSelection != "exit")
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }

                if (menuSelection == "1" || menuSelection == "2")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Your main menu options are:");
                        Console.WriteLine(" 1. Manage Appointment (available)");
                        Console.WriteLine(" 2. Manage Medical Record (N/A)");
                        Console.WriteLine(" 3. Manage Profile (N/A)");
                        Console.WriteLine("Enter your selection number, or type \"back\" to back");


                        secondMenuSelection = Console.ReadLine();
                        if (secondMenuSelection != null)
                        {
                            secondMenuSelection = secondMenuSelection.ToLower();
                        }

                        switch (secondMenuSelection)
                        {
                            case "1":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine(" 1. Schedule new appointment (available)");
                                    Console.WriteLine(" 2. Update appointment (N/A)");
                                    Console.WriteLine(" 3. Cancel appointment (N/A)");
                                    Console.WriteLine(" 4. Check your schedule (available)");
                                    Console.WriteLine("Enter your selection number, or type \"back\" to back");

                                    appSelection = Console.ReadLine();
                                    if (appSelection != null)
                                    {
                                        appSelection = appSelection.ToLower();
                                    }
                                    User currentUser = client.GetUser();

                                    switch (appSelection)
                                    {
                                        case "1":
                                            Console.Clear();

                                            if (currentUser is Patient currentPatient)
                                            {
                                                Console.WriteLine("\nWhich doctor would you like to meet?");
                                                Console.WriteLine(Doctor.DisplayDoctorList());

                                                string doctorSelection = Console.ReadLine();
                                                int doctorIndex;

                                                if (int.TryParse(doctorSelection, out doctorIndex) && doctorIndex > 0 && doctorIndex <= Doctor._allDoctors.Count)
                                                {
                                                    Console.WriteLine("\nPlease enter the appointment time and date in format:");
                                                    Console.WriteLine("yyyy-MM-dd-HH-mm");

                                                    string timeInput = Console.ReadLine();
                                                    DateTime dateTime;

                                                    if (DateTime.TryParseExact(timeInput, "yyyy-MM-dd-HH-mm", null, System.Globalization.DateTimeStyles.None, out dateTime))
                                                    {
                                                        dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0);

                                                        Doctor selectedDoctor = Doctor._allDoctors[doctorIndex - 1];
                                                        client.CreateAppointment(currentPatient, selectedDoctor, dateTime);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Invalid date format. Please enter in the format: Year-Month-Day-Hour-Minute.");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid doctor selection.");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Only patients can schedule appointments.");
                                            }
                                            break;

                                        case "2":
                                            Console.WriteLine();
                                            Console.WriteLine("Feature will be updated soon");
                                            break;

                                        case "3":
                                            Console.WriteLine();
                                            Console.WriteLine("Feature will be updated soon");
                                            break;

                                        case "4":
                                            Console.Clear();
                                            if (currentUser is Patient newPatient)
                                            {
                                                Console.WriteLine("\nYour scheduled appointments are:");
                                                Console.WriteLine(Appointment.DisplayAppointments(newPatient));
                                            }
                                            else if (currentUser is Doctor newDoctor)
                                            {
                                                Console.WriteLine("\nYour scheduled appointments are:");
                                                Appointment.DisplayAppointments(newDoctor);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Your role does not allow viewing appointments.");
                                            }
                                            break;

                                        default:
                                            Console.WriteLine("Please enter valid selection!");
                                            break;
                                    }

                                    if (appSelection != "back")
                                    {
                                        Console.WriteLine("Press Enter to continue...");
                                        Console.ReadLine();
                                    }

                                } while (appSelection != "back");


                                break;

                            case "2":
                                Console.WriteLine();
                                Console.WriteLine("Feature will be updated soon");
                                break;

                            case "3":
                                Console.WriteLine();
                                Console.WriteLine("Feature will be updated soon");
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Invalid selection, please try again.");
                                break;
                        }
                    } while (secondMenuSelection != "back");
                }

            } while (menuSelection != "exit");


        }
    }
}