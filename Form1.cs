using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_USKOV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Stopwatch stopwatch2 = new Stopwatch();

        private void buttonAdlai_Click(object sender, EventArgs e)
        {
                
        }

        // Метод для вычисления периметра эллипса с использованием точной формулы Джеймса Айвори
        static double CalculateEllipsePerimeterWithJamesIvory(double a, double b, int precision)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double p = Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
            stopwatch.Stop();
            return Math.Round(p, precision);
            
        }

        // Метод для вычисления периметра эллипса с использованием формулы Фридриха Бесселя
        static double CalculateEllipsePerimeterWithBessel(double a, double b, int precision)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            double m = Math.Sqrt((a - b) * (a + b)) / (a + b);
            double p = Math.PI * (a + b) * (1 + (3 * m * m) / (10 + Math.Sqrt(4 - 3 * m * m)));
            stopwatch1.Stop();
            return Math.Round(p, precision);
        }

        private void buttonAdlai_Click_1(object sender, EventArgs e)
        {
            // Ввод длин полуосей эллипса
            Console.Write("Введите длину большой полуоси a: ");
            double a = double.Parse(textBoxA.Text);

            Console.Write("Введите длину малой полуоси b: ");
            double b = double.Parse(textBoxB.Text);

            // Ввод точности вычислений
            Console.Write("Введите желаемую точность вычислений (количество знаков после запятой): ");
            int precision = int.Parse(textBoxPers.Text);

            // Рассчитываем периметр эллипса
            double pIvory = CalculateEllipsePerimeterWithJamesIvory(a, b, precision);
            double pBessel = CalculateEllipsePerimeterWithBessel(a, b, precision);

            // Выводим результаты
            Console.WriteLine($"Периметр эллипса с полуосями a = {a:0.###} и b = {b:0.###}:");
            Console.WriteLine($"  с использованием точной формулы Джеймса Айвори: {pIvory}");
            Console.WriteLine($"  с использованием формулы Фридриха Бесселя: {pBessel}");
            //Console.WriteLine(stopwatch);
        }
    }
}
