namespace WCollectionAI.Response
{
    public class AIResponse
    {
        public string Id { get; set; }
        public string Object {  get; set; }
        public int Created {  get; set; }
        public string Model { get; set; }
        public string SystemFingerPrint { get; set; }
        public ChoicesResponse Choices { get; set; }
        public UsageResponse Usage { get; set; }
    }
}
