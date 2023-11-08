namespace EmailCarbonFootprint
{
    internal class CarbonFootprintResponse
    {
        internal string _email { get; set; }
        internal string _source { get; set; }
        internal double _inboxCarbonFootPrint { get; set; }
        internal double _sentCarbonFootPrint { get; set; }
        internal double _spamCarbonFootPrint { get; set; }
    }
}