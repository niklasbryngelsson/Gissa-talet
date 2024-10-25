class AudioPlayer (string path = "Doom_Castle.wav")
{
    System.Media.SoundPlayer soundPlayer = new(path);

    public void PlayAudio()
    {
        soundPlayer.PlayLooping();
    }
}