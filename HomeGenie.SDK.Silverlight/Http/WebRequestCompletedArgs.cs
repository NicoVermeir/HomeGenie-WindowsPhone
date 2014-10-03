namespace HomeGenie.SDK.Http
{
    public class WebRequestCompletedArgs
    {
        public string ResponseText;
        public WebRequestStatus RequestStatus;

        public WebRequestCompletedArgs(string response)
        {
            ResponseText = response;
        }

        public WebRequestCompletedArgs(WebRequestStatus error)
        {
            RequestStatus = error;
        }
    }
}