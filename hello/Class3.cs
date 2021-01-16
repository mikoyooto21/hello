/*using System;
using System.Collections.Generic;
using System.Text;

namespace hello
{
    enum Models { AUDI, VOLVO, NISSAN, VOLKSWAGEN, PORSHE, FORD}//метод перечисления
    class Cars //n новый класс
    {


        public int wheels = 4; //можно работать во всех классах
        private float speed; //только в єтом классе
        protected bool isWorking = true; //только в этом классе и классах наследниках

        public Models model;//ссылка на метод перечисления

        public static int test = 0;//


        public static void Test ()//
        {
            Console.Write("Hi!");//
        }
        public void setValues (float speed, bool isWorking)//
        {
            this.speed = speed;//
            this.isWorking = isWorking;//
        }

        public virtual void getValues()//метод который дает перезаписать весь метод в другом
        {
            Console.WriteLine("Car speed is: " + this.speed + ", car is working: " + this.isWorking);
        }

        public Cars (int wheels, float speed, bool isWorking)//метод карс который будет вмещать в себя 3 переменных
        {
            this.wheels = wheels;//ссылка на инт
            this.speed = speed;//ссылка на инт
            this.isWorking = isWorking;//ссылка на инт
        }

        public Cars() { }//создается новый метод для того чтобы другие классы и методы без значений не показывали ошибку

    }

    class Trucks : Cars//связываем класс тракс и класс карс для того чтобы в тракс добавить те же пременные что и в карс
    {
        public int pass;// метод в котором вводится новая переменная

        public Trucks(int wheels, float speed, bool isWorking, int pass) : base (wheels, speed, isWorking)//метод связывает тракс с карс. при этом в первых скобках вводятся переменные, а во вторых перекидываются те что известны в карс и нужны для тракс
        {
            this.pass = pass;//ссылка на метод, который ввел новую переменную
        }

        public override void getValues()//перезаписывающий метод, который перезаписывает 
        {
            base.getValues();//копирует гетвельюс с класса карс
            Console.WriteLine("Passangers: " + pass);//добавляет к гетвельюс кол-во пасажиров
        }

    }
    class Class3
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            string[] array = new string[3];
            arr[0] = 1;
            //Cars.test = 23;
            //Cars.Test();
            //Console.WriteLine(Cars.test);

            Trucks man = new Trucks(8, 130.5f, true, 3);//создается название переменной в классе тракс, которой даются новые значения для каждого из интов
            man.getValues();//переменная ссылается на инты для значений
            //Console.WriteLine(man.pass);

            Cars audi = new Cars(4, 230.5f, true); //массив ауди = выделение памяти для массива
            audi.model = Models.AUDI;//ссылка на модели

            //Console.WriteLine(audi.wheels); //вывод ауди.колеса (только колеса ибо они у нас паблик)

            audi.setValues(230.5f, true);//ставятся новые значения для ауди
            audi.getValues();//получаются инты

            Cars volvo = new Cars();//массив вольво = выделение памяти для нового массива
            volvo.wheels = 6;//вводим новое значение "чисто по приколу, шобб выебнуца"
            volvo.model = Models.VOLVO;//ссылка на модели

            //Console.WriteLine(volvo.wheels);//выводит новое значение переменной, которую мы показали в классе карс
            volvo.setValues(150.2f, false);//новые значения
            volvo.getValues();//получаются инты

            // int[,] arr = new int[3, 2] //3 - элемента, 2 - 2 элемента
            //{
            //   {2, 8}, {23,3}, {24,1} //элементы
            //};
            //тут начинается сортировка
            //for(int i = 0; i<3; i++) //длина первого массива
            //{
            //  for(int j = 0; j < 2; j++ ) //длина второго массива
            //{
            //  Console.Write(arr[i, j] + " "); //0 0, 1 1, 2 2 - попарно ставяться єлементы
            //}
            // Console.WriteLine(" ");
            // }
            //еще есть перебор чисел через форич, но мне впадлу его писать, ибо на метаните там все изи расписано, да и сложного там нет НИЧЕГО
            // List<int> numbers = new List<int>();//динамический массив
            //numbers.Add(23);//добавления первого числа
            //numbers.Add(2);//добавление второго числа

            //numbers.RemoveAt(1);//удаление числа с индексом 1(начиная с нуля!!!!)
            //numbers.Remove(23);//удаления числа из массива
            //for(int i = 0; i<numbers.Count; i++) //тут считаются числа
            //{
            //  Console.WriteLine(numbers[i]);
            //}

            //Print("Hi!"); //Вывод хай(это, кста ссылка на метод )
            //int num;//ввод нум для сумм
            //num = summ(4, 10);//ввод интов для сумм, то есть тут сразу мможно прировнять инт а и инт б к нуму. в скобочках пишутся их конкретные значения
            //Print(num);//вывод нум(это тоже)

            //в шарпе можно просто назвать методы одинаково и они будут отлично работать друг другу не мешая. заебись, что сказать(:(:(:
        }

        public static void Print (int str)//метод для ввода чисел
        {
            Console.WriteLine(str);//тут конкретно вывод происходит
        }
        public static void Print(string str)//метод для ввода строк
        {
            Console.WriteLine(str);//тут тоже вывод собсна
        }

        public static int summ (int a, int b)// метод для рачсчета тех чисел, что были заданны выше. кста, она еще и возвращает значение. а возвращать она будет результат.
        {
            int res;//переменная для результата, который будет выводится в итоге задачи метода
            res = a+b;//расчет чисел
            return res;//возвращение переменной. то есть, как я понимаю, тут не будет вывода а и б. тут будет вывод ИМЕННО результата. вернее, для этого ретурн не 0, а рес.
        }
    }
}
*/