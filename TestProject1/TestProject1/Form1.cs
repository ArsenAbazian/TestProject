using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestProject1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            var colors = new Color[] { Color.Red, Color.Green, Color.LightBlue, Color.Orange, Color.Purple, Color.Gold };

            var itemsControl = new ItemsControl();

            int count = 100000;

            var rnd = new Random();
            for(int n = 0; n < count; n++) {
                int width = rnd.Next(50, 200);
                int height = rnd.Next(50, 200);
                var color = colors[n % colors.Length];
                itemsControl.Items.Add(new Item() { Size = new Size(width, height), Color = color });
            }

            itemsControl.Dock = DockStyle.Fill;
            itemsControl.Parent = this;
        }
    }
}
