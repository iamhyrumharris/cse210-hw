/*
PromptGenerator
Attributes
_prompts: List<String>
_randomSelectedPrompt: Random(Make sure to confirm the official c# class name)
Behaviors
- PickRandomPrompt: String
*/


public class RandomPrompt
{
    public List<string> _prompts = new List<string>()
    {
        "What did you do today?",
        "Did you talk to anyone interesting",
        "What is the coolest thing that happened today?",
        "How was work?",
        "What was the best part of your day?",
        "What were you proud of today?"
    };
    public string PickRandomPrompt()
    {
        Random random = new Random();
        int somePrompt = random.Next(_prompts.Count);
        return _prompts[somePrompt];
    }

}