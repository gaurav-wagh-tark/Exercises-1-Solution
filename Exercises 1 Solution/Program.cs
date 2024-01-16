namespace Exercises_1_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1---------------------
            //HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            //String[] dictionary = { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" };
            //String encoding = huffmanDecoding.Decoder("001101100101100110111101011001011001010", dictionary);
            //Console.WriteLine(encoding);

            // Problem  2----------------------------
            //LexmaxReplace lexmaxReplace = new LexmaxReplace();

            //string st=lexmaxReplace.get("xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk");
            //Console.WriteLine("Hii");  
            //Console.WriteLine(lexmaxReplace.get("abb","c"));  
            //Console.WriteLine(lexmaxReplace.get("fedcba", "ee"));  

            //Problem 3---------------------------------
            //SortingSubsets sortingSubsets = new SortingSubsets();
            //Console.WriteLine(sortingSubsets.getMinimalSize(new int[] { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 }));

            //Problem 4------------------------------
            //PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            //Console.WriteLine(palindromeDecoding.decode("Misip", new int[] { 2, 3, 1, 7 }, new int[] { 1, 1, 2, 2 }));

            //Problem 5------------------------------------
            //MovingAvg movingAvg = new MovingAvg();
            //Console.WriteLine( movingAvg.difference(3, new double[] { 17, 6.2, 19, 3.4 }));

            //Problem 6----------------------------
            //WordCompositionGame wordCompositionGame = new WordCompositionGame();
            //Console.WriteLine(wordCompositionGame.score(new string[] { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" }
            //,new string[] { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" }
            //,new string[] { "dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda" }));
            //Problem 7----------------------------
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            Console.WriteLine(largestSubsequence.getLargest("test"));


            //Problem 8----------------------------
            //MaximumBalances maximumBalances = new MaximumBalances();
            //Console.WriteLine( maximumBalances.solve("))()()))(()"));

            //Problem 9-----------------------------------------
            //DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            //Console.WriteLine(dukeOnChessBoard.dukePath(3, "a2"));

            //Problem 10-------------------------
            //Islands islands = new Islands();
            //Console.WriteLine(islands.beachLength(new string[] {"#...#.....","##..#...#."}));

            //Problem 11----------------------------
            //Mailbox mailbox = new Mailbox();
            //Console.WriteLine( mailbox.impossible("ABCDAAST", new string[] { "111 A ST", "A BAD ST", "B BAD ST" }));


            //Problem 12----------------------------
            //MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();

            //Console.WriteLine(mysticAndCandiesEasy.minBoxes(10, 7, new int[] { 3,3,3,3,3 }));
            //Console.WriteLine(mysticAndCandiesEasy.minBoxes(100, 63, new int[] { 12, 34, 23, 45, 34 }));
            //Console.WriteLine(mysticAndCandiesEasy.minBoxes(19, 12, new int[] {12, 9, 15, 1, 6, 4, 9, 10, 10, 10, 14, 14, 1, 1, 12, 10, 9, 2, 3, 6,
            //                                                                   1, 7, 3, 4, 10, 3, 14}) );
            //Console.WriteLine(mysticAndCandiesEasy.minBoxes(326, 109, new int[] {9, 13, 6, 6, 6, 16, 16, 16, 10, 16, 4, 3, 10, 8, 11, 17, 12, 5, 7,
            //8, 7, 4, 15, 7, 14, 2, 2, 1, 17, 1, 7, 7, 12, 17, 2, 9, 7, 1, 8, 16,
            //7, 4, 16, 2, 13, 3, 13, 1, 17, 6}));

            //Problem 13---------------------------
            //PrintScheduler printScheduler = new PrintScheduler();
            //Console.WriteLine(printScheduler.getOutput(new string[] { "AB", "CD" } , new string[] { "0 1", "1 1", "0 1", "1 2" }));

            //Problem 14---------------------------
            //TurningLightOn turningLightOn = new TurningLightOn();
            //Console.WriteLine(turningLightOn.minFlips(new string[] {"0101","1010","0101","1010"}));
        }
    }
}
