using System;

namespace DevFreela.Core.Exceptions
{
    public class ProjetctAlreadyStartedException : Exception
    {
        public ProjetctAlreadyStartedException() : base("Project is already in Started status")
        {
        }
    }
}