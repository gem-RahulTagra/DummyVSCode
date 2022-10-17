using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.Threading;

namespace UiPath.Dummy.ActivityProject
{

    [Category("UiPathDummy.ActivitySet1")]
    public class Add : CodeActivity
    {
        [Category("Input")]
        [DisplayName("First Number")]
        [RequiredArgument]
        public InArgument<Int32> firstNo { get; set; }

        [Category("Input")]
        [DisplayName("Second Number")]
        [RequiredArgument]
        public InArgument<Int32> secondNo { get; set; }

        [Category("Input")]
        [DisplayName("Screenshot Flag")]
        [Description("Y or N")]
        [RequiredArgument]
        public InArgument<String> screenshotFlag { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var a = firstNo.Get(context);
            var b = secondNo.Get(context);
            var screenshot = screenshotFlag.Get(context);

            var c = a + b;
            Console.WriteLine(c.ToString());
            Thread.Sleep(2000);
            if (screenshot.Equals("Y"))
            {
                CaptureScreenshot.Capture("C:\\Users\\ra.tagra\\Desktop\\UI-Path\\DummyScreenshots\\ADD" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg");
            }

            //throw new NotImplementedException();
        }
    }

    [Category("UiPathDummy.ActivitySet1")]
    public class Subtract : CodeActivity
    {
        [Category("Input")]
        [DisplayName("First Number")]
        [RequiredArgument]
        public InArgument<Int32> firstNo { get; set; }

        [Category("Input")]
        [DisplayName("Second Number")]
        [RequiredArgument]
        public InArgument<Int32> secondNo { get; set; }

        [Category("Input")]
        [DisplayName("Screenshot Flag")]
        [Description("Y or N")]
        [RequiredArgument]
        public InArgument<String> screenshotFlag { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var a = firstNo.Get(context);
            var b = secondNo.Get(context);
            var screenshot = screenshotFlag.Get(context);

            var c = a + b;
            Console.WriteLine(c.ToString());
            Thread.Sleep(2000);
            if (screenshot.Equals("Y"))
            {
                CaptureScreenshot.Capture("C:\\Users\\ra.tagra\\Desktop\\UI-Path\\DummyScreenshots\\Subtract" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg");
            }

            //throw new NotImplementedException();
        }
    }

    [Category("UiPathDummy.ActivitySet2")]
    public class Multiply : CodeActivity
    {
        [Category("Input")]
        [DisplayName("First Number")]
        [RequiredArgument]
        public InArgument<Int32> firstNo { get; set; }

        [Category("Input")]
        [DisplayName("Second Number")]
        [RequiredArgument]
        public InArgument<Int32> secondNo { get; set; }

        [Category("Input")]
        [DisplayName("Screenshot Flag")]
        [Description("Y or N")]
        [RequiredArgument]
        public InArgument<String> screenshotFlag { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var a = firstNo.Get(context);
            var b = secondNo.Get(context);
            var screenshot = screenshotFlag.Get(context);

            var c = a + b;
            Console.WriteLine(c.ToString());
            Thread.Sleep(2000);
            if (screenshot.Equals("Y"))
            {
                CaptureScreenshot.Capture("C:\\Users\\ra.tagra\\Desktop\\UI-Path\\DummyScreenshots\\Multiply" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg");
            }

            //throw new NotImplementedException();
        }
    }

    [Category("UiPathDummy.ActivitySet2")]
    public class Divide : CodeActivity
    {
        [Category("Input")]
        [DisplayName("First Number")]
        [RequiredArgument]
        public InArgument<Int32> firstNo { get; set; }

        [Category("Input")]
        [DisplayName("Second Number")]
        [RequiredArgument]
        public InArgument<Int32> secondNo { get; set; }

        [Category("Input")]
        [DisplayName("Screenshot Flag")]
        [Description("Y or N")]
        [RequiredArgument]
        public InArgument<String> screenshotFlag { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var a = firstNo.Get(context);
            var b = secondNo.Get(context);
            var screenshot = screenshotFlag.Get(context);

            var c = a + b;

            Console.WriteLine(c.ToString());
            Thread.Sleep(2000);
            if (screenshot.Equals("Y"))
            {
                CaptureScreenshot.Capture("C:\\Users\\ra.tagra\\Desktop\\UI-Path\\DummyScreenshots\\Divide" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg");
            }

            //throw new NotImplementedException();
        }
    }

    [Category("UiPathDummy.ActivitySet3")]

    public class CaptureScreenshot : CodeActivity
    {
        public static void Capture(string CapturedFilePath)
        {
            Bitmap bitmap = new Bitmap
          (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            bitmap.Save(CapturedFilePath, ImageFormat.Jpeg);
        }
        protected override void Execute(CodeActivityContext context)
        {
            var filePath = "C:\\Users\\ra.tagra\\Desktop\\UI-Path\\Temporary.jpeg";

            Capture(filePath);

            // throw new NotImplementedException();
        }
    }
}
