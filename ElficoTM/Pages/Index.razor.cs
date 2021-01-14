using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using static ElficoTM.Pages.Elven;

namespace ElficoTM.Pages
{
    public partial class Index
    {
        [Parameter]
        public string Text { get; set; }

        private string _userInput;
        private readonly List<Word> _output = new List<Word>();

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Text))
            {
                _output.AddRange(Words);
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
                    _output.AddRange(Words);
                }
                else
                {
                    _output.AddRange(Search());
                }
            }
        }

        private IEnumerable<Word> Search()
        {
            foreach (var word in Words)
            {
                if (word.Contains(_userInput))
                {
                    yield return word;
                }
            }
        }

    }
}
