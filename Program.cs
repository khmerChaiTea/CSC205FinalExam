namespace CSC205FinalExam
{
    public struct Complex
    {
        public int real;
        public int imaginary;
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        //more code is omitted here ...
    }
    ////1) Transform the following static method into an instance method.
    //public static double Abs(Complex c)
    //{
    //    return Math.Sqrt(c.Real * c.Real + c.Imaginary * c.Imaginary);
    //}

    //public double Abs()
    //{
    //    return Math.Sqrt(this.real * this.real + this.imaginary + this.imaginary);
    //}

    ////2) Transform the following instance method into a static method.
    //public bool Compare(Complex b)
    //{
    //    return (Real == b.Real && Imaginary == b.Imaginary);
    //}

    //public static bool Compare(Complex a, Complex b)
    //{
    //    return (a.real = b.real && a.imaginary == b.imaginary);
    //}
}