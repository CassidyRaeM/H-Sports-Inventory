﻿using H_Sports.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;



namespace H_Sports.Interfaces
{
    public interface IReviewRepository
    {
        // Retrieve all reviews
         List<Review> GetReviews();

        /// Add a new review
        Review CreateReview( Review review);

        // Retrieve a review by its ID
        Review GetReviewById(int ID);





       
        //// Edit an existing review
        //void EditReview(Review review);


        //// Delete a review by its ID
        //void DeleteReview(string id); 


    }
}
