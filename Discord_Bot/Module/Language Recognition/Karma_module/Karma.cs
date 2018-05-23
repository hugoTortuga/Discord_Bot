using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Module.Language_Recognition.Karma_module
{
    public class Karma
    {
        public int GetKarma(SocketUser user)
        {
            string textFile = System.IO.File.ReadAllText("Karma/karma.txt");

            string[] usersData = textFile.Split(';');
            List<string> list_userData = new List<string>();

            Dictionary<ulong, int> map = new Dictionary<ulong, int>();

            foreach(string userData in usersData)
            {
                string[] temp = userData.Split('|');
                foreach(string tempWord in temp)
                {
                    list_userData.Add(tempWord);
                }
            }

            ulong id_user = 0;
            int karma = 0;
            for(int i = 0; i < list_userData.Count; i++)
            {
                if(i % 2 != 0)
                {
                    id_user = ulong.Parse(list_userData[i]);
                    //reset karma
                }
                else
                {
                    karma = int.Parse(list_userData[i]);

                    map.Add(id_user, karma);
                }
            }

            foreach (KeyValuePair<ulong, int> tempUser in map)
            {
                if (tempUser.Key == user.Id)
                {
                    return tempUser.Value;
                }
            }

            return -1;
        }
    }
}
