using System.Diagnostics;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace MemoryManagement.MemoryManagementModule.Simd;

public static class SimdExamples
{
    public static void Run()
    {
        Console.WriteLine("--- SIMD vs scalare ---");
        const int length = 1_000_000;
        float[] left = Enumerable.Range(0, length).Select(i => (float)Math.Sin(i)).ToArray();
        float[] right = Enumerable.Range(0, length).Select(i => (float)Math.Cos(i)).ToArray();
        float[] destination = new float[length];

        TimeSpan scalar = MeasureScalar(left, right, destination);
        TimeSpan vector = MeasureVector(left, right, destination);
        TimeSpan? avx = MeasureAvx(left, right, destination);

        Console.WriteLine($"Scalare: {scalar.TotalMilliseconds:F2} ms");
        Console.WriteLine($"Vector<T>: {vector.TotalMilliseconds:F2} ms");
        if (avx is { } avxTime)
        {
            Console.WriteLine($"AVX intrinsics: {avxTime.TotalMilliseconds:F2} ms");
        }
        else
        {
            Console.WriteLine("AVX intrinsics: non supportato su questa CPU");
        }

        Console.WriteLine();
    }

    private static TimeSpan MeasureScalar(float[] left, float[] right, float[] destination)
    {
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < left.Length; i++)
        {
            destination[i] = left[i] * right[i];
        }

        sw.Stop();
        return sw.Elapsed;
    }

    private static TimeSpan MeasureVector(float[] left, float[] right, float[] destination)
    {
        var sw = Stopwatch.StartNew();
        int simdLength = Vector<float>.Count;
        int i = 0;
        for (; i <= left.Length - simdLength; i += simdLength)
        {
            var vecLeft = new Vector<float>(left, i);
            var vecRight = new Vector<float>(right, i);
            (vecLeft * vecRight).CopyTo(destination, i);
        }

        for (; i < left.Length; i++)
        {
            destination[i] = left[i] * right[i];
        }

        sw.Stop();
        return sw.Elapsed;
    }

    private static TimeSpan? MeasureAvx(float[] left, float[] right, float[] destination)
    {
        if (!Avx.IsSupported)
        {
            return null;
        }

        var sw = Stopwatch.StartNew();
        int width = Vector256<float>.Count;
        int i = 0;
        unsafe
        {
            fixed (float* leftPtr = left)
            fixed (float* rightPtr = right)
            fixed (float* destPtr = destination)
            {
                for (; i <= left.Length - width; i += width)
                {
                    Vector256<float> a = Avx.LoadVector256(leftPtr + i);
                    Vector256<float> b = Avx.LoadVector256(rightPtr + i);
                    Vector256<float> result = Avx.Multiply(a, b);
                    Avx.Store(destPtr + i, result);
                }
            }
        }

        for (; i < left.Length; i++)
        {
            destination[i] = left[i] * right[i];
        }

        sw.Stop();
        return sw.Elapsed;
    }
}
