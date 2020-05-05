using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Runtime.InteropServices.ComTypes;
using System.Net;
using MaxMind.GeoIP2.Exceptions;

namespace BL
{
    public class PostService : IPostService
    {
        private IPostRepository _repo; // is nodig om de hier iets in te zetten. zonder dit krijg je null exception! geldt voor alle repositories
        private IReviewService _revService;
        private IUserService _userService;
        public PostService()
        {
            _repo = new PostRepository();  //maakt gewoon een nieuwe repo aan zodat deze met de service laag kan communiceren. Dit verhelpt de Nullexception die je zou krijgen anders.
            _revService = new ReviewService();
            _userService = new UserService();
        }
        //zelfde principe geldt voor de repositories.
        public Post CreatePost(string chef, string dish, string description, DateTime date, int amountOfPeople, long userId)
        {
            //User postCreator = _userService.ReadUser(userId); _userservice is null? even nakijken die handel, eerst alles werkend krijgen
           
            Post newPost = new Post();
            newPost.Chef = chef;
            newPost.Dish = dish;
            newPost.Description = description;
            newPost.Date = date;
            newPost.AmountOfPeople = amountOfPeople;
            newPost.UserId = userId;
            newPost.Reviews = new List<Review>();
            newPost.Participants = new List<User>();
            _repo.AddPost(newPost);
            return newPost;
        }
        public Post ChangePost(string dish, string description, DateTime date, int amountOfPeople, long postId)
        {
            Post postToChange = ReadPost(postId);

            if(postToChange != null)
            {
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
        public bool AddingReview(long revId, long postId)
        {
            var succes = false;
            var addedReview = _revService.ReadReview(revId);
            var postToAdd = _repo.GetPost(postId);

            if(postToAdd.Reviews.Contains(addedReview))
            {
                succes = false;
            }
            else
            {
                if (postToAdd.Reviews != null)
                {
                    postToAdd.Reviews.Add(addedReview);
                }
                else
                {
                    postToAdd.Reviews = new List<Review>() { addedReview };
                }

                _repo.UpdatePost(postToAdd);
                succes = true;
            }
            return succes;

        }

        public bool AddingParticipant(long userId,long postId)
        {
            var succes = false;
            var addedUser = _userService.ReadUser(userId);
            var postToAdd = _repo.GetPostWithParticipant(postId);

            if(postToAdd.Participants.Contains(addedUser))
            {
                succes = false;
            }
            else
            {
                if (postToAdd.Participants != null)
                {
                    postToAdd.Participants.Add(addedUser);
                    succes = true;
                }
                else
                {
                    postToAdd.Participants = new List<User>() { addedUser };
                    succes = true;
                }

                _repo.UpdatePost(postToAdd);
                succes = true;
            }
            return succes;
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
