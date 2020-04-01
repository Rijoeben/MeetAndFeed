using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    class IReviewsRepository
    {
        public interface IReviewRepository
        {
            IEnumerable<Review> ReadReview();

            Allergy CreateReview(Review review);

            void UpdateReview(Review review);

            void DeleteReview(Review review);
        }
    }
}
