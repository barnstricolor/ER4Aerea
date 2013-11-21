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
                    ConsumerKey = "QmSPVLJdEPZ6CyIqOXlh1A",
                    ConsumerSecret = "CItZWCg5gHTclJ6P6YbsVOi0dX8WrUREn0daoOLI",
                    TwitterAccessToken = "83849807-0OFC4nl1dC2ZMRnhljmU7pdIIrxZuJFIqXNEcU3tK",
                    TwitterAccessTokenSecret = "edbQkFvSqroxybqee5ISKWWiNq2LxHEa9fh8gzCMDQjwQ"
                }
            };

            auth.Authorize();

            twitterCtx = new TwitterContext(auth);
        }

        public void postar(string msg)
        {
            autorizar();
            twitterCtx.UpdateStatus(msg + new DateTime().ToString());
        }

    }
}
