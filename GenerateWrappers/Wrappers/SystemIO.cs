

namespace WrapThat.SystemIO
{
    public interface ISystemIO
    {
        IDirectory Directory { get; }
        IFile File { get; }
    }

    public class SystemIO : ISystemIO
    {
        public IDirectory Directory { get; } =  new Directory();
        public IFile File { get;  } = new File();

    }
}
