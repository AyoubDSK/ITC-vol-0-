using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITC__vol_0_
{
    public static class Settingroot
    {
       static StreamWriter[] Writer;
       static StreamReader[] readers;
        public static void save(string host,string user,string port,string pass, string database)
        {
            Writer = new StreamWriter[5];
            Writer[0]=    new StreamWriter(@"hosting\Host.dat");
            Writer[1] = new StreamWriter(@"hosting\User.dat");
            Writer[2] = new StreamWriter(@"hosting\Port.dat");
            Writer[3] = new StreamWriter(@"hosting\Pass.dat");
            Writer[4] = new StreamWriter(@"hosting\Database.dat");

            Writer[0].Write(host);
            Writer[1].Write(user);
            Writer[2].Write(port);
            Writer[3].Write(pass);
            Writer[4].Write(database);

        }

        public static string[] Open()
        {
            string[] st = new string[5];
            readers = new StreamReader[5];
            readers[0] = new StreamReader(@"hosting\Host.dat");
            readers[1] = new StreamReader(@"hosting\User.dat");
            readers[2] = new StreamReader(@"hosting\Port.dat");
            readers[3] = new StreamReader(@"hosting\Pass.dat");
            readers[4] = new StreamReader(@"hosting\Database.dat");

            for( int i = 0; i < 5; i++)
            {
                st[i] = readers[i].ReadToEnd();
            }


            return st;
        }

    }
}
