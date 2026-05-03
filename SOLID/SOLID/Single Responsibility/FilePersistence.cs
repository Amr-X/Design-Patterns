using System;

namespace SOLID.Single_Responsibility;

public class FilePersistence
{
    public void SaveAsTxt(Book book, string FileName, bool overwrite = false)
    {
        if (overwrite || !File.Exists(FileName))
            File.WriteAllText(FileName, book.ToString());
    }
    // Add here what you ever that deal with files
}
