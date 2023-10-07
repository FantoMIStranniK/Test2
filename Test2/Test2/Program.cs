using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private static float If13(int numberOne, int numberTwo, int numberThree)
        {
            if(numberOne < numberTwo)
            {
                if (numberTwo < numberThree)
                    return numberTwo;
                else if (numberOne < numberThree)
                    return numberThree;
                else
                    return numberOne;
            }
            else
            {
                if(numberTwo > numberThree)
                    return numberTwo;
                else if (numberOne < numberThree)
                    return numberOne;
                else
                    return numberThree;
            }
        }

        private static float For14(int N)
        {
            float mult = 1.1f;

            float result = mult;

            for(int i = 0; i < N; i++)
            {
                mult += 0.1f;

                result *= mult;
            }

            return result;
        }

        private static float For24(int N, float X)
        {
            float result = 0f;
            float turn = 1f;
            float factorial = 1f;
            float powerNumber = 1f;

            for(int i = 1; i <= N; i++)
            {
                result += (powerNumber / factorial) * turn;

                factorial *= (i + 1f) * (i + 2);

                powerNumber *= X * X;

                turn = -turn;
            }

            return result;
        }

        private static int While10(int N) 
        {
            float poweredNumber = 1;

            int K = 0;

            while(poweredNumber < N)
            {
                poweredNumber *= 3;

                K++;
            }

            return K - 1;
        }

        private static List<float> Series27(List<float> numbers, int N)
        {
            List<float> result = numbers;

            float powerNumber = 1f;

            for(int i = 0; i <= numbers.Count; i++) 
            {
                powerNumber = 1f;

                for(int j = 0; j <= i; j++)
                {
                    powerNumber *= numbers[i];
                }

                result.Add(powerNumber);
            }

            return result;
        }

        private static float Fact2(int N)
        {
            float factorial = 1f;

            int startNumber = N % 2 == 0 ? 2 : 1;

            for (int i = startNumber; i <= N; i += 2)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static float Leng(float XA, float XB, float YA, float YB)
        {
            float firstPairResult = XA - XB;
            float secondPairResult = YA - YB;

            firstPairResult *= firstPairResult;
            secondPairResult *= secondPairResult;

            return MathF.Sqrt(firstPairResult + secondPairResult);
        }

        private static (float PerimeterABC, float PerimeterABD, float PerimeterACD) Proc57(float XA, float YA, float XB, float YB, float XC, float YC, float XD, float YD)
            => (Perim(XA, YA, XB, YB, XC, YC), Perim(XA, YA, XB, YB, XD, YD), Perim(XA, YA, XC, YC, XD, YD));
        private static float Perim(float XA, float YA, float XB,  float YB, float XC, float YC)
        {
            float sideOne = Leng(XA, XB, YA, YB);
            float sideTwo = Leng(XB, XC, YB, YC);
            float sideThree = Leng(XA, XC, YA, YC);

            return sideThree + sideTwo + sideOne;
        }

        private static List<float> Array69(List<float> numbers)
        {
            int maxIndex = 0;
            int minIndex = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[maxIndex] < numbers[i])
                    maxIndex = i;

                if (numbers[minIndex] > numbers[i])
                    minIndex = i;
            }

            float temp = numbers[maxIndex];

            numbers[maxIndex] = numbers[minIndex];

            numbers[minIndex] = temp;

            return numbers;
        }

        private static List<int> Array110(List<int> numbers)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i]);

                if (numbers[i] % 2 != 0)
                    continue;

                result.Add(numbers[i]);
            }

            return result;
        }

        private static List<Vector2> Array137(List<Vector2> points)
        {
            List<Vector2> suitablePoints = new List<Vector2>();

            for(int i = 0; i < 3; i++)
            {
                foreach(var point in points)
                {
                    if (suitablePoints.Contains(point))
                    {
                        continue;
                    }

                    if (suitablePoints.Count == i)
                    {
                        suitablePoints.Add(point);
                        continue;
                    }

                    if (suitablePoints[i].LengthSquared() < point.LengthSquared())
                        suitablePoints[i] = point;
                }
            }

            return suitablePoints;
        }
    }
}