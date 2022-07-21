using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }else return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var item in numbers.ToArray())
            {
                if (item % 2 != 0)
                {
                    sum+= item;
                }
            }
            if(sum % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit)){
                return false;
            } else return true;
        }

        public char GetFirstLetterOfString(string val)
        {
            val.ToCharArray();
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            val.ToCharArray();
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if(nums == null)
            {
                return 0;
            }
            return nums.Last() - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] nums = new int[50];
            int index = 0;
            for (int i = 1; i <= 99; i+=2)
            {
                nums[index] = i;
                index++;
            }
            return nums;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
