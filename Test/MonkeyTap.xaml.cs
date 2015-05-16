using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class MonkeyTap : ContentPage
    {
        BoxView[] boxes;
        Color[] clrs = { Color.Red, Color.Blue, Color.Yellow, Color.Green };
        const double lum_on = 0.75;
        const double lum_off = 0.4;
        int seq_index;
        int hit_index;
        int hit_count;
        List<int> seq_list = new List<int>();
        protected const int flash_time = 250;
        protected const int seq_time = 750;
        bool wait_tap;
        bool game_over;
        Random rand = new Random((int)DateTime.Now.Ticks);

        public MonkeyTap()
        {
            InitializeComponent();
            boxes = new[]{ box1, box2, box3, box4 };
            init_box();
        }

        protected void OnStartClicked(object sender, EventArgs e)
        {
            game_over = false;
            wait_tap = false;
            hit_count = 0;
            init_box();
            start_seq();
            btnStart.IsEnabled = false;
        }

        void init_box()
        {
            for (int i = 0; i < 4; i++)
            {
                boxes[i].Color = clrs[i].WithLuminosity(lum_off);
            }
        }

        void start_seq()
        {
            seq_list.Clear();
            seq_index = 0;
            hit_index = 0;
            hit_count++;
            wait_tap = false;
            for (int i = 0; i < hit_count; i++)
            {
                seq_list.Add(rand.Next(4));
            }
            Device.StartTimer(TimeSpan.FromMilliseconds(seq_time), () =>
                {
                    if (game_over)
                        return false;
                    blink_box(seq_list[seq_index]);
                    seq_index++;
                    if (seq_index >= hit_count)
                    {
                        hit_index = 0;
                        wait_tap = true;
                        return false;
                    }
                    return true;
                });
        }

        protected void OnBoxViewTapped(object sender, EventArgs e)
        {
            if (game_over)
                return;
            if (!wait_tap)
            {
                end_game();
                return;
            }
            var box = sender as BoxView;
            var index = Array.IndexOf<BoxView>(boxes, box);
            if (index != seq_list[hit_index])
            {
                end_game();
                return;
            }
            hit_index++;
            if (hit_index >= hit_count)
            {
                lblScore.Text = "得分：" + hit_count.ToString();
                start_seq();
            }
        }

        protected virtual void blink_box(int index)
        {
            boxes[index].Color = clrs[index].WithLuminosity(lum_on);
            Device.StartTimer(TimeSpan.FromMilliseconds(flash_time), () =>
                {
                    boxes[index].Color = clrs[index].WithLuminosity(lum_off);
                    return false;
                });
        }

        protected virtual void end_game()
        {
            game_over = true;
            for (int i = 0; i < 4; i++)
            {
                boxes[i].Color = Color.Gray;
            }
            btnStart.IsEnabled = true;
        }
    }
}

