using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.IO;
using System.Reflection;

namespace Music_Player
{
    class Song
    {

        private SoundPlayer m_song;
        private int[] notes;
        private string m_name;

        public Song()
        {
            notes = new int[4];
            notes[0] = 1;
            notes[1] = 1;
            notes[2] = 1;
            notes[3] = 1;
            m_song = new SoundPlayer();
            m_song.Stream = Properties.Resources.Silence;
            m_name = "Silence";
        }

        public Song(SoundPlayer song, string name, int note1, int note2, int note3, int note4, int note5, int note6, int note7, int note8)
        {
            m_song = song;
            m_name = name;
            notes = new int[8];
            notes[0] = note1;
            notes[1] = note2;
            notes[2] = note3;
            notes[3] = note4;
            notes[4] = note5;
            notes[5] = note6;
            notes[6] = note7;
            notes[7] = note8;
        }

        public Song(SoundPlayer song, string name, int note1, int note2, int note3, int note4, int note5, int note6, int note7)
        {
            m_song = song;
            m_name = name;
            notes = new int[7];
            notes[0] = note1;
            notes[1] = note2;
            notes[2] = note3;
            notes[3] = note4;
            notes[4] = note5;
            notes[5] = note6;
            notes[6] = note7;
        }

        public Song(SoundPlayer song, string name, int note1, int note2, int note3, int note4, int note5, int note6)
        {
            m_song = song;
            m_name = name;
            notes = new int[6];
            notes[0] = note1;
            notes[1] = note2;
            notes[2] = note3;
            notes[3] = note4;
            notes[4] = note5;
            notes[5] = note6;
        }

        public Song(SoundPlayer song, string name, int note1, int note2, int note3, int note4, int note5)
        {
            m_song = song;
            m_name = name;
            notes = new int[5];
            notes[0] = note1;
            notes[1] = note2;
            notes[2] = note3;
            notes[3] = note4;
            notes[4] = note5;
        }

        public Song(SoundPlayer song, string name, int note1, int note2, int note3, int note4)
        {
            m_song = song;
            m_name = name;
            notes = new int[4];
            notes[0] = note1;
            notes[1] = note2;
            notes[2] = note3;
            notes[3] = note4;
        }

        public Song(SoundPlayer song, string name, int note1, int note2, int note3)
        {
            m_song = song;
            m_name = name;
            notes = new int[3];
            notes[0] = note1;
            notes[1] = note2;
            notes[2] = note3;
        }

        public Song(SoundPlayer song, string name, int note1, int note2)
        {
            m_song = song;
            m_name = name;
            notes = new int[2];
            notes[0] = note1;
            notes[1] = note2;
        }

        public Song(SoundPlayer song, string name, int note1)
        {
            m_song = song;
            m_name = name;
            notes = new int[1];
            notes[0] = note1;
        }

        // Notes Values:
        // D2   = 1;
        // C    = 2;
        // B    = 3;
        // A    = 4;
        // G    = 5;
        // F    = 6;
        // E    = 7;
        // D    = 8;
        //

        public bool CompareSong(Song target)
        {
            if (target.GetLastNote() == GetLastNote())
            {
                if (target.GetSecondNote() == GetSecondNote())
                {
                    if (target.GetNumberNotes() == 2)
                    {
                        return true;
                    }
                    else if (target.GetThirdNote() == GetThirdNote())
                    {
                        if (target.GetNumberNotes() == 3)
                        {
                            return true;
                        }
                        else if (target.GetFourthNote() == GetFourthNote())
                        {
                            if (target.GetNumberNotes() == 4)
                            {
                                return true;
                            }
                            else if (target.GetFifthNote() == GetFifthNote())
                            {
                                if (target.GetNumberNotes() == 5)
                                {
                                    return true;
                                }
                                else if (target.GetSixthNote() == GetSixthNote())
                                {
                                    if (target.GetNumberNotes() == 6)
                                    {
                                        return true;
                                    }
                                    else if (target.GetSeventhNote() == GetSeventhNote())
                                    {
                                        if (target.GetNumberNotes() == 7)
                                        {
                                            return true;
                                        }
                                        else if (target.GetEighthNote() == GetEighthNote())
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return false;
            
        }

        public int GetLastNote()
        {
            if (notes.Length > 0)
            {
                return notes[notes.Length - 1];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetSecondNote()
        {
            if (notes.Length > 1)
            {
                return notes[notes.Length - 2];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetThirdNote()
        {
            if (notes.Length > 2)
            {
                return notes[notes.Length - 3];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetFourthNote()
        {
            if (notes.Length > 3)
            {
                return notes[notes.Length - 4];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetFifthNote()
        {
            if (notes.Length > 4)
            {
                return notes[notes.Length - 5];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetSixthNote()
        {
            if (notes.Length > 5)
            {
                return notes[notes.Length - 6];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetSeventhNote()
        {
            if (notes.Length > 6)
            {
                return notes[notes.Length - 7];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetEighthNote()
        {
            if (notes.Length > 7)
            {
                return notes[notes.Length - 8];
            }
            else
            {
                return notes[notes.Length - 1];
            }
        }

        private int GetNumberNotes()
        {
            return notes.Length;
        }

        public void PlaySong()
        {
            m_song.Play();
        }

        public string GetName()
        {
            return m_name;
        }

        public void AddNote(int i)
        {
            int[] ig = new int[1000];
            for(int ind = 0; ind < notes.Length; ind++)
                ig[ind] = notes[ind];
          
            notes = new int[notes.Length + 1];
            for (int ind = 0; ind < notes.Length - 1; ind++)
                notes[ind] = ig[ind];
            notes[notes.Length - 1] = i;
        }


    }

    

}
