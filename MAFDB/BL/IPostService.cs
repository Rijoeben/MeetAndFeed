using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;
namespace BL
{
    public interface IPostService
    {
        IEnumerable<Post> ListOfPosts();
        public Post CreatePost( string dish, string description, DateTime date, int amountOfPeople); //long userId);

        public void RemovePost(long postId);

        public Post ChangePost(string dish, string description, DateTime date, int amountOfPeople, long postId);

        public Post ReadPost(long postId);

    }
}
