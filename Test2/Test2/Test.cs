using System.Numerics;

namespace Test2
{
    public class Test
    {
        private (float x, float y) Begin40(float A1, float B1, float C1, float A2, float B2, float C2)
        {
            float D = A1 * B2 + A2 * B1;

            float x = (C1 * B2 - C2 * B1) / D;
            float y = (A1 * C2 - A2 * C1) / D;

            return (x, y);
        }

        private bool Boolean20(int number)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = number % 10;

            return hundreds != tens && tens != ones;
        }

        private bool Boolean33(int a, int b, int c)
        {
            if (c > a + b)
                return false;
            else if (a > c + b)
                return false;
            else if (b > c + a)
                return false;

            return true;
        }

        private int If19(int numberOne, int numberTwo, int numberThree, int numberFour)
        {
            if (numberOne == numberTwo && numberOne == numberThree)
                return numberFour;

            if (numberTwo == numberThree && numberTwo == numberFour)
                return numberOne;

            if (numberThree == numberFour && numberThree == numberOne)
                return numberTwo;

            return numberThree;
        }

        private float For23(float X, int N)
        {
            float result = 0f;
            float square = X;
            float factorial = 1f;

            int turn = 1;

            for (int i = 1; i <= N; i += 2)
            {
                factorial *= i;

                result += square / factorial * turn;

                square *= X * X;

                turn = -turn;

                factorial *= i + 1f;
            }

            return result;
        }

        private int MinMax17(List<int> numbers)
        {
            int maxIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= numbers[maxIndex])
                    maxIndex = i;
            }

            return numbers.Count - (maxIndex + 1);
        }

        //Proc 14
        private (float A, float B, float C) ShiftRight(float A, float B, float C)
        {
            var temp = C;

            C = B;
            B = A;
            A = temp;

            return (A, B, C);
        }

        private (float distance, Vector2 A, Vector2 B) Array135(Vector2[] pointsA, Vector2[] pointsB)
        {
            float distance = float.MaxValue;
            Vector2 pointOne = new Vector2();
            Vector2 pointTwo = new Vector2();

            for (int i = 0; i < pointsA.Length; i++)
            {
                for (int j = 0; j < pointsB.Length; j++)
                {
                    if (pointsA[i] == pointsB[j])
                        continue;

                    float newDistance = (pointsB[i] - pointsA[j]).Length();

                    if (newDistance < distance)
                    {
                        distance = newDistance;
                        pointOne = pointsA[i];
                        pointTwo = pointsB[j];
                    }
                }
            }

            return (distance, pointOne, pointTwo);
        }

        public int[,] Matrix51(int[,] array)
        {
            (int x, int y) minIndex = (0, 0);
            (int x, int y) maxIndex = (0, 0);

            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                for (int j = 0; j < array.GetUpperBound(1); j++)
                {
                    if (array[i, j] < array[minIndex.x, minIndex.y])
                    {
                        minIndex.x = i;
                        minIndex.y = j;
                    }

                    if (array[i, j] > array[maxIndex.x, maxIndex.y])
                    {
                        minIndex.x = i;
                        minIndex.y = j;
                    }
                }
            }

            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                (array[i, minIndex.y], array[i, maxIndex.y]) = (array[i, maxIndex.y], array[i, minIndex.y]);
            }

            return array;
        }

        static List<Vector2> Task12(List<Vector2> points, float R)
        {
            List<Vector2> result = new List<Vector2>();

            foreach (var point in points)
            {
                if (R > point.Length())
                    result.Add(point);
            }

            return result;
        }

    }
}
