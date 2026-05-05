
namespace paint
{
    public static class FileValidator
    {
        public static bool IsImageFile(string filePath)
        {
            string ext = System.IO.Path.GetExtension(filePath).ToLower();
            string[] allowedExt = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return allowedExt.Contains(ext);
        }
    }
}
