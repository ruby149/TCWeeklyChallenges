﻿using System;
using System.Collections.Generic;

namespace WeeklyChallenges
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            
                for (var i = startNumber + 1; i < (startNumber + n) + 1; i++)
                {
                    if (i % n == 0)
                    {
                        return i;
                    }
                }
                return 0;
            
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
