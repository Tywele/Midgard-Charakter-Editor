﻿using MidgardCharakterEditor.Database;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace MidgardCharakterEditor
{
    public class MainViewModel : ReactiveObject
    {
        [Reactive]
        public string Text { get; set; }
        
        public MainViewModel(IMidgardContext context)
        {
            Text = "Hello World";
        }
    }
}