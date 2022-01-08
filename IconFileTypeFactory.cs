using PaintDotNet;

namespace IconCreatorFileType
{
    public sealed class IcoFileTypeFactory : IFileTypeFactory {
        public FileType[] GetFileTypeInstances() {
            return new FileType[] { new IconFileType() };
        }
    }
}
