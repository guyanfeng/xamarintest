using System;

namespace Test
{
    public class MonkeyTapWithSound : MonkeyTap
    {
        const int error_duration = 500;
        // Diminished 7th in 1st inversion: C, Eb, F#, A
        double[] frequencies = { 523.25, 622.25, 739.99, 880 };

        protected override void blink_box(int index)
        {
            SoundPlayer.PlaySound(frequencies[index], flash_time);
            base.blink_box(index);
        }

        protected override void end_game()
        {
            SoundPlayer.PlaySound(200.4, error_duration);
            base.end_game();
        }
    }
}

