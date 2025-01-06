namespace DrThem.Libary.APICalling
{
    public class SingleResponseMessage<T>
    {
        public bool IsSuccess { get; set; }
        public T Item { get; set; }

        public ErrorMessage Err { get; set; }

        public SingleResponseMessage()
        {
            IsSuccess = false;
            Err = new ErrorMessage();
        }

        public SingleResponseMessage(string message)
        {
            IsSuccess = false;
            Err = new ErrorMessage
            {
                MsgCode = "001",
                MsgString = message
            };
        }
    }

    public class ActionMessage
    {
        public object Respone { get; set; }
        public bool IsSuccess { get; set; }

        public ErrorMessage Err { get; set; }

        public ActionMessage()
        {
            IsSuccess = false;
            Err = new ErrorMessage();
        }

        public ActionMessage(string message)
        {
            IsSuccess = false;
            Err = new ErrorMessage
            {
                MsgCode = "001",
                MsgString = message
            };
        }
    }

    public class ErrorMessage
    {
        public string MsgCode { get; set; }

        public string MsgString { get; set; }
    }


    public class ListResponseMessage<T>
    {
        public bool IsSuccess { get; set; }

        public int TotalRecords { get; set; }

        public List<T> Data { get; set; }

        public ErrorMessage Err { get; set; }

        public ListResponseMessage()
        {
            Err = new ErrorMessage();
            Data = new List<T>();
        }
    }
}
