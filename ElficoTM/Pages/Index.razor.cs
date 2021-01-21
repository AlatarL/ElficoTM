using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using static ElficoTM.Pages.Elven;

namespace ElficoTM.Pages
{
    public partial class Index
    {
        private string _headwordInput;
        private string _descriptionInput;
        private readonly List<Word> _output = new List<Word>();

        protected override void OnInitialized()
        {
            _output.AddRange(Words);
        }

        private void HeadwordKeyPressHandler(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                _output.Clear();
                _descriptionInput = string.Empty;

                if (string.IsNullOrWhiteSpace(_headwordInput))
                {
                    _output.AddRange(Words);
                }
                else
                {
                    foreach (var word in Words)
                    {
                        if (word.Contains(_headwordInput))
                        {
                            _output.Add(word);
                        }
                    }
                }
            }
        }

        private void DescriptionKeyPressHandler(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                _output.Clear();
                _headwordInput = string.Empty;

                if (string.IsNullOrWhiteSpace(_descriptionInput))
                {
                    _output.AddRange(Words);
                }
                else
                {
                    foreach (var word in Words)
                    {
                        if (word.Meaning.Contains(_descriptionInput, StringComparison.OrdinalIgnoreCase))
                        {
                            _output.Add(word);
                        }
                    }
                }
            }
        }

    }
}
