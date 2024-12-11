namespace Riode.Helpers.Extensions
{
    public static class FileExtension
    {
        public static string Upload(this IFormFile file,string rootpath,string foldername)
        {
            string filename= file.FileName;
            if (filename.Length > 64)
            {
                filename= filename.Substring(filename.Length-64);
            }
            filename = Guid.NewGuid()+filename;
            string path = Path.Combine(rootpath, foldername,filename);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fs);
            }
            return filename;
        }

        public static bool DeleteFile(string rootPath, string folderName, string filename)
        {
            string path = Path.Combine(rootPath, folderName, filename);
            if (!File.Exists(path))
            {
                return false;
            }
            File.Delete(path);
            return true;
        }
    }
}
