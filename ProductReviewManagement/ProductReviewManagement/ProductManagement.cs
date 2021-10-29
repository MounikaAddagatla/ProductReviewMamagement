using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace ProductReviewManagement
{
    class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();
        // UC2
        public void TopRecords(List<ProductReviewModel> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " IsLike : " + list.IsLike);
            }
        }
        /// <summary>
        /// UC3
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectIdRecord(List<ProductReviewModel> listProductReview)
        {
            var recordData = from ProductReview in listProductReview
                             where (ProductReview.ProductID == 3 || ProductReview.ProductID == 9 || ProductReview.ProductID == 6) && ProductReview.Rating > 5
                             select ProductReview;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " IsLike : " + list.IsLike);
            }
        }
        /// Uc4
        /// 
        public void CountReviewById(List<ProductReviewModel> listProductReview)
        {
            var recordCount = listProductReview.GroupBy(x => x.ProductID)
                .Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordCount)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Count " + list.Count);
            }
        }
        public void GetProductIdAndReview(List<ProductReviewModel> listProductReview)
        {
            var recordIdReview = from product in listProductReview select (product.ProductID, product.Review);
            foreach (var list in recordIdReview)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Review : " + list.Review);
            }
        }
        public void SkipFiveRecord(List<ProductReviewModel> listProductReview)
        {
            var records = (from product in listProductReview select product).Skip(5);
            foreach (var list in records)
            {
                Console.WriteLine("ProductID : " + list.ProductID + " UserID : " + list.UserID + " Rating : " + list.Rating
                    + " Review : " + list.Review + " IsLike : " + list.IsLike);
            }
        }
        public void ViewBYIdAndReview(List<ProductReviewModel> listProductReview)
        {
            var recordIdReview = from product in listProductReview select (product.ProductID, product.Review);
            foreach (var list in recordIdReview)
            {
                Console.WriteLine("Product id : " + list.ProductID + " Review : " + list.Review);
            }
        }
      
    }
}
