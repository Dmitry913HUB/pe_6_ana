using System;
using System.Text;

namespace pe6
{
    [Serializable()]
    internal class Goods
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int Price { get; set; }
        private int Kolvo;
        public int kolvo
        {
            get
            {
                return Kolvo;
            }
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    Kolvo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
 
        public int Number { get; set; }
        public int Sum{ get; set; }
        public Goods()
        {
            Name = "";
            Date = DateTime.MinValue;
            Price = 0;
            Kolvo = 0;
            Number = 0;
        }

        public Goods(string Name, DateTime Date, int Price, int Kolvo, int Number)
        {
            this.Name = Name;
            this.Date = Date;
            this.Price = Price;
            this.Kolvo = Kolvo;
            this.Number = Number;
        }


        public static Goods operator -(Goods tovar, int x1)
        {
            int X = x1;
            if (X <= tovar.Kolvo)
                return new Goods(tovar.Name, tovar.Date, tovar.Price, tovar.Kolvo - X, tovar.Number);
            else throw new ArgumentOutOfRangeException();
        }

        public static Goods operator +(Goods tovar, int x2)
        {
            int X = x2;
            return new Goods(tovar.Name, tovar.Date, tovar.Price, tovar.Kolvo + X, tovar.Number);
        }

        public int cost()
        {
            Sum = Price * Kolvo;
            return Sum;
        }
        public int cost(int price, int kolvo)
        {
            Sum = price * kolvo;
            return Sum;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(($"\n Наименование товара - {Name} " +
                       $"\n Дата оформления - {Date} " +
                       $"\n Цена товара - {Price} " +
                       $"\n Кол-во единиц товара - {Kolvo} "+
                       $"\n Номер накладной - {Number}"+
                       $"\n Cумма товара - {Sum} \n"));
            sb.AppendLine();
            return sb.ToString();
        }
        public int Price_change(int price)
        {
            return (Price = price);
        }
    }
}
