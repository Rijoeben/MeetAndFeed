using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BL
{
    public class PostService : IPostService
    {
        private IPostRepository _repo;

        public Post CreatePost(string title, string dish, string description, DateTime date, int amountOfPeople, double score) // Misschien niet nodig.
        {
            Post newPost = new Post();


            newPost.Title = title;
            newPost.Dish = dish;
            newPost.Description = description;
            newPost.Date = date;
            newPost.AmountOfPeople = amountOfPeople;
            newPost.Score = score;

            _repo.AddPost(newPost);
            return newPost;
        }

        public void ChangePost(Post post)
        {
            _repo.UpdatePost(post);
        }

        public IEnumerable<Post> ListOfPosts()
        {
            return _repo.ReadPosts();
        }

        public void RemovePost(string postID)
        {
            _repo.DeletePost(postID);
        }
    }
}
