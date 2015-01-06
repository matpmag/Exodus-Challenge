﻿using System;
using System.Windows.Forms;
using Exodus_Challenge.LoginSystem;

namespace Exodus_Challenge
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        public void playVideo( string path )
        {
            string fullPath = Application.ExecutablePath.Substring( 0, Application.ExecutablePath.LastIndexOf( @"\" ) - 27 ) + path;
            wmp.URL = fullPath;
            wmp.Ctlcontrols.play();
        }

        private void VideoPlayer_Load( object sender, EventArgs e )
        {
            playVideo( AccountMainControls.videoToPlay );
        }

        private void wmp_MediaError( object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e )
        {
            throw new ArgumentNullException( "File does not exist" );
        }

        private void wmp_PlayStateChange( object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e )
        {
            if ( (WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped )
            {
                this.Close();
            }
        }
    }
}