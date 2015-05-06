/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValueEngine;
using ValueEngine.Input;
using Tao.DevIl;
using Tao.OpenGl;


namespace <<PROJECT NAME HERE>>
{
    public partial class Form1 : Form
    {

        bool            _fullscreen     = false;
        FastLoop        _fastLoop;
        StateSystem     _system         = new StateSystem();
        Input           _input          = new Input();
        TextureManager  _textureManager = new TextureManager();
        SoundManager    _soundManager   = new SoundManager();


        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();

            _input.Mouse = new Mouse(this, simpleOpenGlControl1);
            _input.Keyboard = new Keyboard(simpleOpenGlControl1);

            InitializeDisplay();
            InitializeSounds();
            InitializeTextures();
            InitializeFonts();
            InitializeGameState();

            _fastLoop = new FastLoop(GameLoop);
        }

        private void InitializeFonts()
        {
            //Fonts are loaded here
        }

        private void InitializeSounds()
        {
            //sounds are loaded here
        }

        private void InitializeGameState()
        {
            //Game states loaded here

        }

        private void InitializeTextures()
        {
            //Init DevIl
            Il.ilInit();
            Ilu.iluInit();
            Ilut.ilutInit();
            Ilut.ilutRenderer(Ilut.ILUT_OPENGL);

            //Textures Loaded here
        }

        private void InitializeDisplay()
        {
            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                ClientSize = new Size(1280, 720);
            }
            Setup2DGraphics(ClientSize.Width, ClientSize.Height);
        }

        private void UpdateInput(double elapsedTime)
        {
            _input.Update(elapsedTime);
        }

        private void GameLoop(double elapsedTime)
        {
            //update
            UpdateInput(elapsedTime);

            //Process
            _system.Update(elapsedTime);

            //Render
            _system.Render();
            simpleOpenGlControl1.Refresh();
        }

        protected override void OnClientSizeChanges(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            Gl.glViewport(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            Setup2DGraphics(ClientSize.Width, ClientSize.Height);
        }

        private void Setup2DGraphics(double width, double height)
        {
            double halfWidth = width / 2;
            double halfHeight = height / 2;
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-halfWidth, halfWidth, -halfHeight, halfHeight, -100, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
*/