using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jaj.Misc
{
    // Klasa za serijalizaciju podataka
    public class LoggedInUserSerializeModel
    {
        public string Username { get; set; }
        public string profilePicture { get; set; }
        public string FavTag { get; set; }
        public int UserID { get; set; }

        internal void CopyFromUser(LoggedInUser user)
        {
            this.Username = user.Username;
            //this.Power = user.Power;
            this.profilePicture = user.profilePicture;
            this.FavTag = user.FavTag;
            this.UserID = user.UserID;
        }
    }
}