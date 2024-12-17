using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class GameGenerator
    {
        protected string GameIntro;

        public string GetGameIntro()
        {
            return GameIntro;
        }

        public abstract void RunCustomizationOptions();

        public abstract void WriteGameFile();
    }
}
