using System;

public class ImageEncoder
{
    public Bitmap image;
    public string message;

	public ImageEncoder(Bitmap img, string msg)
	{
        image = img;
        message = msg;
	}

    public void ImgEncode()
    {
        Color currPixel = new Color();
        for(int i = 0; i < image.Width; i++)
        {
            for(int j = 0; j < image.Height; j++)
            {
                currPixel = image.GetPixel(i, j); 
            }
        }
    }

    public string ImgDecode()
    {



        return message;
    }
}
