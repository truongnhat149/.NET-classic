
namespace FileStream
{
    class FileStreamEx
    {
        static void Main(String[] args)
        {
            // sử dụng hàm tạo của lớp FileStream
            FileStream fs = new FileStream("data1.bin", FileMode.Create);
            // sử dụng các phương thức tĩnh của lớp File
            FileStream fs1 = File.OpenRead("data1.bin"); // Read-only
            FileStream fs2 = File.OpenWrite("data2.bin"); // Write-only
            FileStream fs3 = File.Create("data3.bin"); // Read/write

            // ======================================

            var fs = new FileStream("data1.bin", FileMode.OpenOrCreate, FileAccess.Read);
            var buffer = new byte[4];
            fs.Read(buffer, 0, 4);
            int i = BitConverter.ToInt32(buffer, 0);
            Console.WriteLine($"i = {i}");
            int length = (int)fs.Length - 4;
            buffer = new byte[length];
            fs.Read(buffer, 0, length);
            string str = Encoding.UTF8.GetString(buffer);
            fs.Close();
            Console.WriteLine($"str = {str}");

            // ======================================

            FileStream fs = new FileStream("data1.bin", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bWriter = new BinaryWriter(fs);
            bWriter.Write(1234);
            StreamWriter sWriter = new StreamWriter(fs);
            sWriter.Write("Hello world");
            sWriter.Flush();
            fs.Close();
            fs = new FileStream("data1.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(fs);
            var i = bReader.ReadInt32();
            StreamReader sReader = new StreamReader(fs);
            var str = sReader.ReadToEnd();
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"str = {str}");
            fs.Close();
        }

    }
        // ======================================
        using (FileStream fs = new FileStream("data1.bin", FileMode.Create, FileAccess.ReadWrite))
        {
            BinaryWriter bWriter = new BinaryWriter(fs);
            bWriter.Write(1234);
            StreamWriter sWriter = new StreamWriter(fs);
            sWriter.Write("Hello world");
            sWriter.Flush();
        }
        using (var fs = new FileStream("data1.bin", FileMode.OpenOrCreate, FileAccess.Read))
        {
            BinaryReader bReader = new BinaryReader(fs);
            var i = bReader.ReadInt32();
            StreamReader sReader = new StreamReader(fs);
            var str = sReader.ReadToEnd();
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"str = {str}");
        }
    

}