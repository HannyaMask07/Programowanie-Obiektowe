using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Ułamek
    {
        private int licznik;
        private int mianownik;

        public Ułamek()
        {
            this.licznik = 5;
            this.mianownik = 1;
        }

        public Ułamek(int licznik, int mianownik)
        {
            licznik = this.licznik;
            mianownik = this.mianownik;
        }

        public Ułamek(Ułamek ułamek)
        {
            this.licznik = ułamek.licznik;
            this.mianownik = ułamek.mianownik;
        }

        public static Ułamek operator +(Ułamek a) => a;

        public static Ułamek operator -(Ułamek a) => new Ułamek(-a.licznik, a.mianownik);

        public static Ułamek operator +(Ułamek a, Ułamek b)
            => new Ułamek(a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);

        public static Ułamek operator -(Ułamek a, Ułamek b)
            => a + (-b);

        public static Ułamek operator *(Ułamek a, Ułamek b)
            => new Ułamek(a.licznik * b.licznik, a.mianownik * b.mianownik);

        public static Ułamek operator /(Ułamek a, Ułamek b)
        {
            if (b.licznik == 0)
            {
                throw new DivideByZeroException();
            }
            return new Ułamek(a.licznik * b.mianownik, a.mianownik * b.licznik);
        }

        public override string ToString() => $"{licznik} / {mianownik}";
    }

}