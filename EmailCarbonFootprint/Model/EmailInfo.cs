namespace EmailCarbonFootprint
{
    internal class EmailInfo
    {
        internal string _emailId { get; }
        internal int _totalInboxMessages { get; }
        internal int _totalSentMessages { get; }
        internal int _totalSpamMessages { get; }

        internal EmailInfo(string email, int inbox, int spam, int sent)
        {
            _emailId = email;
            _totalInboxMessages = inbox;
            _totalSpamMessages = spam;
            _totalSentMessages = sent;
        }
    }
}