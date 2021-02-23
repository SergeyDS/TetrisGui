using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

//Создаем графический интрефес для игры в тетрис

namespace TetrisGui
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Show();
            Turtle.Move(30);
            Turtle.TurnLeft();
            Turtle.Move(50);
        }
    }
}
