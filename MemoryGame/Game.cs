﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Game : Form
    {
        public Game(String text)
        {
            InitializeComponent();
            this.Text = text;
        }
    }
}
