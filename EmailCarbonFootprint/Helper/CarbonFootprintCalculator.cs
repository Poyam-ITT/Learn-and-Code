namespace EmailCarbonFootprint
{
    internal class CarbonFootprintCalculator
    {
        private EmailInfo entity;
        private CarbonFootprintResponse response;

        internal CarbonFootprintCalculator(EmailInfo entity)
        {
            this.entity = entity;
            this.response = new CarbonFootprintResponse();
        }

        internal CarbonFootprintResponse CalculateCarbonFootprint()
        {
            SetResponse();
            return response;
        }

        private void SetResponse()
        {
            response._email = entity._emailId;
            response._source = FetchSourceNameFromEmailId();
            response._inboxCarbonFootPrint = GetInboxCarbonFootPrint();
            response._sentCarbonFootPrint = GetSentCarbonFootPrint();
            response._spamCarbonFootPrint = GetSpamCarbonFootPrint();
        }

        private string FetchSourceNameFromEmailId()
        {
            string email = entity._emailId;
            int startIndex = email.IndexOf('@');
            
            if (startIndex >= 0 && startIndex < email.Length - 1)
            {
                string domain = email.Substring(startIndex + 1);
                int dotIndex = domain.IndexOf('.');
                if (dotIndex >= 0)
                {
                    return domain.Substring(0, dotIndex);
                }
            }
            return "Invalid Domain";
        }

        private double GetInboxCarbonFootPrint()
        {
            return entity._totalInboxMessages * CarbonFootprintConstants._inboxCarbonEmissionPerGram;
        }

        private double GetSentCarbonFootPrint()
        {
            return entity._totalSentMessages * CarbonFootprintConstants._sentCarbonEmissionPerGram;
        }

        private double GetSpamCarbonFootPrint()
        {
            return entity._totalSpamMessages * CarbonFootprintConstants._spamCarbonEmissionPerGram;
        }
    }
}
