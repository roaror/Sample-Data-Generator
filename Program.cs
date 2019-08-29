using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace Sample_Data_Generator
{
    public enum Type
{
        TwitterUser,
        TwitterAdmin,
        TwitterCelebrity
}
    public class Program
    {       
        private static readonly Uri _endpoint = new Uri("https://roaror.documents.azure.com:443/");
        private static readonly string _primaryKey = "zIjscQcXPgMZQEg4jRdx0T3cDfuE92sjKixZ6ujjUlsKTdYhkqHXIsFn6UzVV69m3yHbhwIZSA3UTAeHoTsruA==";
        public static void Main(String [] args)
        {
            for(int i=0; i<5; i++)
            {
                addDocuments().GetAwaiter().GetResult();
                // addDocuments2().GetAwaiter().GetResult();
                // addDocuments3().GetAwaiter().GetResult();
                // addDocuments4().GetAwaiter().GetResult();
                // addDocuments5().GetAwaiter().GetResult();
                // addDocuments6().GetAwaiter().GetResult();

            }

            Console.WriteLine("\n\n\nDocument Insertion Done");

        }


        public static async Task addDocuments ()
            {
                DateTime start = DateTime.Today.AddDays(-30);
            DateTime end = DateTime.Today;

           using (DocumentClient client = new DocumentClient(_endpoint, _primaryKey))
            {
                await client.OpenAsync();

                Uri collection = UriFactory.CreateDocumentCollectionUri("SparkDatabase", "Twitter");

                var tweets_Generated = new Bogus.Faker<Tweet>()
                .RuleFor(i => i.like_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.comments_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.repost_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.deleted, (fake) => fake.Random.Bool())
                .RuleFor(i => i.tweetID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.userID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.created_At, (fake) => fake.Date.Between(start, end))
                .RuleFor(i => i.tweet_Content, (fake) => fake.Lorem.Text())
                .RuleFor(i => i.type, f => f.PickRandom<Type>().ToString())
                .Generate(10000000);


                foreach(var tweets in tweets_Generated)    
                {
                    ResourceResponse<Document> result = await client.CreateDocumentAsync(collection, tweets);
                    await Console.Out.WriteLineAsync($"Document #{tweets_Generated.IndexOf(tweets):000} Created\t{result.Resource.Id}");
                }
            }
            }



            public static async Task addDocuments2 ()
            {
                DateTime start = DateTime.Today.AddDays(-30);
            DateTime end = DateTime.Today;

           using (DocumentClient client = new DocumentClient(_endpoint, _primaryKey))
            {
                await client.OpenAsync();

                Uri collection = UriFactory.CreateDocumentCollectionUri("SparkDatabase", "Twitter");

                var tweets_Generated = new Bogus.Faker<Tweet>()
                .RuleFor(i => i.like_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.comments_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.repost_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.deleted, (fake) => fake.Random.Bool())
                .RuleFor(i => i.tweetID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.userID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.created_At, (fake) => fake.Date.Between(start, end))
                .RuleFor(i => i.tweet_Content, (fake) => fake.Lorem.Text())
                .RuleFor(i => i.type, f => f.PickRandom<Type>().ToString())
                .Generate(10000000);


                foreach(var tweets in tweets_Generated)    
                {
                    ResourceResponse<Document> result = await client.CreateDocumentAsync(collection, tweets);
                    await Console.Out.WriteLineAsync($"Document #{tweets_Generated.IndexOf(tweets):000} Created\t{result.Resource.Id}");
                }
            }
            }


            public static async Task addDocuments3 ()
            {
                DateTime start = DateTime.Today.AddDays(-30);
            DateTime end = DateTime.Today;

           using (DocumentClient client = new DocumentClient(_endpoint, _primaryKey))
            {
                await client.OpenAsync();

                Uri collection = UriFactory.CreateDocumentCollectionUri("SparkDatabase", "Twitter");

                var tweets_Generated = new Bogus.Faker<Tweet>()
                .RuleFor(i => i.like_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.comments_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.repost_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.deleted, (fake) => fake.Random.Bool())
                .RuleFor(i => i.tweetID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.userID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.created_At, (fake) => fake.Date.Between(start, end))
                .RuleFor(i => i.tweet_Content, (fake) => fake.Lorem.Text())
                .RuleFor(i => i.type, f => f.PickRandom<Type>().ToString())
                .Generate(10000000);


                foreach(var tweets in tweets_Generated)    
                {
                    ResourceResponse<Document> result = await client.CreateDocumentAsync(collection, tweets);
                    await Console.Out.WriteLineAsync($"Document #{tweets_Generated.IndexOf(tweets):000} Created\t{result.Resource.Id}");
                }
            }
            }

            public static async Task addDocuments4 ()
            {
                DateTime start = DateTime.Today.AddDays(-30);
            DateTime end = DateTime.Today;

           using (DocumentClient client = new DocumentClient(_endpoint, _primaryKey))
            {
                await client.OpenAsync();

                Uri collection = UriFactory.CreateDocumentCollectionUri("SparkDatabase", "Twitter");

                var tweets_Generated = new Bogus.Faker<Tweet>()
                .RuleFor(i => i.like_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.comments_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.repost_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.deleted, (fake) => fake.Random.Bool())
                .RuleFor(i => i.tweetID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.userID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.created_At, (fake) => fake.Date.Between(start, end))
                .RuleFor(i => i.tweet_Content, (fake) => fake.Lorem.Text())
                .RuleFor(i => i.type, f => f.PickRandom<Type>().ToString())
                .Generate(10000000);


                foreach(var tweets in tweets_Generated)    
                {
                    ResourceResponse<Document> result = await client.CreateDocumentAsync(collection, tweets);
                    await Console.Out.WriteLineAsync($"Document #{tweets_Generated.IndexOf(tweets):000} Created\t{result.Resource.Id}");
                }
            }
            }

            public static async Task addDocuments5 ()
            {
                DateTime start = DateTime.Today.AddDays(-30);
            DateTime end = DateTime.Today;

           using (DocumentClient client = new DocumentClient(_endpoint, _primaryKey))
            {
                await client.OpenAsync();

                Uri collection = UriFactory.CreateDocumentCollectionUri("SparkDatabase", "Twitter");

                var tweets_Generated = new Bogus.Faker<Tweet>()
                .RuleFor(i => i.like_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.comments_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.repost_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.deleted, (fake) => fake.Random.Bool())
                .RuleFor(i => i.tweetID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.userID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.created_At, (fake) => fake.Date.Between(start, end))
                .RuleFor(i => i.tweet_Content, (fake) => fake.Lorem.Text())
                .RuleFor(i => i.type, f => f.PickRandom<Type>().ToString())
                .Generate(10000000);


                foreach(var tweets in tweets_Generated)    
                {
                    ResourceResponse<Document> result = await client.CreateDocumentAsync(collection, tweets);
                    await Console.Out.WriteLineAsync($"Document #{tweets_Generated.IndexOf(tweets):000} Created\t{result.Resource.Id}");
                }
            }
            }

            public static async Task addDocuments6 ()
            {
                DateTime start = DateTime.Today.AddDays(-30);
            DateTime end = DateTime.Today;

           using (DocumentClient client = new DocumentClient(_endpoint, _primaryKey))
            {
                await client.OpenAsync();

                Uri collection = UriFactory.CreateDocumentCollectionUri("SparkDatabase", "Twitter");

                var tweets_Generated = new Bogus.Faker<Tweet>()
                .RuleFor(i => i.like_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.comments_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.repost_Count, (fake) => fake.Random.Number(0,100000))
                .RuleFor(i => i.deleted, (fake) => fake.Random.Bool())
                .RuleFor(i => i.tweetID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.userID, (fake) => fake.Random.Uuid().ToString())
                .RuleFor(i => i.created_At, (fake) => fake.Date.Between(start, end))
                .RuleFor(i => i.tweet_Content, (fake) => fake.Lorem.Text())
                .RuleFor(i => i.type, f => f.PickRandom<Type>().ToString())
                .Generate(10000000);


                foreach(var tweets in tweets_Generated)    
                {
                    ResourceResponse<Document> result = await client.CreateDocumentAsync(collection, tweets);
                    await Console.Out.WriteLineAsync($"Document #{tweets_Generated.IndexOf(tweets):000} Created\t{result.Resource.Id}");
                }
            }
            }

    }
}
