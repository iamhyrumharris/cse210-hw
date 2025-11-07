
class design - abstraction process
flow:
welcome message -> menu options with a questions of which one do we want -> type in response -> activate the action
What does the program do?
Journal app - record responses or entries and the user is given random prompts. There is the ability to save journal and then to load the journal entries.

Menu Options:
1. Write in Journal
2. Display Journal Entries
3. Save Journal to File
4. Load Journal from File
5. Exit

What user inputs does it have?
1. Menu selection
2. Journal entry response
3. File Name when saving
4. File Name when loading

What output does it produce?
1. Display Journal Entries
2. File saving

How does the program end?
User selects exit from menu options.


What are good candidates for classes in this program?/What are the primary responsibilities of each class?
Journal: Store and save/load files. Display entries that have been written. Put menu in a method and display it.
Entry: Place holder responses, prompts, and date.
Random Prompts: Display a random prompt when user selects option 1.

------

Journal - Class Name
Attributes - Variables
- _entries: List<Entry>

Behaviors - Methods or Functions
- Display(): void
- SaveToFile(filename: string): void
- LoadFromFile(filename: string): List<Entry>
- AddEntry(newEntry : Entry): void (Use add. to append entry to list)

Entry
Attributes
_date: String
_response: String
_prompt: String
Behaviors
Display(): void (String (Display the prompt, writeline))

PromptGenerator
Attributes
_prompts: List<String>
_randomSelectedPrompt: Random(Make sure to confirm the official c# class name)

Behaviors
- PickRandomPrompt: String
