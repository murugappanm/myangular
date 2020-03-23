private static string AddBinary(string a, string b)
        {
            int aIndex = a.Length-1;
            int bIndex = b.Length - 1;
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            while (aIndex >=0 || bIndex >= 0 || carry > 0)
            {
                int aVal = (aIndex >= 0) ? a[aIndex--] - '0' : 0;
                int bVal = (bIndex >= 0) ? b[bIndex--] - '0' : 0;
                int localVal = aVal + bVal + carry;
                carry = localVal / 2;
                localVal = localVal % 2;
                sb.Insert(0, localVal);
            }
            return sb.ToString();
        }
