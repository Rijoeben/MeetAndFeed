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
        private IUserService _userService;

        public Post CreatePost(string title, string dish, string description, DateTime date, int amountOfPeople, long userId)
        {
            User postCreator = _userService.ReadUser(userId);
           
            Post newPost = new Post();
            newPost.Title = title;
            newPost.Creator = postCreator;
            newPost.Dish = dish;
            newPost.Description = description;
            newPost.Date = date;
            newPost.AmountOfPeople = amountOfPeople;

            _repo.AddPost(newPost);
            return newPost;
        }

        public Post ChangePost(string title, string dish, string description, DateTime date, int amountOfPeople, long postId)
        {
            Post postToChange = ReadPost(postId);

            if(postToChange != null)
            {
                postToChange.Title = title;
                postToChange.Dish = dish;
                postToChange.Description = description;
                postToChange.Date = date;
                postToChange.AmountOfPeople = amountOfPeople;

                _repo.UpdatePost(postToChange);
                return postToChange;
            }
            else
            {
                return null;
            }            
        }

        public IEnumerable<Post> ListOfPosts()
        {
            return _repo.ReadPosts();
        }

        public void RemovePost(long postId)
        {
            _repo.DeletePost(postId);
        }

        public Post ReadPost(long postId)
        {
            return _repo.GetPost(postId);
        }
    }
}
