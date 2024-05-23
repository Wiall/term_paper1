namespace term_paper_1
{
    public class SmoothSorting : Sorting
    {
        private static bool IsAscending(int a, int b)
        {
            return a <= b;
        }

        private static int q, r, p, b, c, r1, b1, c1;

        private static void Up(ref int b1, ref int c1, ref int temp)
        {
            temp = b1;
            b1 += c1 + 1;
            c1 = temp;
            SaveArrayState();
        }

        private static void Down(ref int b1, ref int c1, ref int temp)
        {
            temp = c1;
            c1 = b1 - c1 - 1;
            b1 = temp;
            SaveArrayState();
        }

        private void Sift()
        {
            int r0, r2, temp = 0;
            int t;
            r0 = r1;
            t = Array[r0];
            
            while (b1 >= 3)
            {
                r2 = r1 - b1 + c1;

                if (!IsAscending(Array[r1 - 1], Array[r2]))
                {
                    r2 = r1 - 1;
                    Down(ref b1, ref c1, ref temp);
                }

                if (IsAscending(Array[r2], t))
                {
                    b1 = 1;
                }
                else
                {
                    Array[r1] = Array[r2];
                    SwapsCount++;
                    r1 = r2;
                    Down(ref b1, ref c1, ref temp);
                    
                }
            }

            Array[r1] = t;
            SwapsCount++;
            SaveArrayState();
        }

        private void Trinkle()
        {
            int p1, r2, r3, r0, temp = 0;
            int t;
            p1 = p;
            b1 = b;
            c1 = c;
            r0 = r1;
            t = Array[r0];

            while (p1 > 0)
            {
                while ((p1 & 1) == 0)
                {
                    p1 >>= 1;
                    Up(ref b1, ref c1, ref temp);
                }

                r3 = r1 - b1;

                if ((p1 == 1) || IsAscending(Array[r3], t))
                {
                    p1 = 0;
                }
                else
                {
                    --p1;
                    if (b1 == 1)
                    {
                        Array[r1] = Array[r3];
                        SwapsCount++;
                        r1 = r3;
                    }
                    else
                    {
                        if (b1 >= 3)
                        {
                            r2 = r1 - b1 + c1;

                            if (!IsAscending(Array[r1 - 1], Array[r2]))
                            {
                                r2 = r1 - 1;
                                Down(ref b1, ref c1, ref temp);
                                p1 <<= 1;
                            }

                            if (IsAscending(Array[r2], Array[r3]))
                            {
                                Array[r1] = Array[r3];
                                r1 = r3;
                                SwapsCount++;
                            }
                            else
                            {
                                Array[r1] = Array[r2];
                                r1 = r2;
                                SwapsCount++;
                                Down(ref b1, ref c1, ref temp);
                                p1 = 0;
                            }
                        }
                    }
                }
            }

            if (r0 != r1)
            {
                Array[r1] = t;
                SwapsCount++;
            }
                

            Sift();
            SaveArrayState();
        }

        private void SemiTrinkle()
        {
            int T;
            r1 = r - c;

            if (!IsAscending(Array[r1], Array[r]))
            {
                T = Array[r];
                Array[r] = Array[r1];
                Array[r1] = T;
                SwapsCount++;
                Trinkle();
            }
        }

        public void SmoothSort()
        {
            int N = Array.Length;
            int temp = 0;
            q = 1;
            r = 0;
            p = 1;
            b = 1;
            c = 1;

            while (q < N)
            {
                r1 = r;
                if ((p & 7) == 3)
                {
                    b1 = b;
                    c1 = c;
                    Sift();
                    p = (p + 1) >> 2;
                    Up(ref b, ref c, ref temp);
                    Up(ref b, ref c, ref temp);
                }
                else if ((p & 3) == 1)
                {
                    if (q + c < N)
                    {
                        b1 = b;
                        c1 = c;
                        Sift();
                    }
                    else
                    {
                        Trinkle();
                    }

                    Down(ref b, ref c, ref temp);
                    p = 2 * p;
                    while (b > 1)
                    {
                        Down(ref b, ref c, ref temp);
                        p = 2 * p;
                    }

                    ++p;
                }

                ++q;
                ++r;
            }
            r1 = r;
            Trinkle();
            
            while (q > 1)
            {
                --q;
                if (b == 1)
                {
                    --r;
                    --p;
                   
                    while ((p & 1) == 0)
                    {
                        p /= 2;
                        Up(ref b, ref c, ref temp);
                    }
                }
                else
                {
                    if (b >= 3)
                    {
                        --p;
                        r = r - b + c;
                        if (p > 0)
                            SemiTrinkle();

                        Down(ref b, ref c, ref temp);
                        p = (2 * p) + 1;
                        r = r + c;
                        SemiTrinkle();
                        Down(ref b, ref c, ref temp);
                        p = (2 * p) + 1;
                    }
                }
            }
        }
    }
}