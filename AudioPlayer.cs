using System.Media;

class AudioPlayer (string path = @"wav1.wav")
{
    SoundPlayer soundPlayer = new(path);
    

    public void PlayAudio()
    {
        soundPlayer.PlayLooping();
    }
}