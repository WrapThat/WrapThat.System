

namespace WrapThat.SystemIO
{
    public interface ISystemIO
    {
        Directory Directory { get; }
        File File { get; }
    }

    public class SystemIO : ISystemIO
    {
        public Directory Directory { get; } =  new Directory();
        public File File { get;  } = new File();

    }
}
