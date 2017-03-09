namespace ALForm
{
    public class Credentials : ICredentials
    {
        /* Class members */
        private string mDataSrc;
        private string mPassword;
        private string mUserId;

        /* Constructors */
        public Credentials() { }

        public Credentials(string pDataSrc, string pUserId, string pPassword)
        {
            mDataSrc = pDataSrc;
            mPassword = pPassword;
            mUserId = pUserId;
        }

        public Credentials(string pUserId, string pPassword)
        {
            mPassword = pPassword;
            mUserId = pUserId;
        }

        /* Properties */
        public string ConnectString
        {
            get
            {
                return "Data Source=" + mDataSrc
                      + ";Persist Security Info=True"
                      + ";User ID=" + mUserId
                      + ";Password=" + mPassword;
            }
        }

        public string DataSource
        {
            get { return mDataSrc; }
            set { mDataSrc = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public string UserId
        {
            get { return mUserId; }
            set { mUserId = value; }
        }

    }
}
