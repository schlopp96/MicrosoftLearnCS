/*
        % Word Reversal Challenge %
            @ 12/4/21 @
        > Edited: 1/10/21 <

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
string pangram = "The quick brown fox jumps over the lazy dog";

static string StringReverse(string val)
{

    string[] words = val.Split(' '); //% Split string by whitespace and set to array containing all 9 words.
    string[] val_rev = new string[val.Length]; //* Create empty array with exact size as number of words within pangram for final output.

    //> Iterate through string elements...
    for (int i = 0; i < words.Length; i++)
    {
        char[] letters = words[i].ToCharArray(); //< Assign each string element to own char array, breaking down element to individual chars.
        Array.Reverse(letters); // ? REVERSE array of chars from original word 1 by 1
        val_rev[i] = new string(letters); //> Convert each newly reversed char element back to word strings.
    }

    string result = string.Join(" ", val_rev); //< Rejoin all words together by a single space into an array.
    return result.TrimEnd();
}

Console.Write($"OG String:\n> \"{pangram}\"\n\nReversed String\n> \"{StringReverse(pangram)}\"");
