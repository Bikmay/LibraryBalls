using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    class Balls
    {
        Ball[,] area; //поле

        public Balls()//инициализация поля
        {
        }


        public void GenerationNewBalls()
        {
            //generation
        }

        public int[] GetFreeCell()// возвращает первую попавшуюся ячейку
        {
            //your code

            //[x,y]
            return null;
        }
        
        public int[,] FindLineEqualBalls()
        {
            //двухмерные каждая строчка состоит из x и y ячейки с шариком
            //количество строчек совпадает с количеством ячеек

            //x1 y1
            //x2 y2
            //x3 y3
            //и т.д.
            return null;

        }

        public void DeleteBall(int x,int y)
        {
            //присваиваешь ячейке null
            // если хочешь убери void поставь boolean и при успешном удалении возвращай true
            //как лучше сделать я не знаю
        }

        public bool CheckArea()//наименование гавно, придумай другое я хз
        {
            //your code
            //true если поле заполнено
            return true;
        }
        
        public void Clear(Customer customer)
        {
            //присваиваешь всем ячейкам null
            //присваиваем ноль счётчику кастомера
        }



    }
}
