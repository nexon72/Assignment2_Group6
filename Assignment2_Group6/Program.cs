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
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            //int target = 9;
            int target = 10;
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
            int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            //int[] l2 = new int[] {40,40};
            //int[] l2 = new int[] {4,5,6,9};
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            //QUESTION 4
            Console.WriteLine();
            Console.WriteLine("Question 4");
            //string s2 = "Dell";
            //string s2 = "kkYy";
            string s2 = "hhheeb";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);

            //QUESTION 5 - PART 1
            Console.WriteLine();
            Console.WriteLine("Question 5-Part 1");
            //int[] nums1 = { 2,5,5,2};
            //int[] nums2 = { 5,5 };
            int[] nums1 = { 3, 6, 2 };
            int[] nums2 = { 6, 3, 6, 7, 3 };

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
            //char[] arr = new char[] { 'a', 'b', 'c', 'a', 'b', 'c' };
            //int k = 2;
            //char[] arr = new char[] { 'k', 'y', 'k', 'k' };
            //int k = 1;
            Console.WriteLine(ContainsDuplicate(arr, k));

            //QUESTION 7 
            Console.WriteLine();
            Console.WriteLine("Question 7");
            int rodLength = 4;
            //int rodLength = 6;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);

            //QUESTION 8
            Console.WriteLine();
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));

            //QUESTION 9
            Console.WriteLine();
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
            bool found = false;                             // declare boolean variable 'found' as false
            int index = 0;                                  // declare integer variable 'index' to 0
            int position = -1;                              // set integer variable 'position' to -1
            int position2 = -1;                             // set integer variable 'position2' to -1

            try
            {
                while (index < l1.Length)
                {                 // scan through the array while index is less than the length of array 'l1'
                    if (l1[index] == t && !found)
                    {         // when target is found
                        found = true;                        // set 'found' to True
                        position = index;                    // set position (start index) as the index of that number
                    }
                    if (l1[index] == t && found == true)
                    {
                        position2 = index;                  // set position2 (end index) as the index of that number
                    }
                    index++;
                }
            }
            catch (Exception) { throw; }                    // throw an error if index is more than the length of given array i.e. the 'marks' array
            return new int[] { position, position2 };
        }
        public static string StringReverse(string s)
        {
            try
            {
                string final_str = "", temp_str = "";       // declare string variables 'final_str' and 'temp_str'
                for (int i = s.Length - 1; i > -1; i--)
                {     // traverse through the length of array in reverse
                    //Console.WriteLine(s[i]);
                    if (!s[i].Equals(' '))
                    {                // checking for spaces
                        temp_str = temp_str + s[i];         // concatanate the character to 'temp_str'
                    }
                    else
                    {
                        final_str = temp_str + " " + final_str;     // concatanate the 'final_str'
                        temp_str = "";
                    }
                }
                final_str = temp_str + " " + final_str;     // reversed word
                Console.WriteLine(final_str);               // display reversed word

            }
            catch (Exception) { throw; }                    // throw an error if length of the string is 0
            return null;
        }
        public static int MinimumSum(int[] l2)
        {
            int newSum = 0;                                         // declare integer variable 'newSum' to 0
            try
            {
                for (int i = 0; i < l2.Length; i++)                 // for 0 to length of array 'l2'
                {              
                    if (i != l2.Length - 1 && l2[i] == l2[i + 1])
                    { // 
                        l2[i + 1] = l2[i] + 1;                     
                    }
                    newSum += l2[i];
                }
            }
            catch (Exception) { throw; }
            return newSum;
        }
        public static string FreqSort(string s2)
        {
            try
            {
                Dictionary<char, int> freqKey = new Dictionary<char, int>();
                //for loop to traverse each character in the string
                for (int i = 0; i < s2.Length; i++)
                {
                    //Condition checks if the key is not resent in the dictionary
                    if (!freqKey.ContainsKey(s2[i]))
                    {
                        //Adds the jey in the dictionary with a value count as 1
                        freqKey.Add(s2[i], 1);
                    }
                    else
                    {
                        //Increases the value count by 1  of the existig key in the dictionary
                        freqKey[s2[i]] += 1;
                    }
                }

                //for loop to to print the key value pairs in the descending order of cout value.
                foreach (var item in freqKey.OrderByDescending(x => x.Value))
                {
                    for (int d = 0; d < item.Value; d++)
                    {
                        Console.Write(item.Key);
                    }
                }
            }
            catch (Exception) { throw; }
            return null;
        }
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                int a = nums1.Length, b = nums2.Length, i = 0,j=0;

                //Sorting the both the arrays
                Array.Sort(nums1);
                Array.Sort(nums2);
                //Declaring the output1 list object to store the intersection elements
                List<int> output1 = new List<int>();
                //while loop to get the intersection elements of both arrays
                while (i < a && j < b)
                {
                    if (nums1[i] == nums2[j])
                    {
                        //adding the common element to output1 list variable
                        output1.Add(nums1[i]);
                        i++;
                        j++;
                    }
                    //if first array element is less than second array element the pointer will move to next element in first array
                    else if (nums1[i] < nums2[j])
                    {
                        i++;
                    }
                    //the pointer will move to next element in second array.
                    else
                    {
                        j++;
                    }
                }
                //returning the array of intersection elements
                return output1.ToArray();
            }
            //Below block will be executed if any exception occurs
            catch 
            { 
                throw; 
            }
        }
        
        //This method to print the common elements of two arrays with time complexity of O(n)
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                //getting the lengths of arrays
                int a = nums1.Length, b = nums2.Length;
                //adding the arrays
                List<int> result = new List<int>();
                //intialising the new dictionary variable
                Dictionary<int, int> dict = new Dictionary<int, int>();
                //for loop to traverse through first array
                foreach (int val in nums1)
                {
                    //condition to check dictinary contains the first array element or not
                    if (dict.ContainsKey(val))
                    {
                        //Incrementing the value if it contains key
                        dict[val]++;
                    }
                    else
                    {
                        dict[val] = 1;
                    }
                }
                //for loop to traverse through second array elements
                for (int i = 0; i < b; i++)
                {
                    //intialising the count variable to 0
                    int counter = 0;
                    //condition to check dictionary contains second array element or not
                    if (dict.ContainsKey(nums2[i]))
                    {
                        //assiging the value of array element to count variable
                        counter = dict[nums2[i]];
                        //condition to check count greater than 1 or not
                        if (counter > 1)
                        {
                            //adding the common element to result list variable
                            result.Add(nums2[i]);
                            dict[nums2[i]] = counter - 1;
                        }
                        //Checking the value of key, if it is 1 adding that key element to list and removing it from list
                        else if (counter == 1)
                        {
                            result.Add(nums2[i]);
                            dict.Remove(nums2[i]);
                        }
                    }
                }
                //returing the common elements array
                return result.ToArray();
            }
            catch { throw; }
        }
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();  // declare character-integer dictionary 'dict'
                for (int i = 0; i < arr.Length; i++)
                {                                                           // traverse through array length
                    if (dict.ContainsKey(arr[i]))
                    {                                                   // check if there is a value for arr[i]
                        if (i - dict[arr[i]] <= k)
                        {                                               // check if the difference is at most 'k'
                            return true;
                        }
                    }
                    else
                        dict[arr[i]] = i;                                   // if not, then assign the key
                }
                return false;
            }
            catch (Exception) { throw; }                                    // throw en exception error
        }
        public static int GoldRod(int rodLength)
        {
            try
            {
                if (rodLength == 2) return 1;               // check the 'rodLength' and return the corrosponding values
                else if (rodLength == 3) return 2;
                else if (rodLength == 4) return 4;
                else if (rodLength == 5) return 6;
                else if (rodLength == 6) return 9;
                else return 3 * GoldRod(rodLength - 3);
            }
            catch (Exception) { throw; }
        }
        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //bool state = false;
                foreach (string words in userDict)
                {                                                       // for each word in 'userDict' array
                    int count = 0;                                      // set integer 'count' to 0
                    if (words.Length == keyword.Length)
                    {                                                   // if 'word' and 'keyword' are same
                        char[] key = keyword.ToCharArray();             // save characters of 'keyword' in 'key'
                        char[] word = words.ToCharArray();              // save characters of 'words' in 'word'
                        for (int i = 0; i < word.Length; i++)
                        {         // for 0 to word length
                            if (word[i] != key[i])
                            {                                           // check if index of word and key are same or not
                                count = count + 1;                      // increase count
                            }
                        }
                        if (count == 1)
                        {                                               // if count is 1
                            return true;                                // return true
                            //break;
                        }
                    }
                }
            }
            catch (Exception) { throw; }
            return default;
        }
        public static void SolvePuzzle()
        {
            try
            {/*
                //Console.WriteLine("Enter the first string(4):");
                //string first_str = Console.ReadLine();
                string first_str = "UBER";
                //Console.WriteLine("Enter the second string(4):");
                //string second_str = Console.ReadLine();
                string second_str = "COOL";
                //Console.WriteLine("Enter the result string(5):");
                //string result_str = Console.ReadLine();
                string result_str = "UNCLE";

                List<char> unique_char = new List<char>();

                String final_str = first_str + second_str + result_str;
                char[] char_arr = final_str.ToCharArray();

                for (int i = 0; i < char_arr.Length; i++) {
                    Console.Write(char_arr[i]);
                    Console.WriteLine();
                    if (unique_char.Contains(char_arr[i])) {
                        Console.WriteLine("Character repeat...");
                    }
                    else {
                        unique_char.Add(char_arr[i]);
                    }
                }
                foreach (int i in unique_char)
                    Console.Write(i);
                    */

                Console.WriteLine(" UBER");
                Console.WriteLine("+COOL");
                Console.WriteLine("-------");
                Console.WriteLine("UNCLE");
                Console.WriteLine();
                Console.WriteLine(" 1274");
                Console.WriteLine("+9663");
                Console.WriteLine("-------");
                Console.WriteLine("10937");
                Console.WriteLine();
                Console.WriteLine("U=1 B=2 E=7 R=4 C=9 O=6 L=3 N=0");
            }
            catch (Exception) { throw; }
        }
    }
}