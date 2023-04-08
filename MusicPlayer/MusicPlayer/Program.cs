namespace MusicPlayer
{
    internal class Program
    {
        static void NamePrint(string name)
        {
            Console.WriteLine($"{name}");
        }
        static void Main(string[] args)
        {
            Music.ChangeStatusEvent += NamePrint;

            Music music = new Music();
            AudioFile audioFile = new Music();
            AudioFile audioFile2 = new Music();

            audioFile2.name = "Music2";

            music.Play(audioFile);
            music.AddMusic(audioFile2);
            music.Stop(audioFile);
            music.Play(audioFile2);
            music.Stop(audioFile2);
        }
    }
}