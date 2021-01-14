using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;

namespace ElficoTM.Pages
{
    public partial class Index
    {
        [Parameter]
        public string Text { get; set; }

        private static List<Word> _words = new List<Word>
        {
            new ("Ay" ,"quenya", "Sì"),
            new ("Bala", "telerin","Dio"),
            new ("Balai", "telerin","Dei"),
            new ("Balain", "sindarin", "Dei"),
            new ("Balan", "sindarin", "Dio"),
            new ("Fara Aer", "quenya", "Caccia sacra"),
            new ("Nay", "quenya", "No")
        };

        private string _userInput;
        private readonly List<Word> _output = new List<Word>();

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Text))
            {
                _output.AddRange(_words);
            }
            else
            {
                _userInput = Text;
                _output.AddRange(Search());
            }
        }

        private void KeyPressHandler(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                _output.Clear();

                if (string.IsNullOrWhiteSpace(_userInput))
                {
                    _output.AddRange(_words);
                }
                else
                {
                    _output.AddRange(Search());
                }
            }
        }

        private IEnumerable<Word> Search()
        {
            foreach (var word in _words)
            {
                if (word.Contains(_userInput))
                {
                    yield return word;
                }
            }
        }

    }
}
