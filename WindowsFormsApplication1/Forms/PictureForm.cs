﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRECEClient.Forms
{
    public partial class PictureForm : Form
    {
        public PictureForm(Image image, string user)
        {
            InitializeComponent();
            Text = user;
            imagePictureBox.Image = image;
        }
    }
}
