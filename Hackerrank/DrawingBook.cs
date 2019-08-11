 /*
            int pageNumber = 1;
            int pageTurns = 0;
            while(pageNumber < p)
            {
                if (pageNumber == p)
                {
                    break;
                }
                pageNumber++;
                Console.WriteLine("pageNumber: " + pageNumber);
                pageTurns++;
                Console.WriteLine("pageTurns: " + pageTurns);
                if()
            }
            return pageTurns;
            */

            int total = n / 2;
            Console.WriteLine("total " + total);
            int right = p / 2;
            Console.WriteLine("right " + right);
            int left = total - right;
            Console.WriteLine("left " + left);

            if (left < right)
                return left;
            else
                return right;