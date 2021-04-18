using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _5_с_
{
    //class FileSerializer
    //{
    //    public TrieTree tree;

    //    public FileSerializer()
    //    {
    //        tree = new TrieTree();
    //    }

    //    public FileSerializer(TrieTree tree)
    //    {
    //        this.tree = tree;
    //    }

    //    public TrieTree GetTree()
    //    {
    //        return tree;
    //    }

    //    public void DeserializeText(string fileName)
    //    {
    //        using (StreamReader fs = new StreamReader(fileName))
    //        {
    //            DeserializeTextHelp(fs);
    //            fs.Close();
    //        }
    //    }


    //    public void DeserializeTextHelp(StreamReader fs)
    //    {
    //        try
    //        {
    //            string[] lines = fs.ReadLine().Split(' ');

    //            foreach (string line in lines)
    //            {
    //                tree.Insert(line.ToLower());
    //            }
    //        }
    //        catch
    //        {
    //            Console.WriteLine("Считать из файла не удалось!");
    //        }
    //    }


    //    public void SerializeText(string fileName)
    //    {
    //        using (StreamWriter fs = new StreamWriter(fileName))
    //        {
    //            fs.Write(tree.ToString());
    //            fs.Close();
    //        }
    //    }

    //}
}
