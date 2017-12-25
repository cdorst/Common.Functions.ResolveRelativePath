using System.IO;

namespace Common.Functions.ResolveRelativePath
{
    public static class RelativePathResolver
    {
        public static string GetPath(string pathRelativeToCurrent)
            => Path.Combine(Directory.GetCurrentDirectory(), pathRelativeToCurrent);
    }
}
