namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1, 2, 3, 4
            Area(2);
            Area(3, 4);
            Area(3, 4, 5);
            Area(3, 4, 5, 2);

            // Task a
            Calculator(34, 65, '+');

            // Task b
            MyMethod(6);

            // Task c
            NamePrinter("Nihad");
            NamePrinter("Nihad", "Jafarov");
            NamePrinter("Nihad", "Jafarov", "Shukur");
        }
        #region Task 1, 2, 3, 4
        static void Area(int r)
        {
            int p = 3;
            int s = p*r*r;
            Console.WriteLine("Cevrenin sahesi: " + s);
        }
        static void Area(int a, int b)
        {
            int s = a*b;
            Console.WriteLine("Duzbucaqlinin sahesi: " + s);
        }
        static void Area(int a, int b, int c)
        {
            int s = 2*(a * b + a * c + b * c);
            Console.WriteLine("Duzbucaqli paralelpipedin tam sethinin sahesi: " + s);
        }
        static void Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            int s = p * r;
            Console.WriteLine("Ucbucaqlinin daxiline cekilmis cevrenin sahesi: " + s);
        }
        #endregion 

        #region Task a, b, c
        // Task a. Method yaradirsiz 2 eded ve 1 operator('+','-','*','/') qebul edir. Qebul etdiyi operatora uygun a v' b ədədləri üzərində hesablama aparib alinan deyeri qaytarır.
        static void Calculator(int num1, int num2,char operation)
        {
            switch (operation)
            {
                case '+':
                    int result = num1 + num2;
                    Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                    break;
            }     
        }
        // Task a

        //Task b Method yaradırsız əgər methoda bir eded gonderilirse hemin ededin kvadratını, iki eded gonderilirse 1ci ədədi ikinci ədəd qədər qüvvətinə yüksəldirsiz.
        static void MyMethod(int num1, int num2 = 2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= num1;
            }
            Console.WriteLine(result);
        }
        //Task b

        //Task c Methodlar yaradirsiz. Methoda ad gonderende adi ekrana cixardir(Sabir), ad ve soyad gonderende soyadi adi ekrana cixardir(Guliyev Sabir), ad,soyad ve ata adı göndərildikdə adin baş hərfi nöqtə soyad ata adi ekrana cixardirsiz(S.Guliyev Mehti). Methodlarin adi eyni olmalıdır.
        static void NamePrinter(string name)
        {
            Console.WriteLine(name);
        }
        static void NamePrinter(string name, string surname)
        {
            Console.WriteLine(surname + " " + name);
        }
        static void NamePrinter(string name, string surname, string fatherName)
        {
            Console.WriteLine("" + name[0] + '.' + surname + ' ' + fatherName);
        }
        //Task c
        #endregion
    }
}