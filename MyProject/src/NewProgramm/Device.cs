using System;

namespace NewProgramm
{
    public class Device
    {
//Поля класса
        private string manufacture = ""; //Motorola, CipherLab, Honeywell etc.
        private string model = ""; //MC2180, MC3090, MC3190 etc.
        private string partNumber = ""; //MC3190-R123456789 etc.
        private string type = ""; //TSD, Notebook, Printer, 
        private string statInspect = ""; //new, diagnosted, waiting repairing, repared
        private string extInfo = "";
//Методы класса
        public string Manufacture {
            get => this.manufacture;
            set => this.manufacture = value; 
        }        
        public string Model {
            get => this.model;
            set => this.model = value; 
        }
        public string PartNumber {
            get => this.partNumber;
            set => this.partNumber = value; 
        }  
        public void WriteToDB(Device neDev){

        }
        public void ReadFromDB (){

        }
        public void ShowInfo () {
            Console.WriteLine("Тип оборудования: {0}",type);
            Console.WriteLine("Производитель: {0}",manufacture);
            Console.WriteLine("Модель: {0}",model);
            Console.WriteLine("Дополнительная информация: {0}",extInfo);
            Console.WriteLine("");
            Console.WriteLine("");
        }




//Инструктор
        public Device (string _manufacture, string _model, string _partNumber){
            manufacture = _manufacture;
            model = _model;
            partNumber = _partNumber;
        }

        public Device () {
            Console.Write("* Введите производителя оборудования: ");
            manufacture = Console.ReadLine();
            
            Console.Write("* Введите модель оборудования: ");
            model = Console.ReadLine();
            
            Console.Write("Введите производственный номер оборудования: ");
            partNumber = Console.ReadLine();

            Console.WriteLine("Выберите тип оборудования: ");
            Console.WriteLine("1. ТСД \n2. Принтер\n3. Еще какая-то хрень");
            switch (Convert.ToInt32(Console.ReadLine())){
                case 1:
                type = "dct";
                break;
                case 2:
                type = "printer";
                break;
                case 3:
                type = "sumthing else";
                break;
            }




            statInspect = "new";

            
            
            
            
            
            
            partNumber = Console.ReadLine();



        }
        
        public Device (string _methodOfCreation){
            if (_methodOfCreation == "Inscpections"){
                
            } else{

            }

        }

    }
}