import gab.opencv.*;
import processing.video.*;
import java.awt.*;
import hypermedia.net.*;

Capture video;
OpenCV opencv;
UDP udp;

String message = "Sun";
String ip ="127.0.0.1";
int port = 6100;
float x =10.1;
float y = 20.2;

void setup()
{
  size(640,480);
  video = new Capture(this,width/2,height/2);
  opencv = new OpenCV(this,width/2,height/2);
  
  opencv.loadCascade(OpenCV.CASCADE_FRONTALFACE);
  
  video.start();
  
  udp = new UDP(this,6000);
  udp.listen(true);
  

}

void draw()
{

  udp.send(message,ip,port);
  
  scale(2);
  opencv.loadImage(video);
  image(video,0,0);
  
  Rectangle[] faces = opencv.detect();
  println(faces.length);
 
  noFill();
  stroke(0,255,0);
  for(int i=0;i<faces.length;i++){
  
      rect(faces[i].x,faces[i].y,
        faces[i].width,faces[i].height);
        
        message = faces[i].x+" "+faces[i].y+" ";
  }
  
}

void captureEvent(Capture c)
{
  c.read();
}
