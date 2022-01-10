/*
        % Word Reversal Challenge %
            @ 12/4/21 @

$ Write the code necessary to:
    > reverse the letters of each word in place and display the result.
    @ In other words, don't just reverse every letter in the variable pangram.

    < Instead, you'll need to:
        ~ reverse just the LETTERS in each word
        ~ BUT print the reversed word in its ORIGINAL POSITION in the message.

! START WITH THIS CODE:
    ? string pangram = "The quick brown fox jumps over the lazy dog";

$ FINISH WITH THIS CODE:
    > "ehT kciuq nworb xof spmuj revo eht yzal god"

^    ! This is a particularly difficult challenge! !
> You'll need to combine many of the concepts you've learned in this exercise...
% Including the use of:
    & string.Split()
    & char[] array = value.ToCharArray()
    & Array.Reverse()
    & String.Join()

*/
using System;
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' '); //% Breaks down string to an array containing all 9 words.
string[] pangram_rev = new string[pangram.Length]; //* Create empty array with exact number of string placeholders as words in pangram for final output.
for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray(); //< break down each word to its individual letters, and adds resulting chars to array.
    Array.Reverse(letters); // ? REVERSE array of chars from original word 1 by 1
    pangram_rev[i] = new string(letters); //> Convert each newly reversed char-array back to words in new string array, and repeat for all words.
}

string result = String.Join(" ", pangram_rev); //< Rejoin all words together by a space: the same character they were split by.
Console.WriteLine(result);