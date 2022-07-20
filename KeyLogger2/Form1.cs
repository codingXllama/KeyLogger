using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KeyLogger2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            // this timer will trigger the tick event every 1ms
            timer1.Interval = 1;
            timer1.Stop();
        }

        bool start = false;
        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                start = true;
                timer1.Start();
            }
            else if (start == true)
            {
                start = false;
                timer1.Stop();
            }
        }
        bool q, w, E, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z, x, c, v, b, n, m, space = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Q) && q == true) { richTextBox1.Text += "Q"; q = false; }
            if (Keyboard.IsKeyDown(Key.W) && w == true) { richTextBox1.Text += "W"; w = false; }
            if (Keyboard.IsKeyDown(Key.E) && E == true) { richTextBox1.Text += "E"; E = false; }
            if (Keyboard.IsKeyDown(Key.R) && r == true) { richTextBox1.Text += "R"; r = false; }
            if (Keyboard.IsKeyDown(Key.T) && t == true) { richTextBox1.Text += "T"; t = false; }
            if (Keyboard.IsKeyDown(Key.Y) && y == true) { richTextBox1.Text += "Y"; y = false; }
            if (Keyboard.IsKeyDown(Key.U) && u == true) { richTextBox1.Text += "U"; u = false; }
            if (Keyboard.IsKeyDown(Key.I) && i == true) { richTextBox1.Text += "I"; i = false; }
            if (Keyboard.IsKeyDown(Key.O) && o == true) { richTextBox1.Text += "O"; o = false; }
            if (Keyboard.IsKeyDown(Key.P) && p == true) { richTextBox1.Text += "P"; p = false; }
            if (Keyboard.IsKeyDown(Key.A) && a == true) { richTextBox1.Text += "A"; a = false; }
            if (Keyboard.IsKeyDown(Key.S) && s == true) { richTextBox1.Text += "S"; s = false; }
            if (Keyboard.IsKeyDown(Key.D) && d == true) { richTextBox1.Text += "D"; d = false; }
            if (Keyboard.IsKeyDown(Key.F) && f == true) { richTextBox1.Text += "F"; f = false; }
            if (Keyboard.IsKeyDown(Key.G) && g == true) { richTextBox1.Text += "G"; g = false; }
            if (Keyboard.IsKeyDown(Key.H) && h == true) { richTextBox1.Text += "H"; h = false; }
            if (Keyboard.IsKeyDown(Key.J) && j == true) { richTextBox1.Text += "J"; j = false; }
            if (Keyboard.IsKeyDown(Key.K) && k == true) { richTextBox1.Text += "K"; k = false; }
            if (Keyboard.IsKeyDown(Key.L) && l == true) { richTextBox1.Text += "L"; l = false; }
            if (Keyboard.IsKeyDown(Key.Z) && z == true) { richTextBox1.Text += "Z"; z = false; }
            if (Keyboard.IsKeyDown(Key.X) && x == true) { richTextBox1.Text += "X"; x = false; }
            if (Keyboard.IsKeyDown(Key.C) && c == true) { richTextBox1.Text += "C"; c = false; }
            if (Keyboard.IsKeyDown(Key.V) && v == true) { richTextBox1.Text += "V"; v = false; }
            if (Keyboard.IsKeyDown(Key.B) && b == true) { richTextBox1.Text += "B"; b = false; }
            if (Keyboard.IsKeyDown(Key.N) && n == true) { richTextBox1.Text += "N"; n = false; }
            if (Keyboard.IsKeyDown(Key.M) && m == true) { richTextBox1.Text += "M"; m = false; }
            if (Keyboard.IsKeyDown(Key.Space) && space == true) { richTextBox1.Text += " "; space = false; }

            if (Keyboard.IsKeyUp(Key.Q)) { q = true; }
            if (Keyboard.IsKeyUp(Key.W)) { w = true; }
            if (Keyboard.IsKeyUp(Key.E)) { E = true; }
            if (Keyboard.IsKeyUp(Key.R)) { r = true; }
            if (Keyboard.IsKeyUp(Key.T)) { t = true; }
            if (Keyboard.IsKeyUp(Key.Y)) { y = true; }
            if (Keyboard.IsKeyUp(Key.U)) { u = true; }
            if (Keyboard.IsKeyUp(Key.I)) { i = true; }
            if (Keyboard.IsKeyUp(Key.O)) { o = true; }
            if (Keyboard.IsKeyUp(Key.P)) { p = true; }
            if (Keyboard.IsKeyUp(Key.A)) { a = true; }
            if (Keyboard.IsKeyUp(Key.S)) { s = true; }
            if (Keyboard.IsKeyUp(Key.D)) { d = true; }
            if (Keyboard.IsKeyUp(Key.F)) { f = true; }
            if (Keyboard.IsKeyUp(Key.G)) { g = true; }
            if (Keyboard.IsKeyUp(Key.H)) { h = true; }
            if (Keyboard.IsKeyUp(Key.J)) { j = true; }
            if (Keyboard.IsKeyUp(Key.K)) { k = true; }
            if (Keyboard.IsKeyUp(Key.L)) { l = true; }
            if (Keyboard.IsKeyUp(Key.Z)) { z = true; }
            if (Keyboard.IsKeyUp(Key.X)) { x = true; }
            if (Keyboard.IsKeyUp(Key.C)) { c = true; }
            if (Keyboard.IsKeyUp(Key.V)) { v = true; }
            if (Keyboard.IsKeyUp(Key.B)) { b = true; }
            if (Keyboard.IsKeyUp(Key.N)) { n = true; }
            if (Keyboard.IsKeyUp(Key.M)) { m = true; }
            if (Keyboard.IsKeyUp(Key.Space)) { space = true; }
        }
    }
}
