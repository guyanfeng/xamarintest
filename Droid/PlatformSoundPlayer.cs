using Xamarin.Forms;
using Android.Media;

[assembly:Dependency(typeof(Test.Droid.PlatformSoundPlayer))]
namespace Test.Droid
{
    public class PlatformSoundPlayer : ISoundPlayer
    {
        AudioTrack audio;

        #region ISoundPlayer implementation

        public void PlaySound(int sampling_rate, byte[] pcm_data)
        {
            if (audio != null)
            {
                audio.Stop();
                audio.Release();
            }
            audio = new AudioTrack(Stream.Music, sampling_rate, ChannelOut.Mono, Encoding.Pcm16bit
                , pcm_data.Length * sizeof(short), AudioTrackMode.Static);
            audio.Write(pcm_data, 0, pcm_data.Length);
            audio.Play();
        }

        #endregion
    }
}

