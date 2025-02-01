using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.MOD
{
  
    public class GlobalVariable
    {
        private static int userGlobalID;
        private static Author authorObj;
        private static Publisher publisherObj;
        private static Book bookObj;
        private static User userObj;
        private static Candidate candidateObj;
        private static Country countryObj;
        private static Course courseObj;
        private static Rank rankObj;
        public static int GlobalUserID
        {
            get { return userGlobalID; }
            set { userGlobalID = value; }
        }

        public static User GlobalUserObj
        {
            get { return userObj; }
            set { userObj = value; }
        }

        public static Candidate GlobalCandidateObj
        {
            get { return candidateObj; }
            set { candidateObj = value; }
        }

        public static Author GlobalAuthorObj
        {
            get { return authorObj; }
            set { authorObj = value; }
        }
        public static Publisher GlobalPublisherObj
        {
            get { return publisherObj; }
            set { publisherObj = value; }
        }
        public static Book GlobalBookObj
        {
            get { return bookObj; }
            set { bookObj = value; }
        }

        public static Country GlobalCountryObj
        {
            get { return countryObj; }
            set { countryObj = value; }
        }
        public static Course GlobalCourseObj
        {
            get { return courseObj; }
            set { courseObj = value; }
        }

        public static Rank GlobalRankObj
        {
            get { return rankObj; }
            set { rankObj = value; }
        }

    }
}
