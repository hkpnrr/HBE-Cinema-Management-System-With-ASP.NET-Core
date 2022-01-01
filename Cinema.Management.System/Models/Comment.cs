using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Comment
    {
        public int commentId { get; set; }
        public int movieId { get; set; }

        public string movieName { get; set; }
        public int userId { get; set; }
        public string commentContent { get; set; }

        public string userFirstName { get; set; }

        public string userLastName { get; set; }

        // For posting comment to database
        public Comment(int movieId, int userId, string userFirstName, string userLastName, string commentContent)
        {
            this.movieId = movieId;
            this.userId = userId;
            this.commentContent = commentContent;
            this.userFirstName = userFirstName;
            this.userLastName = userLastName;
        }

        // For displaying comments in admin panel
        public Comment(int commentId, int movieId, int userId, string userFirstName, string userLastName, string commentContent, string movieName)
        {
            this.commentId = commentId;
            this.movieId = movieId;
            this.movieName = movieName;
            this.userId = userId;
            this.commentContent = commentContent;
            this.userFirstName = userFirstName;
            this.userLastName = userLastName;
        }


    }
}