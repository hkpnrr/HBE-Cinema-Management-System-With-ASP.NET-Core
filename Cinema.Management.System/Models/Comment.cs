using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Comment
    {
        public int movieId { get; set; }
        public int userId { get; set; }
        public string commentContent { get; set; }

        public string userFirstName { get; set; }

        public string userLastName { get; set; }

        public Comment(int movieId, int userId, string userFirstName, string userLastName, string commentContent)
        {
            this.movieId = movieId;
            this.userId = userId;
            this.commentContent = commentContent;
            this.userFirstName = userFirstName;
            this.userLastName = userLastName;
        }



    }
}