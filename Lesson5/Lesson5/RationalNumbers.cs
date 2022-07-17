using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{

        public struct Rational
            {
                /// <summary>
                /// Делимое
                /// </summary>
                public long Numerator { get; }
                /// <summary>
                /// Делитель
                /// </summary>
                public long Denominator { get; }
                /// <summary>
                /// Ноль и единица во множестве рациональных чисел
                /// </summary>
                public static readonly Rational ZERO, ONE;

                static Rational()
                {
                    ZERO = new Rational(0, 1);
                    ONE = new Rational(1, 1);
                }

                /// <summary>
                /// Рациональное число по целому числу
                /// </summary>
                /// <param name="a"></param>
                public Rational(long a) { this.Numerator = a; this.Denominator = 1; }
                /// <summary>
                /// Несократимая дробь, эквивалентная частному аргументов
                /// </summary>
                /// <param name="a"></param>
                /// <param name="b"></param>
                public Rational(long a, long b)
                {
                    if (b == 0)
                    {
                        Numerator = 0;
                        Denominator = 0;
                        return;
                    }
                    if (b < 0) { b = -b; a = -a; }
                    long d = Nod(a, b); d = Math.Abs(d);
                    Numerator = a / d; Denominator = b / d;
                }

                /// <summary>
                /// Наибольший общий делитель
                /// </summary>
                /// <param name="c"></param>
                /// <param name="d"></param>
                /// <returns></returns>
                public static long Nod(long c, long d)
                {
                    long p = 0;
                    if (c < 0) c = -c;
                    if (d < 0) d = -d;
                    do
                    {
                        p = c % d; c = d; d = p;
                    } while (d != 0);
                    return c;
                }

                /// <summary>
                /// Перевести число в строку, где число имеет вид неправильной дроби
                /// </summary>
                /// <returns></returns>
                public override string ToString()
                {
                    if (this.Denominator == 1) return this.Numerator.ToString();
                    return $"{Numerator}/{Denominator}";
                }
                /// <summary>
                /// Привести число в строку, где оно имеет вид смешанной дроби
                /// </summary>
                /// <returns></returns>
                public string ToStringMixed()
                {
                    string s;
                    long k = this.Numerator / this.Denominator;
                    Rational r = new Rational(this.Numerator - this.Denominator * k, this.Denominator);
                    s = String.Format("{0} + {1}", k, r.ToString());
                    return s;
                }
                /// <summary>
                /// Вывести смешанную дробь
                /// </summary>
                public void ShowMixed() { Console.WriteLine(this.ToStringMixed()); }

 
                /// <summary>
                /// Целая часть числа
                /// </summary>
                public long IntPart { get { return Rational.IntegerPart(this); } }
                /// <summary>
                /// Целая часть числа
                /// </summary>
                /// <param name="t"></param>
                /// <returns></returns>
                public static long IntegerPart(Rational t)
                {
                    if (t.Denominator == 1) return t.Numerator;
                    if (t.Numerator >= 0) return t.Numerator / t.Denominator;
                    return t.Numerator / t.Denominator - 1;
                }
                /// <summary>
                /// Дробная часть числа
                /// </summary>
                public Rational FracPart { get { return Rational.FractPart(this); } }
                /// <summary>
                /// Дробная часть числа
                /// </summary>
                /// <param name="t"></param>
                /// <returns></returns>
                public static Rational FractPart(Rational t) { return t - t.IntPart; }
                /// <summary>
                /// Является ли дробным
                /// </summary>
                /// <returns></returns>
                public static bool IsFractional(Rational r) { return !(r.FracPart == ZERO); }
                /// <summary>
                /// Является ли дробным
                /// </summary>
                /// <returns></returns>
                public bool IsFract() { return Rational.IsFractional(this); }

               public override bool Equals(object obj) => Equals((Rational)obj);

                public bool Equals(Rational rational)
                {
                    return
                           Numerator == rational.Numerator &&
                           Denominator == rational.Denominator;
                }


        public static Rational operator +(Rational a, Rational b) { return new Rational((a.Numerator * b.Denominator + a.Denominator * b.Numerator), (a.Denominator * b.Denominator)); }
        public static Rational operator -(Rational a) { return new Rational(-a.Numerator, a.Denominator); }
        public static Rational operator -(Rational a, Rational b) { return a + (-b); }
        public static Rational operator -(Rational a, long b) => a - new Rational(b);
        public static Rational operator *(Rational a, Rational b) { return new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator); }
        public static Rational operator /(Rational a, Rational b) { return new Rational(a.Numerator * b.Denominator, a.Denominator * b.Numerator); }
        public static bool operator ==(Rational a, Rational b) { return (a.Numerator == b.Numerator) && (a.Denominator == b.Denominator); }
        public static bool operator !=(Rational a, Rational b) { return !(a == b); }

        public static implicit operator double(Rational r) => ((double)r.Numerator) / r.Denominator;
        public static implicit operator Rational(long r) => new Rational(r);
        public static explicit operator int(Rational r)
        {
            if (r.Numerator == 0 && r.Denominator != 0) return 0;
            if (Math.Abs(r.Numerator) < r.Denominator) throw new Exception("Не конвертируется в int: числитель меньше знаменателя");
            if (Math.Abs(r.Numerator) % r.Denominator != 0) throw new Exception("Не конвертируется в int: числитель не делится на знаменатель нацело");
            return (int)(r.Numerator / r.Denominator);
        }
    }
}
