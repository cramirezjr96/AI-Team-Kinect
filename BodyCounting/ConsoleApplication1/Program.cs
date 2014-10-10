using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using Microsoft.Kinect.Face;
using Microsoft.Kinect.Fusion;
using Microsoft.Kinect.Tools;
using Microsoft.Kinect.VisualGestureBuilder;
using Microsoft.Kinect.Wpf.Controls;

namespace ConsoleApplication1
{
    class StartingTheKinect
    {

        static void Main(string[] args)
        {
            KinectSensor sensor = KinectSensor.GetDefault();
            
            sensor.Open();

            if (sensor.IsAvailable)
            {
                System.Console.WriteLine("It works!");
            }
            else
            {
                System.Console.WriteLine("It doesn't work!");
            }
            

            BodyFrameReader bodyReader = sensor.BodyFrameSource.OpenReader();
            bodyReader = sensor.BodyFrameSource.OpenReader();

            int i = sensor.BodyFrameSource.BodyCount;

            System.Console.WriteLine(i);

            Console.ReadLine();

            //FaceFrameFeatures faceFrameFeatures =
               // FaceFrameFeatures.Glasses;

        }
    }
}
