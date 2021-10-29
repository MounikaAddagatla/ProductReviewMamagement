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
    }
}
