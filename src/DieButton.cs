using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceKeeper
{
    class DieButton
    {
        public enum ImageResource
        {
            D4, D6, D8, D10, D12, D20, D100, DCUSTOM
        };
        public static Dictionary<ImageResource, Bitmap> images = new Dictionary<ImageResource, Bitmap>()
        {
            { ImageResource.D4,         global::DiceKeeper.Properties.Resources.d4 },
            { ImageResource.D6,         global::DiceKeeper.Properties.Resources.d6 },
            { ImageResource.D8,         global::DiceKeeper.Properties.Resources.d8 },
            { ImageResource.D10,        global::DiceKeeper.Properties.Resources.d10 },
            { ImageResource.D12,        global::DiceKeeper.Properties.Resources.d12 },
            { ImageResource.D20,        global::DiceKeeper.Properties.Resources.d20 },
            { ImageResource.D100,       global::DiceKeeper.Properties.Resources.d100 },
            { ImageResource.DCUSTOM,    global::DiceKeeper.Properties.Resources.dCustom },
        };
        private static int imageSize = 40;

        public Button button;
        public bool pooled = false;

        private Button template;
        private FlowLayoutPanel parent;
        private ImageResource imageResource;

        public string ID { get; private set; }
        public Die Die { get; private set; }

        public EventHandler OnClick;
        public MouseEventHandler OnMouseDown;

        public DieButton (Button template, FlowLayoutPanel parent, Die die, EventHandler OnClick, MouseEventHandler OnMouseDown)
        {
            this.template = template;
            this.parent = parent;
            imageResource = DieToImageResource(die);
            Die = die;

            button = CreateDiceButton();
            parent.Controls.Add(button);
            button.Click += Click;
            button.MouseDown += MouseDown;
            this.OnClick = OnClick;
            this.OnMouseDown = OnMouseDown;

            ID = Guid.NewGuid().ToString();
        }

        private ImageResource DieToImageResource(Die die)
        {
            if (die.Sides == 4)
            {
                return ImageResource.D4;
            }
            else if (die.Sides == 6)
            {
                return ImageResource.D6;
            }
            else if (die.Sides == 8)
            {
                return ImageResource.D8;
            }
            else if (die.Sides == 10)
            {
                return ImageResource.D10;
            }
            else if (die.Sides == 12)
            {
                return ImageResource.D12;
            }
            else if (die.Sides == 20)
            {
                return ImageResource.D20;
            }
            else if (die.Sides == 100)
            {
                return ImageResource.D100;
            }
            else
            {
                return ImageResource.DCUSTOM;
            }
        }

        private Button CreateDiceButton()
        {
            Button diceButton = new Button();
            diceButton.Height = template.Height;
            diceButton.Width = template.Width;
            diceButton.Margin = template.Margin;
            diceButton.BackColor = template.BackColor;
            diceButton.ForeColor = template.ForeColor;
            diceButton.Font = template.Font;
            diceButton.FlatStyle = template.FlatStyle;
            diceButton.FlatAppearance.BorderColor = template.FlatAppearance.BorderColor;
            diceButton.FlatAppearance.BorderSize = template.FlatAppearance.BorderSize;
            diceButton.FlatAppearance.MouseDownBackColor = template.FlatAppearance.MouseOverBackColor;
            diceButton.FlatAppearance.MouseDownBackColor = template.FlatAppearance.MouseDownBackColor;
            Bitmap image = new Bitmap(images[imageResource]);
            Bitmap resizedImage = new Bitmap(image, new Size(imageSize, imageSize));
            diceButton.Image = resizedImage;
            diceButton.ImageAlign = template.ImageAlign;
            diceButton.Padding = template.Padding;
            diceButton.TextAlign = template.TextAlign;
            diceButton.Font = template.Font;
            diceButton.Parent = parent;
            diceButton.Text = Die.CustomName == "" || Die.CustomName == null ? Die.Label : Die.CustomName;
            diceButton.ContextMenuStrip = template.ContextMenuStrip;

            return diceButton;
        }

        private void Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(this, e);
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown?.Invoke(this, e);
        }
    }
}
