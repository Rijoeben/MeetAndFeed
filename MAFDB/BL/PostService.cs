using MAFDB;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BL
{
    public class PostService : IPostService
    {
        private IPostRepository _repo; // is nodig om de hier iets in te zetten. zonder dit krijg je null exception! geldt voor alle repositories
        public PostService()
        {
            _repo = new PostRepository();  //maakt gewoon een nieuwe repo aan zodat deze met de service laag kan communiceren. Dit verhelpt de Nullexception die je zou krijgen anders.
        }
        //zelfde principe geldt voor de repositories.
        private IUserService _userService;

        public Post CreatePost(string dish, string description, DateTime date, int amountOfPeople) //long userId)
        {
            //User postCreator = _userService.ReadUser(userId); _userservice is null? even nakijken die handel, eerst alles werkend krijgen
           
            Post newPost = new Post();
            //newPost.Creator = postCreator;
            newPost.Dish = dish;
            newPost.Description = description;
            newPost.Date = date;
            newPost.AmountOfPeople = amountOfPeople;

            _repo.AddPost(newPost);
            return newPost;
        }

        public Post ChangePost( string dish, string description, DateTime date, int amountOfPeople, long postId)
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
