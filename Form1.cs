using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Collections;
using System.IO;
using System.Reflection;
using WiimoteLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {


        private int D2 = 1;
        // int C    = 2;
        private int B = 3;
        private int A = 4;
        // int G    = 5;
        private int F = 6;
        // int E    = 7;
        private int D = 8;
        SoundPlayer silence;
        SoundPlayer[] noteA_Short;
        SoundPlayer[] noteA_Med;
        SoundPlayer[] noteA_Long;
        SoundPlayer[] noteA_Loop;
        SoundPlayer noteA_Frog;

        SoundPlayer[] noteB_Short;
        SoundPlayer[] noteB_Med;
        SoundPlayer[] noteB_Long;
        SoundPlayer[] noteB_Loop;
        SoundPlayer noteB_Frog;

        SoundPlayer[] noteD_Short;
        SoundPlayer[] noteD_Med;
        SoundPlayer[] noteD_Long;
        SoundPlayer[] noteD_Loop;
        SoundPlayer noteD_Frog;

        SoundPlayer[] noteD2_Short;
        SoundPlayer[] noteD2_Med;
        SoundPlayer[] noteD2_Long;
        SoundPlayer[] noteD2_Loop;
        SoundPlayer noteD2_Frog;

        SoundPlayer[] noteF_Short;
        SoundPlayer[] noteF_Med;
        SoundPlayer[] noteF_Long;
        SoundPlayer[] noteF_Loop;
        SoundPlayer noteF_Frog;

        SoundPlayer secret;
        About aboutDialogue;
        SongForm songForm;

        Song s_time;
        Song s_saria;
        Song s_epona;
        Song s_storm;
        Song s_zelda;
        Song s_sun;
        Song s_light;
        Song s_forest;
        Song s_fire;
        Song s_water;
        Song s_shadow;
        Song s_spirit;
        Song s_heal;
        Song s_soar;
        Song s_time2x;
        Song s_half;
        Song s_awake;
        Song s_goron;
        Song s_wave;
        Song s_empty;
        Song s_order;

        Song sp = new Song();
        Song emp = new Song();

        SoundPlayer time;
        SoundPlayer saria;
        SoundPlayer epona;
        SoundPlayer storm;
        SoundPlayer zelda;
        SoundPlayer sun;
        SoundPlayer light;
        SoundPlayer forest;
        SoundPlayer water;
        SoundPlayer fire;
        SoundPlayer shadow;
        SoundPlayer spirit;
        SoundPlayer heal;
        SoundPlayer soar;
        SoundPlayer time2x;
        SoundPlayer half;
        SoundPlayer awake;
        SoundPlayer goron;
        SoundPlayer wave;
        SoundPlayer empty;
        SoundPlayer order;

        ArrayList noteList = new ArrayList();
        int nunchuk_X;
        int nunchuk_Y;

        public static Wiimote p1 = new Wiimote();
        WiimoteState nunchuk = new WiimoteState();

        public Form1()
        {
            InitializeComponent();
            addNotes();
            addSongs();
            AddAudioStream();
            WiimoteInit();
            Application.Idle += idleProcesses;
        }

        private void WiimoteInit()
        {
            p1.Connect();
            p1.SetLEDs(true, false, false, false);
        }

        private int CheckSong(int i)
        {
            
            if (sp.CompareSong(s_time))
            {
                return 1;
            }
            else if (sp.CompareSong(s_saria))
            {
                return 2;
            }
            else if (sp.CompareSong(s_epona))
            {
                return 3;
            }
            else if (sp.CompareSong(s_storm))
            {
                return 4;
            }
            else if (sp.CompareSong(s_zelda))
            {
                return 5;
            }
            else if (sp.CompareSong(s_sun))
            {
                return 6;
            }
            else if (sp.CompareSong(s_light))
            {
                return 7;
            }
            else if (sp.CompareSong(s_forest))
            {
                return 8;
            }
            else if (sp.CompareSong(s_fire))
            {
                return 9;
            }
            else if (sp.CompareSong(s_water))
            {
                return 10;
            }
            else if (sp.CompareSong(s_shadow))
            {
                return 11;
            }
            else if (sp.CompareSong(s_spirit))
            {
                return 12;
            }
            else if (sp.CompareSong(s_heal))
            {
                return 13;
            }
            else if (sp.CompareSong(s_soar))
            {
                return 14;
            }
            else if (sp.CompareSong(s_time2x))
            {
                return 15;
            }
            else if (sp.CompareSong(s_half))
            {
                return 16;
            }
            else if (sp.CompareSong(s_awake))
            {
                return 17;
            }
            else if (sp.CompareSong(s_goron))
            {
                return 18;
            }
            else if (sp.CompareSong(s_wave))
            {
                return 19;
            }
            else if (sp.CompareSong(s_empty))
            {
                return 20;
            }
            else if (sp.CompareSong(s_order))
            {
                return 21;
            }
            else
                return 0;
        }

        private void PlaySong()
        {
            if (sp.CompareSong(s_time))
            {
                s_time.PlaySong();
            }
            else if (sp.CompareSong(s_saria))
            {
                s_saria.PlaySong();
            }
            else if (sp.CompareSong(s_epona))
            {
                s_epona.PlaySong();
            }
            else if (sp.CompareSong(s_storm))
            {
                s_storm.PlaySong();
            }
            else if (sp.CompareSong(s_zelda))
            {
                s_zelda.PlaySong();
            }
            else if (sp.CompareSong(s_sun))
            {
                s_sun.PlaySong();
            }
            else if (sp.CompareSong(s_light))
            {
                s_light.PlaySong();
            }
            else if (sp.CompareSong(s_forest))
            {
                s_forest.PlaySong();
            }
            else if (sp.CompareSong(s_fire))
            {
                s_fire.PlaySong();
            }
            else if (sp.CompareSong(s_water))
            {
                s_water.PlaySong();
            }
            else if (sp.CompareSong(s_shadow))
            {
                s_shadow.PlaySong();
            }
            else if (sp.CompareSong(s_spirit))
            {
                s_spirit.PlaySong();
            }
            else if (sp.CompareSong(s_heal))
            {
                s_heal.PlaySong();
            }
            else if (sp.CompareSong(s_soar))
            {
                s_soar.PlaySong();
            }
            else if (sp.CompareSong(s_time2x))
            {
                s_time2x.PlaySong();
            }
            else if (sp.CompareSong(s_half))
            {
                s_half.PlaySong();
            }
            else if (sp.CompareSong(s_awake))
            {
                s_awake.PlaySong();
            }
            else if (sp.CompareSong(s_goron))
            {
                s_goron.PlaySong();
            }
            else if (sp.CompareSong(s_wave))
            {
                s_wave.PlaySong();
            }
            else if (sp.CompareSong(s_empty))
            {
                s_empty.PlaySong();
            }
            else if (sp.CompareSong(s_order))
            {
                s_order.PlaySong();
            }

        }

        private string CheckSong()
        {
            if (sp.CompareSong(s_time))
            {
                return s_time.GetName();
            }
            else if (sp.CompareSong(s_saria))
            {
                return s_saria.GetName();
            }
            else if (sp.CompareSong(s_epona))
            {
                return s_epona.GetName();
            }
            else if (sp.CompareSong(s_storm))
            {
                return s_storm.GetName();
            }
            else if (sp.CompareSong(s_zelda))
            {
                return s_zelda.GetName();
            }
            else if (sp.CompareSong(s_sun))
            {
                return s_sun.GetName();
            }
            else if (sp.CompareSong(s_light))
            {
                return s_light.GetName();
            }
            else if (sp.CompareSong(s_forest))
            {
                return s_forest.GetName();
            }
            else if (sp.CompareSong(s_fire))
            {
                return s_fire.GetName();
            }
            else if (sp.CompareSong(s_water))
            {
                return s_water.GetName();
            }
            else if (sp.CompareSong(s_shadow))
            {
                return s_shadow.GetName();
            }
            else if (sp.CompareSong(s_spirit))
            {
                return s_spirit.GetName();
            }
            else if (sp.CompareSong(s_heal))
            {
                return s_heal.GetName();
            }
            else if (sp.CompareSong(s_soar))
            {
                return s_soar.GetName();
            }
            else if (sp.CompareSong(s_time2x))
            {
                return s_time2x.GetName();
            }
            else if (sp.CompareSong(s_half))
            {
                return s_half.GetName();
            }
            else if (sp.CompareSong(s_awake))
            {
                return s_awake.GetName();
            }
            else if (sp.CompareSong(s_goron))
            {
                return s_goron.GetName();
            }
            else if (sp.CompareSong(s_wave))
            {
                return s_wave.GetName();
            }
            else if (sp.CompareSong(s_empty))
            {
                return s_empty.GetName();
            }
            else if (sp.CompareSong(s_order))
            {
                return s_order.GetName();
            }
            else
                return sp.GetName();
        }

        private int CheckNote()
        {
            if (sp.CompareSong(s_time))
            {
                return s_time.GetLastNote();
            }
            else if (sp.CompareSong(s_saria))
            {
                return s_saria.GetLastNote();
            }
            else if (sp.CompareSong(s_epona))
            {
                return s_epona.GetLastNote();
            }
            else if (sp.CompareSong(s_storm))
            {
                return s_storm.GetLastNote();
            }
            else if (sp.CompareSong(s_zelda))
            {
                return s_zelda.GetLastNote();
            }
            else if (sp.CompareSong(s_sun))
            {
                return s_sun.GetLastNote();
            }
            else if (sp.CompareSong(s_light))
            {
                return s_light.GetLastNote();
            }
            else if (sp.CompareSong(s_forest))
            {
                return s_forest.GetLastNote();
            }
            else if (sp.CompareSong(s_fire))
            {
                return s_fire.GetLastNote();
            }
            else if (sp.CompareSong(s_water))
            {
                return s_water.GetLastNote();
            }
            else if (sp.CompareSong(s_shadow))
            {
                return s_shadow.GetLastNote();
            }
            else if (sp.CompareSong(s_spirit))
            {
                return s_spirit.GetLastNote();
            }
            else if (sp.CompareSong(s_heal))
            {
                return s_heal.GetLastNote();
            }
            else if (sp.CompareSong(s_soar))
            {
                return s_soar.GetLastNote();
            }
            else if (sp.CompareSong(s_time2x))
            {
                return s_time2x.GetLastNote();
            }
            else if (sp.CompareSong(s_half))
            {
                return s_half.GetLastNote();
            }
            else if (sp.CompareSong(s_awake))
            {
                return s_awake.GetLastNote();
            }
            else if (sp.CompareSong(s_goron))
            {
                return s_goron.GetLastNote();
            }
            else if (sp.CompareSong(s_wave))
            {
                return s_water.GetLastNote();
            }
            else if (sp.CompareSong(s_empty))
            {
                return s_empty.GetLastNote();
            }
            else if (sp.CompareSong(s_order))
            {
                return s_order.GetLastNote();
            }
            else
                return sp.GetLastNote();
        }
        
        private void ShowSongForm(string s)
        {
            songForm = new SongForm(s);songForm.Show();
        }

        private void addNotes()
        {
            time = new SoundPlayer();
            saria = new SoundPlayer();
            epona = new SoundPlayer();
            storm = new SoundPlayer();
            zelda = new SoundPlayer();
            sun = new SoundPlayer();
            light = new SoundPlayer();
            forest = new SoundPlayer();
            water = new SoundPlayer();
            fire = new SoundPlayer();
            shadow = new SoundPlayer();
            spirit = new SoundPlayer();
            heal = new SoundPlayer();
            soar = new SoundPlayer();
            time2x = new SoundPlayer();
            half = new SoundPlayer();
            awake = new SoundPlayer();
            goron = new SoundPlayer();
            wave = new SoundPlayer();
            empty = new SoundPlayer();
            order = new SoundPlayer();

            silence = new SoundPlayer();
            silence.Stream = Properties.Resources.Silence;
            secret = new SoundPlayer();
            secret.Stream = Properties.Resources.ZSS_Secret;


            noteA_Short = new SoundPlayer[8];
            // Shorts
            noteA_Short[0] = new SoundPlayer();
            noteA_Short[1] = new SoundPlayer();
            noteA_Short[2] = new SoundPlayer();
            noteA_Short[3] = new SoundPlayer();
            noteA_Short[4] = new SoundPlayer();
            noteA_Short[5] = new SoundPlayer();
            noteA_Short[6] = new SoundPlayer();
            noteA_Short[7] = new SoundPlayer();


            noteB_Short = new SoundPlayer[8];
            noteB_Short[0] = new SoundPlayer();
            noteB_Short[1] = new SoundPlayer();
            noteB_Short[2] = new SoundPlayer();
            noteB_Short[3] = new SoundPlayer();
            noteB_Short[4] = new SoundPlayer();
            noteB_Short[5] = new SoundPlayer();
            noteB_Short[6] = new SoundPlayer();
            noteB_Short[7] = new SoundPlayer();

            noteD_Short = new SoundPlayer[8];
            noteD_Short[0] = new SoundPlayer();
            noteD_Short[1] = new SoundPlayer();
            noteD_Short[2] = new SoundPlayer();
            noteD_Short[3] = new SoundPlayer();
            noteD_Short[4] = new SoundPlayer();
            noteD_Short[5] = new SoundPlayer();
            noteD_Short[6] = new SoundPlayer();
            noteD_Short[7] = new SoundPlayer();

            noteD2_Short = new SoundPlayer[8];
            noteD2_Short[0] = new SoundPlayer();
            noteD2_Short[1] = new SoundPlayer();
            noteD2_Short[2] = new SoundPlayer();
            noteD2_Short[3] = new SoundPlayer();
            noteD2_Short[4] = new SoundPlayer();
            noteD2_Short[5] = new SoundPlayer();
            noteD2_Short[6] = new SoundPlayer();
            noteD2_Short[7] = new SoundPlayer();

            noteF_Short = new SoundPlayer[8];
            noteF_Short[0] = new SoundPlayer();
            noteF_Short[1] = new SoundPlayer();
            noteF_Short[2] = new SoundPlayer();
            noteF_Short[3] = new SoundPlayer();
            noteF_Short[4] = new SoundPlayer();
            noteF_Short[5] = new SoundPlayer();
            noteF_Short[6] = new SoundPlayer();
            noteF_Short[7] = new SoundPlayer();

            noteA_Med = new SoundPlayer[7];
            // Meds
            noteA_Med[0] = new SoundPlayer();
            noteA_Med[1] = new SoundPlayer();
            noteA_Med[2] = new SoundPlayer();
            noteA_Med[3] = new SoundPlayer();
            noteA_Med[4] = new SoundPlayer();
            noteA_Med[5] = new SoundPlayer();
            noteA_Med[6] = new SoundPlayer();

            noteB_Med = new SoundPlayer[7];
            noteB_Med[0] = new SoundPlayer();
            noteB_Med[1] = new SoundPlayer();
            noteB_Med[2] = new SoundPlayer();
            noteB_Med[3] = new SoundPlayer();
            noteB_Med[4] = new SoundPlayer();
            noteB_Med[5] = new SoundPlayer();
            noteB_Med[6] = new SoundPlayer();

            noteD_Med = new SoundPlayer[7];
            noteD_Med[0] = new SoundPlayer();
            noteD_Med[1] = new SoundPlayer();
            noteD_Med[2] = new SoundPlayer();
            noteD_Med[3] = new SoundPlayer();
            noteD_Med[4] = new SoundPlayer();
            noteD_Med[5] = new SoundPlayer();
            noteD_Med[6] = new SoundPlayer();

            noteD2_Med = new SoundPlayer[7];
            noteD2_Med[0] = new SoundPlayer();
            noteD2_Med[1] = new SoundPlayer();
            noteD2_Med[2] = new SoundPlayer();
            noteD2_Med[3] = new SoundPlayer();
            noteD2_Med[4] = new SoundPlayer();
            noteD2_Med[5] = new SoundPlayer();
            noteD2_Med[6] = new SoundPlayer();

            noteF_Med = new SoundPlayer[7];
            noteF_Med[0] = new SoundPlayer();
            noteF_Med[1] = new SoundPlayer();
            noteF_Med[2] = new SoundPlayer();
            noteF_Med[3] = new SoundPlayer();
            noteF_Med[4] = new SoundPlayer();
            noteF_Med[5] = new SoundPlayer();
            noteF_Med[6] = new SoundPlayer();

            // LONGS
            noteA_Long = new SoundPlayer[9];
            noteA_Long[0] = new SoundPlayer();
            noteA_Long[1] = new SoundPlayer();
            noteA_Long[2] = new SoundPlayer();
            noteA_Long[3] = new SoundPlayer();
            noteA_Long[4] = new SoundPlayer();
            noteA_Long[5] = new SoundPlayer();
            noteA_Long[6] = new SoundPlayer();
            noteA_Long[7] = new SoundPlayer();
            noteA_Long[8] = new SoundPlayer();

            noteB_Long = new SoundPlayer[9];
            noteB_Long[0] = new SoundPlayer();
            noteB_Long[1] = new SoundPlayer();
            noteB_Long[2] = new SoundPlayer();
            noteB_Long[3] = new SoundPlayer();
            noteB_Long[4] = new SoundPlayer();
            noteB_Long[5] = new SoundPlayer();
            noteB_Long[6] = new SoundPlayer();
            noteB_Long[7] = new SoundPlayer();
            noteB_Long[8] = new SoundPlayer();

            noteD_Long = new SoundPlayer[9];
            noteD_Long[0] = new SoundPlayer();
            noteD_Long[1] = new SoundPlayer();
            noteD_Long[2] = new SoundPlayer();
            noteD_Long[3] = new SoundPlayer();
            noteD_Long[4] = new SoundPlayer();
            noteD_Long[5] = new SoundPlayer();
            noteD_Long[6] = new SoundPlayer();
            noteD_Long[7] = new SoundPlayer();
            noteD_Long[8] = new SoundPlayer();

            noteD2_Long = new SoundPlayer[9];
            noteD2_Long[0] = new SoundPlayer();
            noteD2_Long[1] = new SoundPlayer();
            noteD2_Long[2] = new SoundPlayer();
            noteD2_Long[3] = new SoundPlayer();
            noteD2_Long[4] = new SoundPlayer();
            noteD2_Long[5] = new SoundPlayer();
            noteD2_Long[6] = new SoundPlayer();
            noteD2_Long[7] = new SoundPlayer();
            noteD2_Long[8] = new SoundPlayer();

            noteF_Long = new SoundPlayer[9];
            noteF_Long[0] = new SoundPlayer();
            noteF_Long[1] = new SoundPlayer();
            noteF_Long[2] = new SoundPlayer();
            noteF_Long[3] = new SoundPlayer();
            noteF_Long[4] = new SoundPlayer();
            noteF_Long[5] = new SoundPlayer();
            noteF_Long[6] = new SoundPlayer();
            noteF_Long[7] = new SoundPlayer();
            noteF_Long[8] = new SoundPlayer();

            //Loops

            noteA_Loop = new SoundPlayer[5];
            noteA_Loop[0] = new SoundPlayer();
            noteA_Loop[1] = new SoundPlayer();
            noteA_Loop[2] = new SoundPlayer();
            noteA_Loop[3] = new SoundPlayer();
            noteA_Loop[4] = new SoundPlayer();
            
            noteB_Loop = new SoundPlayer[5];
            noteB_Loop[0] = new SoundPlayer();
            noteB_Loop[1] = new SoundPlayer();
            noteB_Loop[2] = new SoundPlayer();
            noteB_Loop[3] = new SoundPlayer();
            noteB_Loop[4] = new SoundPlayer();
            
            noteD_Loop = new SoundPlayer[5];
            noteD_Loop[0] = new SoundPlayer();
            noteD_Loop[1] = new SoundPlayer();
            noteD_Loop[2] = new SoundPlayer();
            noteD_Loop[3] = new SoundPlayer();
            noteD_Loop[4] = new SoundPlayer();
            
            noteD2_Loop = new SoundPlayer[5];
            noteD2_Loop[0] = new SoundPlayer();
            noteD2_Loop[1] = new SoundPlayer();
            noteD2_Loop[2] = new SoundPlayer();
            noteD2_Loop[3] = new SoundPlayer();
            noteD2_Loop[4] = new SoundPlayer();
            
            noteF_Loop = new SoundPlayer[5];
            noteF_Loop[0] = new SoundPlayer();
            noteF_Loop[1] = new SoundPlayer();
            noteF_Loop[2] = new SoundPlayer();
            noteF_Loop[3] = new SoundPlayer();
            noteF_Loop[4] = new SoundPlayer();

            //Frogs
            noteA_Frog = new SoundPlayer();
            noteA_Frog.Stream = Properties.Resources.Frog_A;
            noteB_Frog = new SoundPlayer();
            noteB_Frog.Stream = Properties.Resources.Frog_B;
            noteD_Frog = new SoundPlayer();
            noteD_Frog.Stream = Properties.Resources.Frog_D;
            noteD2_Frog = new SoundPlayer();
            noteD2_Frog.Stream = Properties.Resources.Frog_D2;
            noteF_Frog = new SoundPlayer();
            noteF_Frog.Stream = Properties.Resources.Frog_F;
        }

        public void AddAudioStream()
        {
            noteA_Long[0].Stream = Properties.Resources.LG_D_A;
            noteA_Long[1].Stream = Properties.Resources.LG_F_A;
            noteA_Long[2].Stream = Properties.Resources.LG_G_A;
            noteA_Long[3].Stream = Properties.Resources.LG_H_A;
            noteA_Long[4].Stream = Properties.Resources.LG_M_A;
            noteA_Long[5].Stream = Properties.Resources.LG_O_A;
            noteA_Long[6].Stream = Properties.Resources.LG_P_A;
            noteA_Long[7].Stream = Properties.Resources.LG_V_A;
            noteA_Long[8].Stream = Properties.Resources.LG_W_A;

            noteB_Long[0].Stream = Properties.Resources.LG_D_B;
            noteB_Long[1].Stream = Properties.Resources.LG_F_B;
            noteB_Long[2].Stream = Properties.Resources.LG_G_B;
            noteB_Long[3].Stream = Properties.Resources.LG_H_B;
            noteB_Long[4].Stream = Properties.Resources.LG_M_B;
            noteB_Long[5].Stream = Properties.Resources.LG_O_B;
            noteB_Long[6].Stream = Properties.Resources.LG_P_B;
            noteB_Long[7].Stream = Properties.Resources.LG_V_B;
            noteB_Long[8].Stream = Properties.Resources.LG_W_B;

            noteD_Long[0].Stream = Properties.Resources.LG_D_D;
            noteD_Long[1].Stream = Properties.Resources.LG_F_D;
            noteD_Long[2].Stream = Properties.Resources.LG_G_D;
            noteD_Long[3].Stream = Properties.Resources.LG_H_D;
            noteD_Long[4].Stream = Properties.Resources.LG_M_D;
            noteD_Long[5].Stream = Properties.Resources.LG_O_D;
            noteD_Long[6].Stream = Properties.Resources.LG_P_D;
            noteD_Long[7].Stream = Properties.Resources.LG_V_D;
            noteD_Long[8].Stream = Properties.Resources.LG_W_D;

            noteD2_Long[0].Stream = Properties.Resources.LG_D_D2;
            noteD2_Long[1].Stream = Properties.Resources.LG_F_D2;
            noteD2_Long[2].Stream = Properties.Resources.LG_G_D2;
            noteD2_Long[3].Stream = Properties.Resources.LG_H_D2;
            noteD2_Long[4].Stream = Properties.Resources.LG_M_D2;
            noteD2_Long[5].Stream = Properties.Resources.LG_O_D2;
            noteD2_Long[6].Stream = Properties.Resources.LG_P_D2;
            noteD2_Long[7].Stream = Properties.Resources.LG_V_D2;
            noteD2_Long[8].Stream = Properties.Resources.LG_W_D2;

            noteF_Long[0].Stream = Properties.Resources.LG_D_F;
            noteF_Long[1].Stream = Properties.Resources.LG_F_F;
            noteF_Long[2].Stream = Properties.Resources.LG_G_F;
            noteF_Long[3].Stream = Properties.Resources.LG_H_F;
            noteF_Long[4].Stream = Properties.Resources.LG_M_F;
            noteF_Long[5].Stream = Properties.Resources.LG_O_F;
            noteF_Long[6].Stream = Properties.Resources.LG_P_F;
            noteF_Long[7].Stream = Properties.Resources.LG_V_F;
            noteF_Long[8].Stream = Properties.Resources.LG_W_F;


            noteA_Loop[0].Stream = Properties.Resources.LP_F_A;
            noteA_Loop[1].Stream = Properties.Resources.LP_M_A;
            noteA_Loop[2].Stream = Properties.Resources.LP_O_A;
            noteA_Loop[3].Stream = Properties.Resources.LP_V_A;
            noteA_Loop[4].Stream = Properties.Resources.LP_W_A;

            noteB_Loop[0].Stream = Properties.Resources.LP_F_B;
            noteB_Loop[1].Stream = Properties.Resources.LP_M_B;
            noteB_Loop[2].Stream = Properties.Resources.LP_O_B;
            noteB_Loop[3].Stream = Properties.Resources.LP_V_B;
            noteB_Loop[4].Stream = Properties.Resources.LP_W_B;

            noteD_Loop[0].Stream = Properties.Resources.LP_F_D;
            noteD_Loop[1].Stream = Properties.Resources.LP_M_D;
            noteD_Loop[2].Stream = Properties.Resources.LP_O_D;
            noteD_Loop[3].Stream = Properties.Resources.LP_V_D;
            noteD_Loop[4].Stream = Properties.Resources.LP_W_D;

            noteD2_Loop[0].Stream = Properties.Resources.LP_F_D2;
            noteD2_Loop[1].Stream = Properties.Resources.LP_M_D2;
            noteD2_Loop[2].Stream = Properties.Resources.LP_O_D2;
            noteD2_Loop[3].Stream = Properties.Resources.LP_V_D2;
            noteD2_Loop[4].Stream = Properties.Resources.LP_W_D2;

            noteF_Loop[0].Stream = Properties.Resources.LP_F_F;
            noteF_Loop[1].Stream = Properties.Resources.LP_M_F;
            noteF_Loop[2].Stream = Properties.Resources.LP_O_F;
            noteF_Loop[3].Stream = Properties.Resources.LP_V_F;
            noteF_Loop[4].Stream = Properties.Resources.LP_W_F;

            noteA_Med[0].Stream = Properties.Resources.M_F_A; // 7
            noteA_Med[1].Stream = Properties.Resources.M_G_A;
            noteA_Med[2].Stream = Properties.Resources.M_W_A;
            noteA_Med[3].Stream = Properties.Resources.M_M_A;
            noteA_Med[4].Stream = Properties.Resources.M_O_A;
            noteA_Med[5].Stream = Properties.Resources.M_P_A;
            noteA_Med[6].Stream = Properties.Resources.M_V_A;

            noteB_Med[0].Stream = Properties.Resources.M_F_B; // 7
            noteB_Med[1].Stream = Properties.Resources.M_G_B;
            noteB_Med[2].Stream = Properties.Resources.M_W_B;
            noteB_Med[3].Stream = Properties.Resources.M_M_B;
            noteB_Med[4].Stream = Properties.Resources.M_O_B;
            noteB_Med[5].Stream = Properties.Resources.M_P_B;
            noteB_Med[6].Stream = Properties.Resources.M_V_B;

            noteD_Med[0].Stream = Properties.Resources.M_F_D; // 7
            noteD_Med[1].Stream = Properties.Resources.M_G_D;
            noteD_Med[2].Stream = Properties.Resources.M_W_D;
            noteD_Med[3].Stream = Properties.Resources.M_M_D;
            noteD_Med[4].Stream = Properties.Resources.M_O_D;
            noteD_Med[5].Stream = Properties.Resources.M_P_D;
            noteD_Med[6].Stream = Properties.Resources.M_V_D;

            noteD2_Med[0].Stream = Properties.Resources.M_F_D2; // 7
            noteD2_Med[1].Stream = Properties.Resources.M_G_D2;
            noteD2_Med[2].Stream = Properties.Resources.M_W_D2;
            noteD2_Med[3].Stream = Properties.Resources.M_M_D2;
            noteD2_Med[4].Stream = Properties.Resources.M_O_D2;
            noteD2_Med[5].Stream = Properties.Resources.M_P_D2;
            noteD2_Med[6].Stream = Properties.Resources.M_V_D2;

            noteF_Med[0].Stream = Properties.Resources.M_F_F; // 7
            noteF_Med[1].Stream = Properties.Resources.M_G_F;
            noteF_Med[2].Stream = Properties.Resources.M_W_F;
            noteF_Med[3].Stream = Properties.Resources.M_M_F;
            noteF_Med[4].Stream = Properties.Resources.M_O_F;
            noteF_Med[5].Stream = Properties.Resources.M_P_F;
            noteF_Med[6].Stream = Properties.Resources.M_V_F;

            noteA_Short[0].Stream = Properties.Resources.S_D_A; //8
            noteA_Short[1].Stream = Properties.Resources.S_F_A;
            noteA_Short[2].Stream = Properties.Resources.S_G_A;
            noteA_Short[3].Stream = Properties.Resources.S_H_A;
            noteA_Short[4].Stream = Properties.Resources.S_M_A;
            noteA_Short[5].Stream = Properties.Resources.S_O_A;
            noteA_Short[6].Stream = Properties.Resources.S_P_A;
            noteA_Short[7].Stream = Properties.Resources.S_V_A;

            noteB_Short[0].Stream = Properties.Resources.S_D_B; //8
            noteB_Short[1].Stream = Properties.Resources.S_F_B;
            noteB_Short[2].Stream = Properties.Resources.S_G_B;
            noteB_Short[3].Stream = Properties.Resources.S_H_B;
            noteB_Short[4].Stream = Properties.Resources.S_M_B;
            noteB_Short[5].Stream = Properties.Resources.S_O_B;
            noteB_Short[6].Stream = Properties.Resources.S_P_B;
            noteB_Short[7].Stream = Properties.Resources.S_V_B;

            noteD_Short[0].Stream = Properties.Resources.S_D_D; //8
            noteD_Short[1].Stream = Properties.Resources.S_F_D;
            noteD_Short[2].Stream = Properties.Resources.S_G_D;
            noteD_Short[3].Stream = Properties.Resources.S_H_D;
            noteD_Short[4].Stream = Properties.Resources.S_M_D;
            noteD_Short[5].Stream = Properties.Resources.S_O_D;
            noteD_Short[6].Stream = Properties.Resources.S_P_D;
            noteD_Short[7].Stream = Properties.Resources.S_V_D;

            noteD2_Short[0].Stream = Properties.Resources.S_D_D2; //8
            noteD2_Short[1].Stream = Properties.Resources.S_F_D2;
            noteD2_Short[2].Stream = Properties.Resources.S_G_D2;
            noteD2_Short[3].Stream = Properties.Resources.S_H_D2;
            noteD2_Short[4].Stream = Properties.Resources.S_M_D2;
            noteD2_Short[5].Stream = Properties.Resources.S_O_D2;
            noteD2_Short[6].Stream = Properties.Resources.S_P_D2;
            noteD2_Short[7].Stream = Properties.Resources.S_V_D2;

            noteF_Short[0].Stream = Properties.Resources.S_D_F; //8
            noteF_Short[1].Stream = Properties.Resources.S_F_F;
            noteF_Short[2].Stream = Properties.Resources.S_G_F;
            noteF_Short[3].Stream = Properties.Resources.S_H_F;
            noteF_Short[4].Stream = Properties.Resources.S_M_F;
            noteF_Short[5].Stream = Properties.Resources.S_O_F;
            noteF_Short[6].Stream = Properties.Resources.S_P_F;
            noteF_Short[7].Stream = Properties.Resources.S_V_F;

            time.Stream = Properties.Resources.time;
            saria.Stream = Properties.Resources.saria;
            epona.Stream = Properties.Resources.epona;
            storm.Stream = Properties.Resources.storm;
            zelda.Stream = Properties.Resources.zelda;
            sun.Stream = Properties.Resources.sun;
            light.Stream = Properties.Resources._66___Prelude_Of_Light;
            forest.Stream = Properties.Resources._58___Minuet_Of_Woods;
            fire.Stream = Properties.Resources._60___Bolero_Of_Fire;
            water.Stream = Properties.Resources._63___Serenade_Of_Water;
            shadow.Stream = Properties.Resources._65___Nocturne_Of_Shadow;
            spirit.Stream = Properties.Resources._70___Requiem_Of_Spirit;
            heal.Stream = Properties.Resources.heal;
            soar.Stream = Properties.Resources.soar;
            time2x.Stream = Properties.Resources.time2x;
            half.Stream = Properties.Resources.half;
            awake.Stream = Properties.Resources.awake;
            goron.Stream = Properties.Resources.goron;
            wave.Stream = Properties.Resources.wave;
            empty.Stream = Properties.Resources.empty;
            order.Stream = Properties.Resources.order;

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

        public void addSongs()
        {

            s_time      = new Song(time, "the Song of Time", A, D, F, A, D, F);
            s_saria     = new Song(saria, "Saria\'s Song", F, A, B, F, A, B);
            s_epona     = new Song(epona, "Epona\'s Song", D2, B, A, D2, B, A);
            s_storm     = new Song(storm, "the Song of Storms", D, F, D2, D, F, D2);
            s_zelda     = new Song(zelda, "Zelda\'s Lullaby", B, D2, A, B, D2, A);
            s_sun       = new Song(sun, "the Sun\'s Song", A, F, D2, A, F, D2);
            s_light     = new Song(light, "the Prelude of Light", D2, A, D2, A, B, D2);
            s_forest    = new Song(forest, "the Minuet of Forest", D, D2, B, A, B, A);
            s_fire      = new Song(fire, "the Bolero of Fire", F, D, F, D, A, F, A, F);
            s_water     = new Song(water, "the Serenade of Water", D, F, A, A, B);
            s_shadow    = new Song(shadow, "the Nocturn of Shadow", B, A, A, D, B, A, F);
            s_spirit    = new Song(spirit, "the Requiem of Spirit", D, F, D, A, F, D);
            s_heal      = new Song(heal, "the Song of Healing", B, A, F, B, A, F);
            s_soar      = new Song(soar, "the Song of Soaring", F, B, D2, F, B, D2);
            s_time2x    = new Song(time2x, "the Song of Double Time", A, A, D, D, F, F);
            s_half      = new Song(half, "the Inverted Song of Time", D, A, F, D, A, F);
            s_awake     = new Song(awake, "the Sonata of Awakening", D2, B, D2, B, D, A, D);
            s_goron     = new Song(goron, "the Goron Lullaby", D, A, B, D, A, B, A, D);
            s_wave      = new Song(wave, "New Wave Bossa Nova", B, D2, B, A, F, B, A);
            s_empty     = new Song(empty, "the Elegy of Emptiness", A, B, A, F, A, D2, B);
            s_order     = new Song(order, "the Oath to Order", A, F, D, F, A, D2);
        }

        public static bool A_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.A;
        }

        public static bool B_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.B;
        }

        public static bool Up_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Up;
        }

        public static bool Right_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Right;
        }

        public static bool Down_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Down;
        }

        public static bool Left_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Left;
        }

        public static bool Minus_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Minus;
        }

        public static bool Plus_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Plus;
        }

        public static bool One_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.One;
        }

        public static bool Two_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Two;
        }

        public static bool Home_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.ButtonState.Home;
        }

        public static bool C_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.NunchukState.C;
        }

        public static bool Z_Pressed(Wiimote wiimote)
        {
            return wiimote.WiimoteState.NunchukState.Z;
        }

        public static int Nunchuk_X_Value(Wiimote wiimote)
        {
            return (int)(wiimote.WiimoteState.NunchukState.Joystick.X * 100);
        }

        public static int Nunchuk_Y_Value(Wiimote wiimote)
        {
            return (int)(wiimote.WiimoteState.NunchukState.Joystick.Y * 100);
        }

        private void WiimoteListener()
        {
            pullNunchukJoystick(p1);
            if (Home_Pressed(p1))
            {
                if (About.ActiveForm.Equals(null) == false)
                    About.ActiveForm.Close();
                else if (SongForm.ActiveForm.Equals(null) == false)
                    SongForm.ActiveForm.Close();
                else
                    this.Close();
            }
            if (nunchuk_Y > 30)
            {
                if (A_Pressed(p1))
                {
                    noteD2_Loop[0].PlayLooping();
                    sp.AddNote(1);

                    if (CheckSong(0) > 0)
                    {
                        noteD2_Loop[0].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (B_Pressed(p1)) // (B)
                {
                    noteB_Loop[0].PlayLooping();
                    sp.AddNote(3);

                    if (CheckSong(0) > 0)
                    {
                        noteB_Loop[0].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                        sp = new Song();
                    }
                }
                if (Minus_Pressed(p1)) // (A)
                {
                    noteA_Loop[0].PlayLooping();
                    sp.AddNote(4);

                    if (CheckSong(0) > 0)
                    {
                        noteA_Loop[0].PlaySync();
                        silence.PlaySync();
                        songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song(); sp = new Song();
                    }
                }
                if (Plus_Pressed(p1)) // (F)
                {
                    noteF_Loop[0].PlayLooping();
                    sp.AddNote(6);

                    if (CheckSong(0) > 0)
                    {
                        noteF_Loop[0].PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (Z_Pressed(p1)) // (D)
                {
                    noteD_Loop[0].PlayLooping();
                    sp.AddNote(8);

                    if (CheckSong(0) > 0)
                    {
                        noteD_Loop[0].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
            }
            if (nunchuk_Y > 10 && nunchuk_Y <= 30)
            {
                if (A_Pressed(p1))
                {
                    noteD2_Loop[1].PlayLooping();
                    sp.AddNote(1);

                    if (CheckSong(0) > 0)
                    {
                        noteD2_Loop[1].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (B_Pressed(p1)) // (B)
                {
                    noteB_Loop[1].PlayLooping();
                    sp.AddNote(3);

                    if (CheckSong(0) > 0)
                    {
                        noteB_Loop[1].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                        sp = new Song();
                    }
                }
                if (Minus_Pressed(p1)) // (A)
                {
                    noteA_Loop[1].PlayLooping();
                    sp.AddNote(4);

                    if (CheckSong(0) > 0)
                    {
                        noteA_Loop[1].PlaySync();
                        silence.PlaySync();
                        songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song(); sp = new Song();
                    }
                }
                if (Plus_Pressed(p1)) // (F)
                {
                    noteF_Loop[1].PlayLooping();
                    sp.AddNote(6);

                    if (CheckSong(0) > 0)
                    {
                        noteF_Loop[1].PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (Z_Pressed(p1)) // (D)
                {
                    noteD_Loop[1].PlayLooping();
                    sp.AddNote(8);

                    if (CheckSong(0) > 0)
                    {
                        noteD_Loop[1].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
            }
            if (nunchuk_Y > -10 && nunchuk_Y <= 10)
            {
                if (A_Pressed(p1))
                {
                    noteD2_Loop[2].PlayLooping();
                    sp.AddNote(1);

                    if (CheckSong(0) > 0)
                    {
                        noteD2_Loop[2].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (B_Pressed(p1)) // (B)
                {
                    noteB_Loop[2].PlayLooping();
                    sp.AddNote(3);

                    if (CheckSong(0) > 0)
                    {
                        noteB_Loop[2].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                        sp = new Song();
                    }
                }
                if (Minus_Pressed(p1)) // (A)
                {
                    noteA_Loop[2].PlayLooping();
                    sp.AddNote(4);

                    if (CheckSong(0) > 0)
                    {
                        noteA_Loop[2].PlaySync();
                        silence.PlaySync();
                        songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song(); sp = new Song();
                    }
                }
                if (Plus_Pressed(p1)) // (F)
                {
                    noteF_Loop[2].PlayLooping();
                    sp.AddNote(6);

                    if (CheckSong(0) > 0)
                    {
                        noteF_Loop[2].PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (Z_Pressed(p1)) // (D)
                {
                    noteD_Loop[2].PlayLooping();
                    sp.AddNote(8);

                    if (CheckSong(0) > 0)
                    {
                        noteD_Loop[2].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
            }
            if (nunchuk_Y > -30 && nunchuk_Y <= -10)
            {
                if (A_Pressed(p1))
                {
                    noteD2_Loop[3].PlayLooping();
                    sp.AddNote(1);

                    if (CheckSong(0) > 0)
                    {
                        noteD2_Loop[3].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (B_Pressed(p1)) // (B)
                {
                    noteB_Loop[3].PlayLooping();
                    sp.AddNote(3);

                    if (CheckSong(0) > 0)
                    {
                        noteB_Loop[3].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                        sp = new Song();
                    }
                }
                if (Minus_Pressed(p1)) // (A)
                {
                    noteA_Loop[3].PlayLooping();
                    sp.AddNote(4);

                    if (CheckSong(0) > 0)
                    {
                        noteA_Loop[3].PlaySync();
                        silence.PlaySync();
                        songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song(); sp = new Song();
                    }
                }
                if (Plus_Pressed(p1)) // (F)
                {
                    noteF_Loop[3].PlayLooping();
                    sp.AddNote(6);

                    if (CheckSong(0) > 0)
                    {
                        noteF_Loop[3].PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (Z_Pressed(p1)) // (D)
                {
                    noteD_Loop[3].PlayLooping();
                    sp.AddNote(8);

                    if (CheckSong(0) > 0)
                    {
                        noteD_Loop[3].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
            }
            if (nunchuk_Y <= -30)
            {
                if (A_Pressed(p1))
                {
                    noteD2_Loop[4].PlayLooping();
                    sp.AddNote(1);

                    if (CheckSong(0) > 0)
                    {
                        noteD2_Loop[4].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (B_Pressed(p1)) // (B)
                {
                    noteB_Loop[4].PlayLooping();
                    sp.AddNote(3);

                    if (CheckSong(0) > 0)
                    {
                        noteB_Loop[4].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                        sp = new Song();
                    }
                }
                if (Minus_Pressed(p1)) // (A)
                {
                    noteA_Loop[4].PlayLooping();
                    sp.AddNote(4);

                    if (CheckSong(0) > 0)
                    {
                        noteA_Loop[4].PlaySync();
                        silence.PlaySync();
                        songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song(); sp = new Song();
                    }
                }
                if (Plus_Pressed(p1)) // (F)
                {
                    noteF_Loop[4].PlayLooping();
                    sp.AddNote(6);

                    if (CheckSong(0) > 0)
                    {
                        noteF_Loop[4].PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
                if (Z_Pressed(p1)) // (D)
                {
                    noteD_Loop[4].PlayLooping();
                    sp.AddNote(8);

                    if (CheckSong(0) > 0)
                    {
                        noteD_Loop[4].PlaySync();
                        silence.PlaySync();
                        silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                        PlaySong(); sp = new Song();
                    }
                }
            }
            // A button is D2
            // B button is B
            // Minus is A
            // Plus is F
            // Z is D
        }


        private void idleProcesses(object sender, EventArgs e)
        {
            
            WiimoteListener();

        }

        private void pullNunchukJoystick(Wiimote wiimote)
        {
            nunchuk_X = (int)(wiimote.WiimoteState.NunchukState.Joystick.X * 100);
            nunchuk_Y = (int)(wiimote.WiimoteState.NunchukState.Joystick.Y * 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noteA_Frog.Play();
            sp.AddNote(4);if(CheckSong(0) > 0){noteA_Frog.PlaySync();}

            
            if (CheckSong(0) > 0)
            {

                songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            noteB_Frog.Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Frog.PlaySync(); }
          
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();
                sp = new Song();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            noteD_Frog.Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Frog.PlaySync(); }
            
  
            if (CheckSong(0) > 0)
            {
                
                songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            noteD2_Frog.Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Frog.PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {

            noteF_Frog.Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Frog.PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           noteA_Long[0].Play();
           sp.AddNote(4);if(CheckSong(0) > 0){noteA_Short[0].PlaySync();}

           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }

        }
        private void button7_Click(object sender, EventArgs e)
        {
           noteB_Long[0].Play();
          sp.AddNote(3);if(CheckSong(0) > 0){noteB_Short[0].PlaySync();}
 
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button8_Click(object sender, EventArgs e)
        {
           noteD_Long[0].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[0].PlaySync(); }

           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button9_Click(object sender, EventArgs e)
        {
           noteD2_Long[0].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[0].PlaySync(); }

           if (CheckSong(0) > 0)
           {

               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong(); sp = new Song();
           }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            noteF_Long[0].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[0].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           noteA_Long[1].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[1].PlaySync(); }
           
           {
               
               

           }
           if (CheckSong(0) > 0)
           {
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }

        }
        private void button12_Click(object sender, EventArgs e)
        {
           noteB_Long[1].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[1].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button13_Click(object sender, EventArgs e)
        {
           noteD_Long[1].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[1].PlaySync(); }

           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            noteD2_Long[1].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            noteF_Long[1].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[1].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
           noteA_Long[2].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[2].PlaySync(); }
           
           {
               
               

           }
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button17_Click(object sender, EventArgs e)
        {
           noteB_Long[2].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[2].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button18_Click(object sender, EventArgs e)
        {
           noteD_Long[2].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[2].PlaySync(); }

           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            noteD2_Long[2].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            noteF_Long[2].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[2].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
           noteA_Long[3].Play();
           sp.AddNote(4);
 
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button22_Click(object sender, EventArgs e)
        {
           noteB_Long[3].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[3].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button23_Click(object sender, EventArgs e)
        {
           noteD_Long[3].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[3].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            noteD2_Long[3].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            noteF_Long[3].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[3].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
           noteA_Long[4].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[4].PlaySync(); }
           
           {
               
               

           }
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button27_Click(object sender, EventArgs e)
        {
           noteB_Long[4].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[4].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button28_Click(object sender, EventArgs e)
        {
           noteD_Long[4].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[4].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            noteD2_Long[4].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[4].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button30_Click(object sender, EventArgs e)
        {
            noteF_Long[4].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[4].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
           noteA_Long[5].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[5].PlaySync(); }
           
           {
               
               

           }
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button32_Click(object sender, EventArgs e)
        {
           noteB_Long[5].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[5].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button33_Click(object sender, EventArgs e)
        {
           noteD_Long[5].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[5].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            noteD2_Long[5].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[5].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button35_Click(object sender, EventArgs e)
        {
            noteF_Long[5].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[5].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
           noteA_Long[6].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[6].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button37_Click(object sender, EventArgs e)
        {
           noteB_Long[6].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[6].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button38_Click(object sender, EventArgs e)
        {
           noteD_Long[6].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[6].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button39_Click(object sender, EventArgs e)
        {
            noteD2_Long[6].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button40_Click(object sender, EventArgs e)
        {
            noteF_Long[6].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[6].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
           noteA_Long[7].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[7].PlaySync(); }
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button42_Click(object sender, EventArgs e)
        {
           noteB_Long[7].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[7].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button43_Click(object sender, EventArgs e)
        {
           noteD_Long[7].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[7].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button44_Click(object sender, EventArgs e)
        {
            noteD2_Long[7].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[7].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button45_Click(object sender, EventArgs e)
        {
            noteF_Long[7].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[7].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
           noteA_Long[8].Play();
           sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Loop[4].PlaySync(); }

           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button47_Click(object sender, EventArgs e)
        {
           noteB_Long[8].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Loop[4].PlaySync();}
   
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button48_Click(object sender, EventArgs e)
        {
           noteD_Long[8].Play();
           sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Loop[4].PlaySync(); }
           
           if (CheckSong(0) > 0)
           {
               
               silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
               PlaySong();sp = new Song();
           }
        }
        private void button49_Click(object sender, EventArgs e)
        {
            noteD2_Long[8].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Loop[4].PlaySync();}
          
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button50_Click(object sender, EventArgs e)
        {
            noteF_Long[8].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Loop[4].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            noteF_Short[7].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[7].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button52_Click(object sender, EventArgs e)
        {
            noteD2_Short[7].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[7].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button53_Click(object sender, EventArgs e)
        {
            noteD_Short[7].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[7].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button54_Click(object sender, EventArgs e)
        {
            noteB_Short[7].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[7].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button55_Click(object sender, EventArgs e)
        {
            noteA_Short[7].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[7].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            noteF_Short[6].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[6].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button57_Click(object sender, EventArgs e)
        {
            noteD2_Short[6].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button58_Click(object sender, EventArgs e)
        {
            noteD_Short[6].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[6].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button59_Click(object sender, EventArgs e)
        {
            noteB_Short[6].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button60_Click(object sender, EventArgs e)
        {
            noteA_Short[6].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[6].PlaySync(); }

            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            noteF_Short[5].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[5].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button62_Click(object sender, EventArgs e)
        {
            noteD2_Short[5].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[5].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button63_Click(object sender, EventArgs e)
        {
            noteD_Short[5].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[5].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button64_Click(object sender, EventArgs e)
        {
            noteB_Short[5].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[5].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button65_Click(object sender, EventArgs e)
        {
            noteA_Short[5].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[5].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            noteF_Short[4].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[4].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button67_Click(object sender, EventArgs e)
        {
            noteD2_Short[4].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[4].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button68_Click(object sender, EventArgs e)
        {
            noteD_Short[4].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[4].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button69_Click(object sender, EventArgs e)
        {
            noteB_Short[4].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[4].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button70_Click(object sender, EventArgs e)
        {
            noteA_Short[4].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[4].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            noteF_Short[3].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[3].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button72_Click(object sender, EventArgs e)
        {
            noteD2_Short[3].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button73_Click(object sender, EventArgs e)
        {
            noteD_Short[3].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button74_Click(object sender, EventArgs e)
        {
            noteB_Short[3].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[3].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button75_Click(object sender, EventArgs e)
        {
            noteA_Short[3].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            noteF_Short[2].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[2].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button77_Click(object sender, EventArgs e)
        {
            noteD2_Short[2].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button78_Click(object sender, EventArgs e)
        {
            noteD_Short[2].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button79_Click(object sender, EventArgs e)
        {
            noteB_Short[2].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[2].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button80_Click(object sender, EventArgs e)
        {
            noteA_Short[2].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            noteF_Short[1].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[1].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button82_Click(object sender, EventArgs e)
        {
            noteD2_Short[1].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button83_Click(object sender, EventArgs e)
        {
            noteD_Short[1].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button84_Click(object sender, EventArgs e)
        {
            noteB_Short[1].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[1].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button85_Click(object sender, EventArgs e)
        {
            noteA_Short[1].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[1].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            noteF_Short[0].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Short[0].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button87_Click(object sender, EventArgs e)
        {
            noteD2_Short[0].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Short[0].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button88_Click(object sender, EventArgs e)
        {
            noteD_Short[0].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Short[0].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button89_Click(object sender, EventArgs e)
        {
            noteB_Short[0].Play();
           sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Short[0].PlaySync(); }
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button90_Click(object sender, EventArgs e)
        {
            noteA_Short[0].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Short[0].PlaySync(); }

            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            noteF_Med[6].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[6].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button92_Click(object sender, EventArgs e)
        {
            noteD2_Med[6].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button93_Click(object sender, EventArgs e)
        {
            noteD_Med[6].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button94_Click(object sender, EventArgs e)
        {
            noteB_Med[6].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button95_Click(object sender, EventArgs e)
        {
            noteA_Med[6].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[6].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            noteF_Med[5].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[5].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button97_Click(object sender, EventArgs e)
        {
            noteD2_Med[5].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[5].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button98_Click(object sender, EventArgs e)
        {
            noteD_Med[5].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[5].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button99_Click(object sender, EventArgs e)
        {
            noteB_Med[5].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[5].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button100_Click(object sender, EventArgs e)
        {
            noteA_Med[5].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[5].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            noteF_Med[4].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[4].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button102_Click(object sender, EventArgs e)
        {
            noteD2_Med[4].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[4].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button103_Click(object sender, EventArgs e)
        {
            noteD_Med[4].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[4].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button104_Click(object sender, EventArgs e)
        {
            noteB_Med[4].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[4].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button105_Click(object sender, EventArgs e)
        {
            noteA_Med[4].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[4].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            noteF_Med[3].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[3].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button107_Click(object sender, EventArgs e)
        {
            noteD2_Med[3].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button108_Click(object sender, EventArgs e)
        {
            noteD_Med[3].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button109_Click(object sender, EventArgs e)
        {
            noteB_Med[3].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button110_Click(object sender, EventArgs e)
        {
            noteA_Med[3].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[3].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            noteF_Med[2].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[2].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button112_Click(object sender, EventArgs e)
        {
            noteD2_Med[2].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button113_Click(object sender, EventArgs e)
        {
            noteD_Med[2].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button114_Click(object sender, EventArgs e)
        {
            noteB_Med[2].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button115_Click(object sender, EventArgs e)
        {
            noteA_Med[2].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[2].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button116_Click(object sender, EventArgs e)
        {
            noteF_Med[1].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[1].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }

        }
        private void button117_Click(object sender, EventArgs e)
        {
            noteD2_Med[1].Play();
           sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }

        }
        private void button118_Click(object sender, EventArgs e)
        {
            noteD_Med[1].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }

        }
        private void button119_Click(object sender, EventArgs e)
        {
            noteB_Med[1].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button120_Click(object sender, EventArgs e)
        {
            noteA_Med[1].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[1].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button121_Click(object sender, EventArgs e)
        {
            noteF_Med[0].Play();
            sp.AddNote(6); if (CheckSong(0) > 0) { noteF_Med[0].PlaySync(); }

            if (CheckSong(0) > 0)
            {

                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button122_Click(object sender, EventArgs e)
        {
            noteD2_Med[0].Play();
            sp.AddNote(1); if (CheckSong(0) > 0) { noteD2_Med[0].PlaySync(); }
           
            if (CheckSong(0) > 0)
            {

                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button123_Click(object sender, EventArgs e)
        {
            noteD_Med[0].Play();
            sp.AddNote(8); if (CheckSong(0) > 0) { noteD_Med[0].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button124_Click(object sender, EventArgs e)
        {
            noteB_Med[0].Play();
            sp.AddNote(3); if (CheckSong(0) > 0) { noteB_Med[0].PlaySync(); }
           
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button125_Click(object sender, EventArgs e)
        {
            noteA_Med[0].Play();
            sp.AddNote(4); if (CheckSong(0) > 0) { noteA_Med[0].PlaySync(); }
            
            if (CheckSong(0) > 0)
            {
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button126_Click(object sender, EventArgs e)
        {
            noteF_Loop[4].PlayLooping();
            sp.AddNote(6);

            if (CheckSong(0) > 0)
            {
                noteF_Loop[4].PlaySync();
                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button127_Click(object sender, EventArgs e)
        {
            noteD2_Loop[4].PlayLooping();
           sp.AddNote(1);

            if (CheckSong(0) > 0)
            {
                noteD2_Loop[4].Play();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button128_Click(object sender, EventArgs e)
        {
            noteD_Loop[4].PlayLooping();
            sp.AddNote(8);
            
            if (CheckSong(0) > 0)
            {
                noteD_Loop[4].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button129_Click(object sender, EventArgs e)
        {
            noteB_Loop[4].PlayLooping();
           sp.AddNote(3);
            
            if (CheckSong(0) > 0)
            {
                noteB_Loop[4].PlaySync();         
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button130_Click(object sender, EventArgs e)
        {
            noteA_Loop[4].PlayLooping();
            sp.AddNote(4);
            
            if (CheckSong(0) > 0)
            {
                noteA_Loop[4].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button131_Click(object sender, EventArgs e)
        {
            noteF_Loop[3].PlayLooping();
            sp.AddNote(6);

            if (CheckSong(0) > 0)
            {
                noteF_Loop[2].PlaySync();
                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button132_Click(object sender, EventArgs e)
        {
            noteD2_Loop[3].PlayLooping();
           sp.AddNote(1);
            
            if (CheckSong(0) > 0)
            {
                noteD2_Loop[3].PlaySync();
                silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button133_Click(object sender, EventArgs e)
        {
            noteD_Loop[3].PlayLooping();
            sp.AddNote(8);
            
            if (CheckSong(0) > 0)
            {
                noteD_Loop[3].PlaySync();    
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button134_Click(object sender, EventArgs e)
        {
            noteB_Loop[3].PlayLooping();
           sp.AddNote(3);
            
            if (CheckSong(0) > 0)
            {
                noteB_Loop[3].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button135_Click(object sender, EventArgs e)
        {
            noteA_Loop[3].PlayLooping();
            sp.AddNote(4);
            
            if (CheckSong(0) > 0)
            {
                noteA_Loop[3].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            noteF_Loop[2].PlayLooping();
            sp.AddNote(6);

            if (CheckSong(0) > 0)
            {
                noteF_Loop[2].PlaySync();
                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button137_Click(object sender, EventArgs e)
        {
            noteD2_Loop[2].PlayLooping();
           sp.AddNote(1);
             
            if (CheckSong(0) > 0)
            {
                noteD2_Loop[2].PlaySync();
                silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button138_Click(object sender, EventArgs e)
        {
            noteD_Loop[2].PlayLooping();
            sp.AddNote(8);
            
            if (CheckSong(0) > 0)
            {
                noteD_Loop[2].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button139_Click(object sender, EventArgs e)
        {
            noteB_Loop[2].PlayLooping();
           sp.AddNote(3);
            
            if (CheckSong(0) > 0)
            {
                noteB_Loop[2].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button140_Click(object sender, EventArgs e)
        {
            noteA_Loop[2].PlayLooping();
            sp.AddNote(4);
            
            if (CheckSong(0) > 0)
            {
                noteA_Loop[2].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button141_Click(object sender, EventArgs e)
        {
            noteF_Loop[1].PlayLooping();
            sp.AddNote(6);

            if (CheckSong(0) > 0)
            {
                noteF_Loop[1].PlaySync();
                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button142_Click(object sender, EventArgs e)
        {
            noteD2_Loop[1].PlayLooping();
           sp.AddNote(1);
            
            if (CheckSong(0) > 0)
            {
                noteD2_Loop[1].PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button143_Click(object sender, EventArgs e)
        {
            noteD_Loop[1].PlayLooping();
            sp.AddNote(8);
             
            if (CheckSong(0) > 0)
            {
               noteD_Loop[1].PlaySync();
                 silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button144_Click(object sender, EventArgs e)
        {
            noteB_Loop[1].PlayLooping();
           sp.AddNote(3);
      
            if (CheckSong(0) > 0)
            {
                noteB_Loop[1].PlaySync();
                silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button145_Click(object sender, EventArgs e)
        {
            noteA_Loop[1].PlayLooping();
            sp.AddNote(4);

            if (CheckSong(0) > 0)
            {
                noteA_Loop[1].PlaySync();
                
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }

        private void button146_Click(object sender, EventArgs e)
        {
            noteF_Loop[0].PlayLooping();
            sp.AddNote(6);

            if (CheckSong(0) > 0)
            {
                noteF_Loop[0].PlaySync();
                silence.PlaySync(); songForm = new SongForm(CheckSong()); songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button147_Click(object sender, EventArgs e)
        {
            noteD2_Loop[0].PlayLooping();
           sp.AddNote(1);
            

            if (CheckSong(0) > 0)
            {
                noteD2_Loop[0].PlaySync();
                silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong(); sp = new Song();
            }
        }
        private void button148_Click(object sender, EventArgs e)
        {
            noteD_Loop[0].PlayLooping();
            sp.AddNote(8);
            
            if (CheckSong(0) > 0)
            {
                noteD_Loop[0].PlaySync();
                silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
            }
        }
        private void button149_Click(object sender, EventArgs e)
        {
            noteB_Loop[0].PlayLooping();
           sp.AddNote(3);

            if (CheckSong(0) > 0)
            {
                noteB_Loop[0].PlaySync();
                silence.PlaySync();
                silence.PlaySync();songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();
                sp = new Song();
            }
            
        }
        private void button150_Click(object sender, EventArgs e)
        {
            noteA_Loop[0].PlayLooping();
            sp.AddNote(4);
            
            if (CheckSong(0) > 0)
            {
                noteA_Loop[0].PlaySync();
                silence.PlaySync();
                songForm = new SongForm(CheckSong());songForm.Show();
                PlaySong();sp = new Song();sp = new Song();
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            silence.Play();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            p1.SetLEDs(false, false, false, false);
            p1.Disconnect();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialogue = new About();
            aboutDialogue.Show();
            secret.Play();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
