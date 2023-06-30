using OpenAI_API;
  
var openAi = new OpenAIAPI("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");
var completions=openAi.Completions.CreateCompletionAsync
(
    prompt:"What would happen if all people above 21 suddenly disappeared?",
    model:"text-davinci-002",
    max_tokens:100
);

    foreach (var completion in completions.Result.Completions)
    {
        Console.Write(completion.Text);
    }


