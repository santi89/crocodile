using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using System.Drawing.Imaging;
using Tao.Platform;

using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Crocodile : Form
    {

        Thread th;
        double eyex, eyey, eyez;
        double atx, aty, atz, rotx, roty, rotz;
        float r1, r2, r3, r4, r5, r6, r7, r8, r9;

        SoundPlayer sound,sound2,sound3;
        String soundfile,soundfile1,soundfile2;
        float yh1=6.0f, yh2=9.0f, yh3=10.0f,ny1=7.5f,ny2=8.5f;

        double number_random;
        double x1 = -6.5, y1 = 0, z1 = 9;

        private void btstart_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           
        }
        private void opengame()
        {
            Application.Run(new Crocodile());
        }
        private void mainform()
        {
            Application.Run(new Main_Crocodile());

        }
        private void btstart_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opengame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        double x2 = -3.5, y2 = 0, z2 = 9;

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Close();
            sound2.Stop();
            sound3.Stop();
            th = new Thread(mainform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        double x3 = 0, y3 = 0, z3 = 9;
        double x4 = 3, y4 = 0, z4 = 9;
        double x5 = 5.5, y5 = 0, z5 = 9;
        double x6 = -8, y6 = 0, z6 = 7;
        double x7 = -8, y7 = 0, z7 = 4.5;
        double x8 = 7, y8 = 0, z8 = 7;
        double x9 = 8, y9 = 0, z9 = 4.5;

        double n1, n2, n3, n4, n5, n6, n7, n8, n9;
        private void simpleOpenGlControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'o' || e.KeyChar == 'O')
            {
                eyex += 0.8; //eyez += 0.8;
                simpleOpenGlControl1.Invalidate();
            }
            if (e.KeyChar == 'i' || e.KeyChar == 'I')
            {
                eyex -= 0.8; //eyez -= 0.8;
                simpleOpenGlControl1.Invalidate();
            }
            if (e.KeyChar == 'x' || e.KeyChar == 'X')
            {
                rotx += 10;
            }
            if (e.KeyChar == 'y' || e.KeyChar == 'Y')
            {
                roty += 10;
            }
            if (e.KeyChar == 'z' || e.KeyChar == 'Z')
            {
                rotz += 10;
            }

            switch (e.KeyChar)
            {
                case (char)Keys.D1:

                    r1=0.5f;
                    n1 = 1;
                    c11 = 1.0f; c12 = 1.0f; c13 = 1.0f;
                   
                    if (n1 == number_random)
                    {
                       // MessageBox.Show("To ni la");
                        yh1 = 0f;yh2 = 3.0f;yh3 = 4.0f; ny1 = 1;ny2 = 2;
                    gameover();                        
                    }
                    
                    break;

                case (char)Keys.D2:

                    r2 = 0.5f;
                    n2 = 2;
                    c21 = 1.0f; c22 = 1.0f; c23 = 1.0f;

                    if (n2 == number_random)
                    {
                       // MessageBox.Show("To ni la"); 
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2;
                      gameover();  
                    }
                   
                    break;
                case (char)Keys.D3:
                    n3 = 3;
                    c31 = 1.0f; c32 = 1.0f; c33 = 1.0f;

                    if (n3 == number_random)
                    {
                       // MessageBox.Show("To ni la"); 
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2;

   gameover(); 
                    }
                    
                    r3 = 0.5f;
                    break;
                case (char)Keys.D4:

                    r4 = 0.5f;
                    n4 = 4; c41 = 1.0f; c42 = 1.0f; c43 = 1.0f;
                    n4 = 4;
                    if (n4 == number_random)
                    {
                       // MessageBox.Show("To ni la");
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2; 
 
       gameover(); 
                    }
            
                    break;
                case (char)Keys.D5:

                    r5 = 0.5f;
                    n5 = 5;
                    c51 = 1.0f; c52 = 1.0f; c53 = 1.0f;
                    n5 = 5;
                    if (n5 == number_random)
                    {
                        //MessageBox.Show("To ni la"); 
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2;
                        gameover();                 
  
                    }
                    
                    break;
                case (char)Keys.D6:

                    r6 = 0.5f;
                    n6 = 6; c61 = 1.0f; c62 = 1.0f; c63 = 1.0f;
                    n6= 6;
                    if (n6 == number_random)
                    {
                       // MessageBox.Show("To ni la");
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2; 
                        
                        gameover();
                 
                    }
                    
                    break;
                case (char)Keys.D7:
                    r7 = 0.5f;
                    n7 = 7; c71 = 1.0f; c72 = 1.0f; c73 = 1.0f;
                    if (n7 == number_random)
                    {
                       // MessageBox.Show("To ni la"); 
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2;
                     gameover();  
                      
          
                    }
                   
                    break;
                case (char)Keys.D8:

                    r8 = 0.5f;
                    n8 = 8; c81 = 1.0f; c82 = 1.0f; c83 = 1.0f;
                    if (n8 == number_random)
                    {
                       // MessageBox.Show("To ni la"); 
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2;
                      gameover();  
                       
    
                    }                  
                    break;
                case (char)Keys.D9:

                    r9 = 0.5f;
                    n9 = 9;
                    c91 = 1.0f;c92 =1.0f;c93 =1.0f;
                    if (n9 == number_random)
                    {
                       // MessageBox.Show("To ni la");
                        yh1 = 0f; yh2 = 3.0f; yh3 = 4.0f; ny1 = 1; ny2 = 2; 
                        gameover();  
                    

                    }
                    
                    break;

            }

            simpleOpenGlControl1.Invalidate();
        }

        private void gameover()
        {
            label1.Visible = true;
            btnout.Visible = true;
            btstart.Visible = true;
            playEnd();
        }
        private void randomnumber()
        {

            Random rm = new Random();
            int t = rm.Next(1, 10);
           // MessageBox.Show(t.ToString());
            number_random = t;
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }
       

        private void playbackgroud()
        {
            soundfile1 = @"background_sound.wav";
            sound2 = new SoundPlayer(soundfile1);
            sound2.PlayLooping();
        } 
        private void playEnd()
        {
            soundfile2 = @"end.wav";
            sound3 = new SoundPlayer(soundfile2);
            sound3.PlayLooping();
        }
       
        
        public Crocodile()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            simpleOpenGlControl1.InitializeContexts();
            //simpleOpenGlControl1.SwapBuffers();

            int w = simpleOpenGlControl1.Width;
            int h = simpleOpenGlControl1.Height;
            Gl.glViewport(0, 0, w, h);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

             Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)w / h, 0.01f, 5000.0f);
            // Gl.glEnable(Gl.GL_LIGHTING);

            eyex = 5; eyez = 35; eyey = 25;
            atx = 0; aty = 0; atz = 0;
            r1= r2= r3= r4= r5= r6= r7= r8= r9 = 1;

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            mainstart();
        }
      
        private void mainstart()
        {
            Gl.glClearColor(0.8f, 0.8f, 0.8f, 0.8f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(eyex, eyey, eyez, atx, aty, atz, 0.0, 1.0, 0.0);
            Gl.glPushMatrix();
            // Gl.glEnable(Gl.GL_DEPTH_TEST);
            //Gl.glDisable(Gl.GL_LIGHTING);

            Gl.glRotated(rotx, 1, 0, 0);
            Gl.glRotated(roty, 0, 1, 0);
            Gl.glRotated(rotz, 0, 0, 1);
            Gl.glBegin(Gl.GL_LINES);


            // X axis
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(100.0f, 0.0f, 00.0f);
            Gl.glVertex3f(-1000.0f, 0.0f, 0.0f);
            // Y axis
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(0.0f, 100.0f, 0.0f);
            Gl.glVertex3f(0.0f, -100.0f, 0.0f);
            // Z axis
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(0.0f, 0.0f, 100.0f);
            Gl.glVertex3f(0.0f, 0.0f, -100.0f);
            Gl.glEnd();

            //draw rectangle
            Gl.glPushMatrix();
            teeth();
            head();
            lowmouth();
            upmouth();
            //  hitmouth();
            //teeth();

            Gl.glPopMatrix();
        }
        private void upmouth()
        {
              

            //upmouth

            //Gl.glPushMatrix();
            //ດ້ານລຸ່ມ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.3f, 0.0f);
            Gl.glVertex3f(-10.0f, yh1, 10.0f);
            Gl.glVertex3f(10.0f, yh1 ,10.0f);

            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glEnd();


            //ດ້ານເທິງ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.3f, 0.0f);
            Gl.glVertex3f(-10.0f, yh2, 10.0f);
            Gl.glVertex3f(10.0f, yh2, 10.0f);

            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glEnd();

            //ດ້ານຂ້າງຊ້າຍ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.3f, 0.0f);
            Gl.glVertex3f(-10.0f, yh1, 10.0f);

            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);

            Gl.glVertex3f(-10.0f, yh2, 10.0f);
            Gl.glEnd();
            //ດ້ານຂ້າງຫຼັງ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.3f, 0.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(10.0f, -1.0f, -10.0f);

            Gl.glVertex3f(-10.0f, -1.0f, -10.0f);
            Gl.glEnd();
            //ດ້ານຂ້າງຂວາ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.3f, 0.0f);
            Gl.glVertex3f(10.0f, yh2, 10.0f);

            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(10.0f, 0.0f, -10.0f);

            Gl.glVertex3f(10.0f, yh1, 10.0f);
            Gl.glEnd();

            //ດ້ານຂ້າງໜ້າ
            //Gl.glPushMatrix();
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0.1f, 0.25f, 0.0f);
            Gl.glVertex3f(-10.0f, yh1, 10.0f);
            Gl.glVertex3f(10.0f, yh1, 10.0f);
            Gl.glVertex3f(10.0f, yh2, 10.0f);
            Gl.glVertex3f(5.0f, yh3, 10.0f);
            Gl.glVertex3f(0.0f, yh2, 10.0f);
            Gl.glVertex3f(-5.0f, yh3, 10.0f);
            Gl.glVertex3f(-10.0f, yh2, 10.0f);
            Gl.glEnd();

            //nose left
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0, 0, 0);
            Gl.glVertex3f(-6f,ny1, 10.5f);
            Gl.glVertex3f(-4.0f, ny1, 10.5f);
            Gl.glVertex3f(-3.0f, ny1, 10.5f);
            Gl.glVertex3f(-4.0f, ny2, 10.5f);
            Gl.glVertex3f(-6.5f, ny2, 10.5f);
            Gl.glVertex3f(-7f, ny1, 10.5f);
            Gl.glEnd();
            //nose right
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0, 0, 0);
            Gl.glVertex3f(6f, ny1, 10.5f);
            Gl.glVertex3f(4.0f, ny1, 10.5f);
            Gl.glVertex3f(3.0f, ny1, 10.5f);
            Gl.glVertex3f(4.0f, ny2, 10.5f);
            Gl.glVertex3f(6.5f, ny2, 10.5f);
            Gl.glVertex3f(7f, ny1, 10.5f);
            Gl.glEnd();
            //Gl.glPopMatrix();
        }

      
        private void lowmouth()
        {
            //lowmouth
            //Gl.glPushMatrix();

            //ດ້ານລຸ່ມ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.5f, 0.0f);
            Gl.glVertex3f(-10.0f, -1.0f, 10.0f);
            Gl.glVertex3f(10.0f, -1.0f, 10.0f);
            Gl.glVertex3f(10.0f, -1.0f, -10.0f);
            Gl.glVertex3f(-10.0f, -1.0f, -10.0f);
            Gl.glEnd();


            //ດ້ານເທິງ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.5f, 0.0f);
            Gl.glVertex3f(-10.0f, 0.0f, 10.0f);
            Gl.glVertex3f(10.0f, 0.0f, 10.0f);
            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glEnd();

            //ດ້ານຂ້າງຊ້າຍ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.5f, 0.0f);
            Gl.glVertex3f(-10.0f, 0.0f, 10.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(-10.0f, -1.0f, -10.0f);
            Gl.glVertex3f(-10.0f, -1.0f, 10.0f);
            Gl.glEnd();
            //ດ້ານຂ້າງຂວາ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.5f, 0.0f);
            Gl.glVertex3f(-10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(10.0f, -1.0f, -10.0f);
            Gl.glVertex3f(-10.0f, -1.0f, -10.0f);
            Gl.glEnd();
            //ດ້ານຂ້າງຫຼັງ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.5f, 0.0f);
            Gl.glVertex3f(10.0f, 0.0f, 10.0f);
            Gl.glVertex3f(10.0f, 0.0f, -10.0f);
            Gl.glVertex3f(10.0f, -1.0f, -10.0f);
            Gl.glVertex3f(10.0f, -1.0f, 10.0f);
            Gl.glEnd();
            //ດ້ານຂ້າງໜ້າ
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.1f, 0.5f, 0.0f);
            Gl.glVertex3f(-10.0f, -1.0f, 10.0f);
            Gl.glVertex3f(10.0f, -1.0f, 10.0f);
            Gl.glVertex3f(10.0f, 0.0f, 10.0f);
            Gl.glVertex3f(-10.0f, 0.0f, 10.0f);
            Gl.glEnd();

            //Gl.glPopMatrix();
        }

        private void head()
        {
            //Gl.glPushMatrix();
            //back field            
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0, 0.5f, 0.5f);
            Gl.glVertex3d(-10.0f, 0.0f, -10.0f);
            Gl.glVertex3d(10.0f, 0.0f, -10.0f);
            Gl.glVertex3d(10.0f, 6.5f, -10.0f);
            Gl.glVertex3d(5.0f, 7.0f, -10.0f);
            Gl.glVertex3d(0.0f, 6.0f, -10.0f);
            Gl.glVertex3d(-5.0f, 7.0f, -10.0f);
            Gl.glVertex3d(-10.0f, 6.5f, -10.0f);
            Gl.glEnd();

            //eye r
            Gl.glPushMatrix();
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glTranslated(5, 4, -7.5f);
            Glu.gluDisk(Glu.gluNewQuadric(), 0.5, 2, 30, 30);
            Gl.glPopMatrix();
            //end eye 
            //eye l           
            Gl.glPushMatrix();
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glTranslated(-5, 4, -7.5f);
            Glu.gluDisk(Glu.gluNewQuadric(), 0.5, 2, 30, 30);
            Gl.glPopMatrix();
            //end eye
            //end back
            //right field          
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0, 0.5f, 0.5f);
            Gl.glVertex3d(10.0f, 0.0f, -8.0f);
            Gl.glVertex3d(10.0f, 6.5f, -8.0f);
            Gl.glVertex3d(10.0f, 6.5f, -10.0f);
            Gl.glVertex3d(10.0f, 0.0f, -10.0f);
            Gl.glEnd();
            //left field          
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0, 0.5f, 0.5f);
            Gl.glVertex3d(-10.0f, 0.0f, -8.0f);
            Gl.glVertex3d(-10.0f, 6.5f, -8.0f);
            Gl.glVertex3d(-10.0f, 6.5f, -10.0f);
            Gl.glVertex3d(-10.0f, 0.0f, -10.0f);
            Gl.glEnd();
            //roof field

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0, 0.5f, 0.5f);

            Gl.glVertex3d(-10.0f, 6.5f, -8.0f);
            Gl.glVertex3d(-10.0f, 6.5f, -10.0f);
            Gl.glVertex3d(10.0f, 6.5f, -10.0f);
            Gl.glVertex3d(10.0f, 6.5f, -8.0f);
            Gl.glEnd();
            //end roof field
            //fornt field

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0, 0.5f, 0.5f);
            Gl.glVertex3d(10.0f, 0.0f, -8.0f);
            Gl.glVertex3d(10.0f, 6.5f, -8.0f);
            Gl.glVertex3d(5.0f, 7.0f, -8.0f);
            Gl.glVertex3d(0.0f, 6.0f, -8.0f);
            Gl.glVertex3d(-5.0f, 7.0f, -8.0f);
            Gl.glVertex3d(-10.0f, 6.5f, -8.0f);
            Gl.glVertex3d(-10.0f, 0.0f, -8.0f);
            Gl.glEnd();


            // enfornt field




            //Gl.glPopMatrix();
        }

       

        float c11 =0f, c12=1f, c13=1, c21=0f, c22=0f, c23=1f, c31=0.8f, c32=0.4f, c33=0.5f, c41=1f, c42=0.5f, c43=0f, c51=0, c52=0.5f, c53=1.0f, c61=1.0f, c62=0.0f, c63=0.0f, c71=0.0f, c72=0.1f, c73=0.0f, c81=1.0f, c82=0.0f, c83=1.0f, c91=1.0f, c92=1.0f, c93=0.0f;
        private void teeth()
        {

           
            //1
            Gl.glPushMatrix();
          
            Gl.glColor3f(c21, c22, c23);
            Gl.glTranslated(x7, y7, z7);
           
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r1, 30, 30);
            
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //2
             Gl.glPushMatrix();
           
            Gl.glColor3f(c11,c12,c13);
            Gl.glTranslated(x6, y6, z6);
           
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r2, 30, 30);
           
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //3
            Gl.glPushMatrix();
           
            Gl.glColor3f(c31,c32,c33);
            Gl.glTranslated(x1,y1,z1);
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r3, 30, 30);
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //4
            Gl.glPushMatrix();
           
            Gl.glColor3f(c41, c42, c43);
           
            Gl.glTranslated(x2,y2,z2);
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r4, 30, 30);
           
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //5
            Gl.glPushMatrix();
           
            Gl.glColor3f(c51, c52, c53);
         
            Gl.glTranslated(x3, y3, z3);

            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r5, 30, 30);
           
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //6
            Gl.glPushMatrix();
            
            Gl.glColor3f(c61, c62, c63);
            Gl.glTranslated(x4,y4,z4);
            
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r6, 30, 30);
            
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //7
            Gl.glPushMatrix();
           
            Gl.glColor3f(c71, c72, c73);
            Gl.glTranslated(x5,y5,z5);
           
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r7, 30, 30);
            
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            
            //8
            Gl.glPushMatrix();
            
            Gl.glColor3f(c81, c82, c83);
            Gl.glTranslated(x8,y8,z8);
          ;
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r8, 30, 30);
           
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
            Gl.glPopMatrix();
            //9
            Gl.glPushMatrix();
           
            Gl.glColor3f(c91, c92, c93);
            Gl.glTranslated(x9,y9,z9);
           
            Gl.glRotated(268, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 1, 0.5, r9, 30, 30);          
            Glu.gluDisk(Glu.gluNewQuadric(), 0, 1, 30, 30);
           
            Gl.glPopMatrix();
        }
        private void Crocodile_Load(object sender, EventArgs e)
        {
         
            randomnumber();
           playbackgroud();
        }
    }
}
