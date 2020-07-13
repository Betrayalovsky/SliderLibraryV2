using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bintod
{
    public partial class bintoD : UserControl
    {
        public object Integer { get; private set; }
        [Description("Ustawienie wartości maksymalnej suwaka"), Category("Komponent")]
        public string maxValue
        {
            get { return label2.Text; }
            set { MaximumValue = Int32.Parse(value);
                label2.Text = value;
            }
        }
        [Description("Ustawienie wartości minimalnej suwaka"), Category("Komponent")]
        public string minValue
        {
            get { return label3.Text; }
            set
            {
                MinimumValue = Int32.Parse(value);
                label3.Text = value;
            }
        }
        [Description("Zmiana koloru suwaka"), Category("Komponent")]
        public string colorSLider
        {
            get { return label4.Text; }
            set
            {
               
                label4.Text = value;
                picSlider.BackColor = Color.FromName(label4.Text);
            }
        }
        [Description("Zmiana koloru suwaka"), Category("Komponent")]
        public string colorSuwak
        {
            get { return label5.Text; }
            set
            {
                label5.Text = value;
            }
        }
        [Description("Zmiana koloru czcionki wyniku"), Category("Komponent")]
        public string colorText
        {
            get { return label6.Text; }
            set
            {
                label6.Text = value;
                lblResult.ForeColor = Color.FromName(label6.Text);
            }
        }


        public bintoD()
        {
            InitializeComponent();
            
        }
        
        private float SliderValue = 0.0f;

        
        int MinimumValue;
        int MaximumValue;

       
        private bool MouseIsDown = false;
        private void picSlider_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            SetValue(XtoValue(e.X));
        }
        private void picSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseIsDown) return;
            SetValue(XtoValue(e.X));
        }
        private void picSlider_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
            tipValue.Hide(this);

           
            lblResult.Text = SliderValue.ToString("0.00");
        }

        
        private float XtoValue(int x)
        {
            return MinimumValue + (MaximumValue - MinimumValue) *
                x / (float)(picSlider.ClientSize.Width - 1);
        }

        
        private float ValueToX(float value)
        {
            return (picSlider.ClientSize.Width - 1) *
                (value - MinimumValue) / (float)(MaximumValue - MinimumValue);
        }

        
        private void picSlider_Paint(object sender, PaintEventArgs e)
        {
            
            
            float x = ValueToX(SliderValue);

            
            using (Pen pen = new Pen(Color.FromName(label5.Text), 2))
            {
                
                e.Graphics.DrawLine(pen, x, 0,
                    x, picSlider.ClientSize.Height);
            }
        }

        
        private void SetValue(float value)
        {
            
            if (value < MinimumValue) value = MinimumValue;
            if (value > MaximumValue) value = MaximumValue;

            
            if (SliderValue == value) return;

            
            SliderValue = value;

            
            picSlider.Refresh();

            
            int tip_x = picSlider.Left + (int)ValueToX(SliderValue);
            int tip_y = picSlider.Top;
            tipValue.Show(SliderValue.ToString("0.00"), this, tip_x, tip_y, 3000);

            
            lblResult.Text = SliderValue.ToString("0.00");
        }

        
    }
}
