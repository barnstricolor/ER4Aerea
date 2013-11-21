using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;

namespace ER4Aerea
{
    public class Twitter
    {
        TwitterContext twitterCtx;

        private void autorizar() {
            if (twitterCtx != null)
                return;

            var auth = new SingleUserAuthorizer
            {
                Credentials = new SingleUserInMemoryCredentials
                {
                    ConsumerKey = "NIa7b3cyQa4rZ4hqlC4oAQ",
                    ConsumerSecret = "1cOTHymyK2itKzvNJbSHqVU0BcgDGhXgGiZ5iKxQE",
                    TwitterAccessToken = "2164976383-XQwGVDO7TO3a8gqxuWcMrTaDo3ST44zj84ewlnt",
                    TwitterAccessTokenSecret = "HG15JneGyvH6jIW9UdsytxtfvwttpjSwUewWJg4RLpiCc"
                }
            };

            auth.Authorize();

            twitterCtx = new TwitterContext(auth);
        }

        public void postar(string msg)
        {
            autorizar();
            twitterCtx.UpdateStatus(msg);
        }

    }
}
