using System;

namespace Test
{
    public interface ISoundPlayer
    {
        void PlaySound(int sampling_rate, byte[] pcm_data);
    }
}

