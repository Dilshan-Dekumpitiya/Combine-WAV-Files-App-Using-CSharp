using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineWavFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader1 = new AudioFileReader("D:\\your-location\\7.wav");
            var reader2 = new AudioFileReader("D:\\your-location\\hundred.wav");
            var reader3 = new AudioFileReader("D:\\your-location\\55.wav");
            var reader4 = new AudioFileReader("D:\\your-location\\and.wav");
            var reader5 = new AudioFileReader("D:\\your-location\\80.wav");
            var reader6 = new AudioFileReader("D:\\your-location\\cents.wav");
            
            var playlist = new ConcatenatingSampleProvider(new[] { reader1,reader2,reader3,reader4,reader5,reader6});

            WaveFileWriter.CreateWaveFile16("D:\\your-location\\mixed.wav", playlist);
            
        }
    }
}
