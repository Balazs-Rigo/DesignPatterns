using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DesignPatterns.Facade.Exercise
{
    public class TwitterAPI
    {
        private string appKey;
        private string secret;

        public TwitterAPI(string appKey, string secret)
        {
            this.appKey = appKey;
            this.secret = secret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();
            var tweets = twitterClient.GetRecentTweets(GetAccessToken());

            return tweets;
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey","secret");
            var accessToken = oauth.getAccesToken(requestToken);

            return accessToken;
        }
    }
}
