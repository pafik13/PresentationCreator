using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;


namespace WindowsFormsApplication1
{
    public class Presentation
    {
        public string name;
        public int imgIdx;
        public List<Part> parts;
    }

    public class Part
    {
        public string name;
        public int imgIdx;
        public List<MyBitMap> slides = new List<MyBitMap>();
    }

    public class MyBitMap
    {
        [XmlIgnoreAttribute()]
        public Bitmap Image;

        // Serializes the 'Picture' Bitmap to XML.
        [XmlElementAttribute("Picture")]
        public byte[] PictureByteArray
        {
            get
            {
                TypeConverter BitmapConverter = TypeDescriptor.GetConverter(Image.GetType());
                return (byte[])BitmapConverter.ConvertTo(Image, typeof(byte[]));
            }

            set
            {
                Image = new Bitmap(new MemoryStream(value));
            }
        }
    }
}
