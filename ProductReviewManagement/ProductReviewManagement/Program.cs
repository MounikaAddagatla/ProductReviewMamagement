using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This is Product Review Management");
             List<ProductReviewModel> productReviewList = new List<ProductReviewModel>()
            {
               new ProductReviewModel(){ProductID=1,UserID=1,Rating=2,Review="Good",IsLike=false},
                new ProductReviewModel(){ProductID=2,UserID=1,Rating=4,Review="Good",IsLike=true},
                new ProductReviewModel(){ProductID=3,UserID=2,Rating=5,Review="Good",IsLike=true},
                new ProductReviewModel(){ProductID=4,UserID=2,Rating=6,Review="Good",IsLike=false},
                new ProductReviewModel(){ProductID=5,UserID=3,Rating=2,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=6,UserID=3,Rating=1,Review="bad",IsLike=true},
                new ProductReviewModel(){ProductID=7,UserID=5,Rating=1,Review="Good",IsLike=false},
                new ProductReviewModel(){ProductID=8,UserID=5,Rating=9,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=9,UserID=8,Rating=8,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=10,UserID=8,Rating=8,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=11,UserID=10,Rating=5,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=12,UserID=12,Rating=6,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=13,UserID=12,Rating=7,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=14,UserID=14,Rating=8,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=15,UserID=14,Rating=8,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=16,UserID=18,Rating=8,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=17,UserID=18,Rating=8,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=18,UserID=19,Rating=9,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=18,UserID=20,Rating=9,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=20,UserID=25,Rating=7,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=21,UserID=20,Rating=7,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=22,UserID=25,Rating=10,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=23,UserID=20,Rating=9,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=25,UserID=25,Rating=9,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=25,UserID=20,Rating=6,Review="nice",IsLike=true},
                new ProductReviewModel(){ProductID=17,UserID=18,Rating=11,Review="nice",IsLike=true}
            };
            //foreach (var review in productReviewList)
            //{
            //    Console.WriteLine("ProductID : " + review.ProductID + " UserID : " + review.UserID + " Rating : " + review.Rating
            //        + " Review : " + review.Review + " IsLike : " + review.IsLike);
            //}
            ProductManagement pm = new ProductManagement();
            Console.WriteLine("List of top three:");
            pm.TopRecords(productReviewList);
            Console.WriteLine("View rating by particular Ids:");
            pm.SelectIdRecord(productReviewList);
            Console.WriteLine(" count of review by  Id:");
            pm.CountReviewById(productReviewList);
            Console.ReadLine();
        }
    }
}
