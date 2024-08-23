namespace WCollectionAI.Response
{
    public class ChoicesResponse
    {
        public int Index { get; set; }
        public MessageResponse Message { get; set; }
        public string? Logprobs { get; set; }
        public string FinishReason { get; set; }
    }
}
