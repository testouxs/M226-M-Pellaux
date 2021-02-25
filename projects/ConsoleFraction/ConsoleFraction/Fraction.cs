using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;
using System.Globalization;
    
namespace ConsoleFraction
{
    interface IOperationFraction
    {
        Fraction Add(Fraction f);
        Fraction Substract(Fraction f);
        Fraction Multiply(Fraction f);
        Fraction Divide(Fraction f);
    }

    class Fraction : IOperationFraction //, IComparable
    {
        private int _numerator;
        private int _denominator;

        public int Denominator
        {
            get { return _denominator; }
            private set { _denominator = value; }
        }
        public int Numerator
        {
            get { return _numerator; }
            private set { _numerator = value; }
        }

        public Fraction() : this(10,2)
        {

        }

        public Fraction(int numerator) : this(numerator, 2)
        {

        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Reduce();
        }

        public Fraction(float fl)
        {
            //this._nominator = (int)fl;
            //this._denominator = (int)fl;
        }

        public Fraction Add(Fraction fraction)
        {
            Fraction fractionAdd = new Fraction(
                this._numerator * fraction._denominator + this._denominator * fraction._numerator,
                this._denominator * fraction._denominator
            );
            
            return fractionAdd;
        }

        public int CompareTo(Fraction fraction)
        {
            int result = 0;
            if (this._numerator / this._denominator > fraction._numerator / fraction._denominator)
            {
                result = 1;
            }

            if (this._numerator / this._denominator == fraction._numerator / fraction._denominator)
            {
                result = 0;
            }

            if (this._numerator / this._denominator < fraction._numerator / fraction._denominator)
            {
                result = 1;
            }

            return result;
        }

        private void CreateFractionFromDouble(double f)
        {
            // Gets a NumberFormatInfo associated with the en - US culture.
            //NumberFormatInfo nfi = new CultureInfo.CurrentCulture.NumberFormat;
            //String floatString = f.ToString();
        }

        public Fraction Divide(Fraction fraction)
        {
            Fraction fractionDivid = new Fraction(this._numerator * fraction._denominator, this._denominator * fraction._numerator);

            return fraction;
        }

        private int FindCD(int a, int b)
        {
            int c = a % b;
            while (c != 0)
            {
                a = b;
                b = c;
                c = a % b;
            }
            return b;
        }

        private int FindPGDC()
        {
            int result = FindCD(Numerator, Denominator);
            return result;
        }

        public Fraction Multiply(Fraction fraction)
        {
            Fraction fractionMultiply = new Fraction(this._numerator * fraction._numerator, this._denominator * fraction._denominator);

            return fractionMultiply;
        }

        private void Reduce()
        {
            int pgdc = FindPGDC();
            Numerator = Numerator / pgdc ;
            Denominator = Denominator / pgdc;
        }

        public Fraction Substract(Fraction fraction)
        {
            Fraction fractionSubstract = new Fraction(
                this._numerator * fraction._denominator + this._denominator * fraction._numerator,
                this._denominator * fraction._denominator
            );

            return fractionSubstract;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", this._numerator, this._denominator);
        }
    }
}
