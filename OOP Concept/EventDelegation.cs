

//Creating Event Trigger Class

using System;
public class Upload_Video_EventArgs : EventArgs
{
    public string newVideo;
    public double duration;
    public Upload_Video_EventArgs(string v, double d)
    {
        this.newVideo = v;
        this.duration = d;
    }
}

public class Publisher
{
    public delegate void video_upload_handler(object o, Upload_Video_EventArgs e);
    public video_upload_handler onUploadTrigger;
    public string name;
    private string _video;
    public string video
    {
        get
        {
            return _video;
        }

        set
        {
            if(_video != value)
            {
                _video = value;
                onVideoUpload(new Upload_Video_EventArgs(value, duration));
            }
        }
    }

    public double duration;

    public Publisher(string n, string v, double d)
    {
        this.name = n;
        this._video = v;
        this.duration = d;
    }

    public void onVideoUpload(Upload_Video_EventArgs e)
    {
        onUploadTrigger?.Invoke(this, e);
    }
}


class Subscriber
{
    public string name;

    public Subscriber(string n)
    {
        this.name = n;
    }
    public void notification(object o, Upload_Video_EventArgs e)
    {
        Console.WriteLine($"New Video: '{e.newVideo}' is Uploaded by The Youtuber.");
    }
}

class Event
{
    public static void Main()
    {
        Publisher ytube = new Publisher("Abhiraj","30 days coding", 12.00);
        Subscriber s1 = new Subscriber("Raj");
        Subscriber s2 = new Subscriber("Sartaj");
        ytube.onUploadTrigger+=s1.notification;
        ytube.onUploadTrigger+=s2.notification;
        ytube.video = "Average Coding";


        // New Video: 'Average Coding' is Uploaded by The Youtuber.
        // New Video: 'Average Coding' is Uploaded by The Youtuber.
    }
}