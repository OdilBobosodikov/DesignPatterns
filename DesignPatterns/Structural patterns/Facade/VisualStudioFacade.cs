using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_patterns.Facade
{
    internal class VisualStudioFacade
    {
        private readonly Compiller compiller;
        private readonly TextEditor textEditor;
        private readonly CLR clr;

        public VisualStudioFacade(Compiller compiller, TextEditor textEditor, CLR clr)
        {
            this.compiller = compiller;
            this.textEditor = textEditor;
            this.clr = clr;
        }

        internal void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }

        internal void Stop()
        {
            clr.Finish();
        }
    }
}
