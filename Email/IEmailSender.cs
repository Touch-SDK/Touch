namespace Touch.Email
{
    public interface IEmailSender
    {
        void Send(EmailMessage message);
    }
}
