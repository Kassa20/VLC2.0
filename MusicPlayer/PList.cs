﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class PList
    {
        public PList(String[] files, ListBox playlist, ListBox songs)
        {

            try
            {
                string curItem = songs.SelectedItem.ToString();
                int index = songs.FindString(curItem);
                playlist.Items.Add(songs.Items[index]);
            }

            catch(Exception e)
            {
                MessageBox.Show("Playlist is Empty!");
            }


        }
        public void clearPlayList(ListBox playlist)
        {
            playlist.Items.Clear();
        }
    }
}
