using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            char[,] image = new char[size, size * 2];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size*2; j++)
                {
                    image[i,j] = ' ';
                }
            }
            for(int i = 0; i < radius*2+1; i++)
            {
                image[1,i] = '*';
                image[size-1,i] = '*';
            }
            for(int i = 1; i < size; i++) {
                image[i,0] = '*';
            }

            int r = size/3;
            for(int i = 0; i < size; i++) {
                image[r, size+i] = '*';
                image[i, size+r] = '*';
            }
            r = size*2/3;
            for(int i = 0; i < size; i++) {
                image[r, size+i] = '*';
                image[i, size+r] = '*';
            }

            for(int i = 0; i < size; i++) {
                for(int j = 0; j < size*2; j++) {
                    Console.Write(image[i,j]);
                }
                Console.WriteLine("\n");
            }
            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/