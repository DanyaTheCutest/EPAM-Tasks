﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class UI : Repository
    {
        
        public UI()
        {
            Greet();
        }
        public void Greet()
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1: Добавить фигуру");
                Console.WriteLine("2: Вывести фигуры");
                Console.WriteLine("3: Очистить холст");
                Console.WriteLine("4: Выход");
                var input = ReadIntInput();

                if (input == 4)
                    break;
                HandleInput(input);
            }
        }
        public void HandleInput(int input)
        {
            switch (input)
            {
                case 1: 
                    Add();
                    break;
                case 2:
                    GetAll();
                    break;
                case 3:
                    Clear();
                    break;               
            }              
        }
        private void Add()
        {
            Console.WriteLine("Какую фигуру добавить?");
            Console.WriteLine("1: Круг");
            Console.WriteLine("2: Треугольник");
            Console.WriteLine("3: Квадрат");
            Console.WriteLine("4: Прямоугольник");
            Console.WriteLine("5: Кольцо");
            Console.WriteLine("6: Вернуться назад");
            CreateFigure(ReadIntInput());
        }
        private new void GetAll()
        {
            foreach (var item in figures)
            {
                Console.WriteLine(item);
            }
        }
        private void CreateFigure(int input)
        {
            switch (input)
            {
                case 1: CreateCircle();
                    break;
                case 2: CreateTriangle();
                    break;
                case 3: CreateSquare();
                    break;
                case 4: CreateRectangle();
                    break;
                case 5: CreateRing();
                    break;
                case 6: 
                    break;
                
            }
        }
        
        private void CreateCircle()
        {
            Console.WriteLine("Введите координату центра х: ");
            double x = ReadDoubleInput();
            Console.WriteLine("Введите координату центра y: ");
            double y = ReadDoubleInput();
            Console.WriteLine("Введите радиус: ");
            double r = ReadDoubleInput();
            figures.Add(new Circle(x,y,r));
        }
        private void CreateRing()
        {
            Console.Write("Введите координату центра x: ");
            double x = ReadDoubleInput();
            Console.Write("Введите координату центра y: ");
            double y = ReadDoubleInput();
            Console.Write("Введите внешний радиус кольца: ");
            double outer = ReadDoubleInput();
            Console.Write("Введите внутренний радиус: ");
            double inner = ReadDoubleInput();
            figures.Add(new Ring(new Circle(x,y,inner), new Circle(x,y,outer)));
        }
        private void CreateSquare()
        {
            Console.Write("Введите координаты угла A: \nx: ");
            double xA = ReadDoubleInput();
            Console.Write("y: ");
            double yA = ReadDoubleInput();
            Console.Write("Введите координаты угла B: \nx: ");
            double xB = ReadDoubleInput();
            Console.Write("y: ");
            double yB = ReadDoubleInput();
            Console.Write("Введите координаты угла C: \nx: ");
            double xC = ReadDoubleInput();
            Console.Write("y: ");
            double yC = ReadDoubleInput();
            Console.Write("Введите координаты угла D: \nx: ");
            double xD = ReadDoubleInput();
            Console.Write("y: ");
            double yD = ReadDoubleInput();
            figures.Add(new Square(new Point(xA, yA), new Point(xB, yB), new Point(xC, yC), new Point(xD, yD)));
        }
        private void CreateRectangle()
        {
            Console.Write("Введите координаты угла A: \nx: ");
            double xA = ReadDoubleInput();
            Console.Write("y: ");
            double yA = ReadDoubleInput();
            Console.Write("Введите координаты угла B: \nx: ");
            double xB = ReadDoubleInput();
            Console.Write("y: ");
            double yB = ReadDoubleInput();
            Console.Write("Введите координаты угла C: \nx: ");
            double xC = ReadDoubleInput();
            Console.Write("y: ");
            double yC = ReadDoubleInput();
            Console.Write("Введите координаты угла D: \nx: ");
            double xD = ReadDoubleInput();
            Console.Write("y: ");
            double yD = ReadDoubleInput();
            figures.Add(new Rectangle(new Point(xA, yA), new Point(xB, yB), new Point(xC, yC), new Point(xD, yD)));
        }
        private void CreateTriangle()
        {
            Console.Write("Введите координаты угла A: \nx: ");
            double xA = ReadDoubleInput();
            Console.Write("y: ");
            double yA = ReadDoubleInput();
            Console.Write("Введите координаты угла B: \nx: ");
            double xB = ReadDoubleInput();
            Console.Write("y: ");
            double yB = ReadDoubleInput();
            Console.Write("Введите координаты угла C: \nx: ");
            double xC = ReadDoubleInput();
            Console.Write("y: ");
            double yC = ReadDoubleInput();
            figures.Add(new Triangle(new Point(xA, yA), new Point(xB, yB), new Point(xC, yC)));
        }

        private double ReadDoubleInput()
        {
            string input;
            double res;
            do
            {
                input = Console.ReadLine();
            } while (!double.TryParse(input, out res));
            return res;
        }
        private int ReadIntInput()
        {
            string input;
            int res;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out res));
            return res;
        }
    }
}
