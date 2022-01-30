/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK
*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0}", rotated_string);// {0} was added, it was missed.
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String final_string = "";
                //char []arr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O', 'U' };
                for (int i=0; i< s.Length; i++)
                {
                    // iterating through the string and not doing anything if the string contains vowels
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    {
                        continue;
                    }
                    // Adding the non-vowels to a new String Variable
                    else
                    {
                        final_string += s[i];
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                string string1 = "";
                string string2 = "";
                // adding the bulls_string1 to string1 variable for future comparision
                for (int i=0; i< bulls_string1.Length; i++)
                {
                    string1 += bulls_string1[i];
                }
                // adding the bulls_string2 to string2 variable for future comparision
                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    string2 += bulls_string2[i];
                }
                // if both are same return true else false
                if (string1 == string2)
                    return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                bool[] visited = new bool[bull_bucks.Length];
                int sum = 0;
                for (int i=0; i< bull_bucks.Length; i++)
                {
                    // for each element we iterate we are making it visited, if already visited we proceed to the next iteration
                    if (visited[i] == true)
                        continue;
                    else
                    {
                        int count = 0;
                        // Iterating from i+1 if there is a duplicate element we are making it true and counting the number of occurances
                        for (int j = i+1; j < bull_bucks.Length; j++)
                        {
                            if (bull_bucks[i] == bull_bucks[j])
                            {
                                visited[j] = true;
                                count += 1;
                            }
                        }
                        // if the count is 0 we will add the sum and return
                        if (count < 1)
                            sum += bull_bucks[i];
                    }
                }
                return sum;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                bool[,] visited = new bool[bulls_grid.GetLength(0), bulls_grid.GetLength(0)];
                int sum = 0;
                for (int i=0; i< bulls_grid.GetLength(0); i++)
                {
                    for (int j = 0; j < bulls_grid.GetLength(1); j++)
                    {
                        // this is to make the middle element process only once in order to avoid duplication
                        if (visited[i, j])
                            continue;
                        else
                        {
                            visited[i, j] = true;
                            // left diagonal elements have eual i and j and the right diagonal elements have i+j == row length or column length in a square
                            // matrix
                            if (i == j || (i+j) == bulls_grid.GetLength(0)-1)
                                sum += bulls_grid[i, j];
                        }
                    }
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                char[] rotated_string = new char[bulls_string.Length];
                // adding the characters into the newly created character array
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    rotated_string[i] = bulls_string[i];
                }
                // modifying the character according to the indices array and updating the rotated_string likewise and return at the end
                for (int i=0; i< indices.Length; i++)
                {
                    rotated_string[indices[i]] = bulls_string[i];
                }
                return new string(rotated_string);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                bool present = false;
                int presentAt = 9999999;
                // finding the character location from the string
                for (int i=0; i<bulls_string6.Length; i++)
                {
                    if (bulls_string6[i] == ch)
                    {
                        present = true;
                        presentAt = i;
                        break;
                    }    
                }
                // if the character is present we will make the string into 2 halves from that location
                if (present)
                {
                    string string1 = bulls_string6.Substring(0, presentAt + 1);
                    string string2 = bulls_string6.Substring(presentAt + 1);
                    // iterating reverse to get the reverse string
                    for (int j = string1.Length - 1; j >= 0; j--)
                    {
                        prefix_string += string1[j];
                    }
                    prefix_string += string2;
                }
                // if the character is not present in the string return the exact same string
                else
                {
                    prefix_string = bulls_string6;
                }
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}