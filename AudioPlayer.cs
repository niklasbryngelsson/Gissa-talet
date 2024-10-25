using System.Media;

class AudioPlayer (string path = @"E:\Brights\Gissa-Talet\Doom_Castle.wav")
{
    System.Media.SoundPlayer soundPlayer = new(path);
    

    public void PlayAudio()
    {
        soundPlayer.PlayLooping();
    }
}