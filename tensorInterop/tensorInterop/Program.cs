using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tensorInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            var multTable = GetMultiplicationTable(5);

            PrintMultTable(multTable);

            Console.WriteLine("Sums:");

            for(int row = 0; row < multTable.Dimensions[0]; row++)
            {
                Console.WriteLine(GetRowSum(multTable, row));
            }
        }


        public static void PrintMultTable<T>(Tensor<T> tensor)
        {
            for(int i = 0; i < tensor.Dimensions[0]; i++)
            {
                var row = new StringBuilder();
                for (int j = 0; j < tensor.Dimensions[1]; j++)
                {
                    if (j != 0)
                    {
                        row.Append('\t');
                    }
                    row.Append(tensor[i, j]);
                }

                Console.WriteLine(row.ToString());
            }
        }

        public static Tensor<double> GetMultiplicationTable(int maxNumber)
        {
            using (var allocator = new NativeAllocator<double>())
            {
                var bufferPtr = GetMultTable(allocator.AllocateArray, maxNumber);

                var buffer = allocator.Unpin(bufferPtr);

                var result = new Tensor<double>(buffer, new[] { maxNumber, maxNumber });
                
                return result;
            }
        }

        public static double GetRowSum(Tensor<double> tensor, int row)
        {
            return GetRowSum(tensor.Buffer, tensor.Dimensions.ToArray(), tensor.Rank, row);
        }


        delegate IntPtr AllocatorDelegate(int size);
        [DllImport("native.dll")]
        extern private static IntPtr GetMultTable(AllocatorDelegate allocator, int number);

        [DllImport("native.dll")]
        extern private static double GetRowSum(double[] allocator, int[] dimensions, int rank, int row);
    }
}
