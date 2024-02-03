namespace FractionCalc
{
    class MixedNumber
    {
        private int wholePart;
        private int numerator;
        private int denominator;

        public MixedNumber(int wholePart, int numerator, int denominator)
        {
            this.wholePart = wholePart;
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static MixedNumber operator +(MixedNumber a, MixedNumber b)
        {
            int newWholePart = a.wholePart + b.wholePart;
            int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;

            
            SimplifyFraction(ref newNumerator, ref newDenominator);

            return new MixedNumber(newWholePart, newNumerator, newDenominator);
        }

        public static MixedNumber operator -(MixedNumber a, MixedNumber b)
        {
            int newWholePart = a.wholePart - b.wholePart;
            int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;

            
            SimplifyFraction(ref newNumerator, ref newDenominator);

            return new MixedNumber(newWholePart, newNumerator, newDenominator);
        }

        public static MixedNumber operator *(MixedNumber a, MixedNumber b)
        {
            int newWholePart = a.wholePart * b.wholePart;
            int newNumerator = (a.wholePart * a.denominator + a.numerator) * (b.wholePart * b.denominator + b.numerator);
            int newDenominator = a.denominator * b.denominator;

            
            SimplifyFraction(ref newNumerator, ref newDenominator);

            return new MixedNumber(newWholePart, newNumerator, newDenominator);
        }

        public static MixedNumber operator /(MixedNumber a, MixedNumber b)
        {
            int newWholePart = a.wholePart / b.wholePart;
            int newNumerator = (a.wholePart * a.denominator + a.numerator) * b.denominator;
            int newDenominator = (b.wholePart * b.denominator + b.numerator) * a.denominator;

            
            SimplifyFraction(ref newNumerator, ref newDenominator);

            return new MixedNumber(newWholePart, newNumerator, newDenominator);
        }

        
        private static void SimplifyFraction(ref int numerator, ref int denominator)
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{wholePart} {numerator}/{denominator}";
        }
    }

}
