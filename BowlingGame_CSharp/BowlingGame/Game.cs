using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace BowlingGame
{
    public class Game
    {
        private Frame [] Frames = new Frame[10];
        private int CurrentFrame = 0;
        private bool FirstRoll = true;

        public Game()
        {
            for (int i = 0; i < Frames.Length; i++)
            {
                Frames[i] = new Frame();
            }
        }
        public void Roll(int pins)
        {
            if (FirstRoll)
            {
                Frames[CurrentFrame].FirstRoll = pins;
                FirstRoll = false;
            }
            else
            {
                Frames[CurrentFrame].SecondRoll = pins;
                CurrentFrame++;
                FirstRoll = true;
            }

        }

        public int Score()
        {
            int gameScore = 0;
            for (int frameIndex = 0; frameIndex < Frames.Length; frameIndex++)
            {
                int frameScore = Frames[frameIndex].FirstRoll + Frames[frameIndex].SecondRoll;
                if (frameScore == 10)
                {
                    gameScore += Frames[frameIndex +1].FirstRoll;
                }

                gameScore += frameScore;
            }
            return gameScore;
        }
    }

    public class Frame
    {
        public int FirstRoll;
        public int SecondRoll;


    }
}
