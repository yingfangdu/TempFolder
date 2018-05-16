namespace TestApplicationVSStream
{
    public class Singleton<T> where T: new()
    {
        /// <summary>
        /// The static <see cref="object"/> used to lock thread sensitive access to resources.
        /// </summary>
        private static object lockObject = new object();

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
