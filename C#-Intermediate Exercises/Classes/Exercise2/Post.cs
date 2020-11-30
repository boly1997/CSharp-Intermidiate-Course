using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Post
    {
        private string _title { get; set; }

        private string _description { get; set; } 

        private DateTime _createdDate { get; set; }

        private int _upVotes { get; set; }

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._createdDate = DateTime.Now;
            this._upVotes = 0;
        }

        public void UpVote()
        {
            _upVotes++;
        }
        public void DownVote()
        {
            _upVotes--;
        }

        public string GetPost()
        {
            string post = $"Title: {_title} Description: {_description} Created Date: {_createdDate} Votes: {_upVotes}";
            return post;
        }
    }
}
