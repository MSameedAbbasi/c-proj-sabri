﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

class round : TextBox
{
    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                        //RADIUS, how round do you want it to be?
        int nheightRect, //height of ellipse 
        int nweightRect //width of ellipse
    );
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(4, 6, this.Width, this.Height, 25, 25)); //play with these values till you are happy
    }
}