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
        public Post CreatePost(string chef, string dish, string description, DateTime date, int amountOfPeople,long userId);
        public void RemovePost(long postId);
        public Post ChangePost(string dish, string description, DateTime date, int amountOfPeople, long postId);
        public Post ReadPost(long postId);
        public bool AddingReview(long revId, long postId); //Geeft true terug als de review toe werd gevoegd. Als de review er al in stond geeft het false
        public bool AddingParticipant(long userId, long postId); //Geeft true terug als de User is toegevoed. Als de user al is toegevoed geeft dit een false terug
        public Post AddingAllergies(List<long> ids, long postId);

    }
}
