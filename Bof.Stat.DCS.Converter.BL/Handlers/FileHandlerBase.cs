using Bof.Stat.DCS.Converter.Model;

namespace Bof.Stat.DCS.Converter.BL
{
    public abstract class FileHandlerBase
    {
        protected abstract void Handle(string filename);

        public abstract FileBase File { get; }
    }
}
