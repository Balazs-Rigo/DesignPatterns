﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade.Exercise
{
    public class TwitterClient
    {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}
