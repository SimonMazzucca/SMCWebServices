namespace SMCWebServices.DataAccess.Domain
{
    public class Response
    {
        public Response(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
