namespace CSC205FinalExam
{
    public class Rect
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public static double ComputeArea1(Rect rec)
        {
            return rec.Height * rec.Length;
        }
        public double ComputeArea2()
        {
            return Height * Length;
        }
    }
    public class Program
    {
        public static void Main()
        {
            // 1) explain the following line:
            var r = new Rect { Height = 2, Length = 3 };
            // This line creates a new instance of the Rect class using object initializer syntax.
            // It sets the Height property to 2 and the Length property to 3.

            // 2) Invoke ComputeArea1 to compute the area of r and display the result
            double area1 = Rect.ComputeArea1(r);
            Console.WriteLine("Area using ComputeArea1: " + area1);

            // 3) Change the rectangle's height and length to 4 and 6, respectively
            r.Height = 4;
            r.Length = 6;

            // 4) Invoke ComputeArea2 to compute the area of r, and display the result
            double area2 = r.ComputeArea2();
            Console.WriteLine("Area using ComputeArea2: " + area2);
        }
    }
}

//public static void Main()
//{
//    // Note that array arr is already sorted
//    int[] arr = { 1, 2, 5, 13, 13, 18, 22 };
//    System.Console.WriteLine(Fun(arr, 6));
//    System.Console.WriteLine(Fun(arr, 13));
//    // Define a local function inside Main()
//    int Fun(int[] arr, int searchNumber)
//    {
//        int left = 0;
//        int right = arr.Length - 1;
//        int middle;
//        while (left <= right)
//        {
//            middle = (left + right) / 2;
//            if (searchNumber == arr[middle])
//            {
//                return ++middle;
//            }
//            else if (searchNumber < arr[middle])
//            {
//                right = middle - 1;
//            }
//            else
//            {
//                left = middle + 1;
//            }
//        }
//        return -1;
//    }
//}