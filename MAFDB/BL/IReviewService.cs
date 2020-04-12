using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;
namespace BL
{
    public interface IReviewService
    {
        public Review CreateReview(string content);
    }
}
