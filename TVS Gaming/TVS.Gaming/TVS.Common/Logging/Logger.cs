namespace TVS.Common.Logging
{
    public static class Logger
    {
        private static log4net.ILog Log { get; set; }

        static Logger()
        {
            Log = log4net.LogManager.GetLogger(typeof(Logger));
        }
        public static void Debug(object msg)
        {
            Log.Debug(msg);
        }

        public static void Warning(object msg)
        {
            Log.Warn(msg);
        }

        public static void Error(System.Exception ex)
        {
            Log.Error(ex.Message, ex);
        }

        public static void Info(object msg)
        {
            Log.Info(msg);
        }

        public static void Error(object msg)
        {
            Log.Info(msg);
        }

        public static void Fatal(object msg)
        {
            Log.Fatal(msg);
        }
    }
}
