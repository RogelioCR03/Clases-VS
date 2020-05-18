using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        private Button miBoton;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Figuras";

            this.miBoton = new System.Windows.Forms.Button();
            this.miBoton.Location = new System.Drawing.Point(254, 272);
            this.miBoton.Name = "button2";
            this.miBoton.Size = new System.Drawing.Size(75, 23);
            this.miBoton.TabIndex = 1;
            this.miBoton.Text = "button2";
            this.miBoton.UseVisualStyleBackColor = true;
            this.Controls.Add(this.miBoton);
        }
    }
}
