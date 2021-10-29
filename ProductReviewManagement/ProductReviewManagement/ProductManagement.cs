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
                    + " Review : " + list.Review + " isLike : " + list.IsLike);
            }
        }
    }
}
