using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment2_Group6
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1
            Console.WriteLine("Question 1");
            int[] l1 = new int[] {5,6,6,9,9,9,9,12};
            int target = 9;
            int[] r = TargetRange(l1, target);
            Console.WriteLine(string.Join(" ", r));
            Console.WriteLine();

            //QUESTION 2
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);

            //QUESTION 3
            Console.WriteLine();
            Console.WriteLine("Question 3");
            int[] l2 = new int[] {40,40};
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            //QUESTION 4
            Console.WriteLine();
            Console.WriteLine("Question 4");
            string s2 = "Dell";
            //string s2 = "kkYy";
            //string s2 = "hhheeb";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);

            /*
            //QUESTION 5 - PART 1
            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);

            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");

            //QUESTION 5 - PART 2
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);

            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");
            

            //QUESTION 6 
            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));
            
            
            //QUESTION 7 
            Console.WriteLine();
            Console.WriteLine("Question 7");
            int rodLength = 4;
            //int priceProduct = GoldRod(rodLength);
            //GoldRod(rodLength);
            //Console.WriteLine(priceProduct);
            */

            //QUESTION 8
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));
            
            Console.WriteLine("Question 9");
            SolvePuzzle();
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }

        public static int[] TargetRange(int[] l1, int t)
        {
            List<int> l2 = new List<int>();
            int position_1 = -1;
            int position_2 = -1;
            bool found = false;
            try
            {
                //Scan through the array 
                for (int i = 0; i < l1.Length; i++)
                {
                    if (l1[i] == t && !found)
                    {
                        position_1 = i;
                        found = true;
                    }

                    if (l1[i] == t)
                    {
                        position_2 = i;
                    }
                }
                return new int[] {position_1, position_2};

            }
            catch (Exception)
            {
                throw;
            }

        }



        public static string StringReverse(string s)
        {
            s = s + " ";
            try
            {
                Stack<char> st = new Stack<char>();

                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[i] != ' ')
                    {
                        st.Push(s[i]);
                    }

                    // When we see a space, we  
                    // print contents of stack.  
                    else
                    {
                        while (st.Count > 0)
                        {
                            Console.Write(st.Pop());

                        }
                        Console.Write(" ");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static int MinimumSum(int[] l2)
        {
            int newSum = 0;

            try
            {
                for (int i = 0; i < l2.Length; i++)
                {
                    if (i != l2.Length - 1 && l2[i] == l2[i + 1])
                    {
                        l2[i + 1] = l2[i] + 1;
                    }

                    newSum += l2[i];
                }
            }
            catch (Exception)
            {
                throw;
            }
            return newSum;
        }
        
        public static string FreqSort(string s2)
        {
            try
            {
                var dict = new Dictionary<char, int>();

                for (int i = 0; i < s2.Length; i++)
                {
                    if (dict.ContainsKey(s2[i]))
                    {
                        dict.TryGetValue(s2[i],out int count);
                        dict[s2[i]] = count + 1;
                    }
                    else
                    {
                        dict.Add(s2[i],1);
                    }
                }

                var items = from pair in dict
                            orderby pair.Value descending
                            select pair;

                foreach (KeyValuePair<char, int> pair in items)
                {
                    for (int i = 0; i < pair.Value; i++)
                    {
                        Console.Write("{0}", pair.Key);
                    }
                    
                }

                /*foreach (KeyValuePair<char,int>kvp in dict)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }*/
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        /*
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }
        */
        /*
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                Dictionary<int, char> dictionaryTest = new Dictionary<int, char>();

                for (int i = 0; i < arr.Length; i++)
                {
                    dictionaryTest.Add(i, arr[i]);
                    Console.WriteLine("Array Position {0} and Position Value {1}", i, arr[i]);


                }


            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }*/
        
        /*
        //public static int GoldRod(int rodLength)
        public static void GoldRod(int rodLength)
        {
            try
            {
                Console.WriteLine(rodLength);
            }
            catch (Exception)
            {
                throw;
            }
           //return 0;
        }
        */
        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                foreach (string words in userDict)
                {
                    int count = 0;
                    if (words.Length == keyword.Length)
                    {
                        char[] key = keyword.ToCharArray();
                        char[] word = words.ToCharArray();

                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[i]!= key[i])
                            {
                                count = count + 1;
                            }
                        }

                        if (count == 1)
                        {
                            return true;
                            break;
                        }
                        
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }
        
        public static void SolvePuzzle()
        {
            try
            {
                Console.WriteLine("Enter the first string(4):");
                //string first_str = Console.ReadLine();
                string first_str = "UBER";
                Console.WriteLine("Enter the second string(4):");
                //string second_str = Console.ReadLine();
                string second_str = "COOL";
                Console.WriteLine("Enter the result string(5):");
                //string result_str = Console.ReadLine();
                string result_str = "UNCLE";

                List<char> unique_char = new List<char>();

                String final_str = first_str + second_str + result_str;
                char[] char_arr = final_str.ToCharArray();

                for (int i = 0; i < char_arr.Length; i++)
                {
                    Console.Write(char_arr[i]);
                    Console.WriteLine();
                    if (unique_char.Contains(char_arr[i]))
                    {
                        Console.WriteLine("Character repeat...");
                    }
                    else 
                    {
                        unique_char.Add(char_arr[i]);
                    }
                }

                foreach (int i in unique_char)
                    Console.Write(i);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}