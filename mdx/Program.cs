﻿using System;
using System.Diagnostics;
using HzNS.Cmdr;
using HzNS.MdxLib.MDict;

namespace mdx
{
    /// <summary>
    ///
    /// ll
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Entry.From(args);
            
            Console.WriteLine("Hello World!");

            foreach (var filename in args)
            {
                using var l = new MDictLoader(filename);
                try
                {
                    l.Process();
                    Console.WriteLine($"header: {l.DictHeader}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    // throw;
                }
                finally
                {
                    // l.Dispose();
                }
            }

            // HzNS.MdxLib.open("*.mdx,mdd,sdx,wav,png,...") => mdxfile
            // mdxfile.preload()
            // mdxfile.getEntry("beta") => entryInfo.{item,index}
            // mdxfile.find("a")           // "a", "a*b", "*b"
            // mdxfile.close()
            // mdxfile.find()
            // mdxfile.find()
            // mdxfile.find()
        }
    }
}