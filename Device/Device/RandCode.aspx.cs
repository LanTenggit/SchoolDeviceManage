using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Device
{
    public partial class RandCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CreateCheckCodeImage(GenerateCheckCode(4, false));
        }
        //产生随机数
        private string GenerateCheckCode(int codeCount, bool isSaveCookies)
        {

            int number;

            char code;

            string checkCode = String.Empty;

            System.Random randdom = new Random();

            for (int i = 0; i < codeCount; i++)
            {

                number = randdom.Next();

                if (number % 2 == 0)

                    code = (char)('0' + (char)(number % 10));

                else

                    code = (char)('A' + (char)(number % 26));

                checkCode += code.ToString();

            }

            //if (isSaveCookies)
            //{

            //    Response.Cookies.Add(new HttpCookie("CheckCode", checkCode));
            //    Session["CheckCode"] = checkCode;
            //}

            //else
            //{

            //    Page.Session.Contents["CheckCode"] = checkCode;

            //}
            Session["CheckCode"] = checkCode;
            return checkCode;

        }


        //创建背景
        private void CreateCheckCodeImage(string checkCode)
        {

            if (checkCode == null || checkCode.Trim() == string.Empty)

                return;

            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 12.5)), 22);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image);
            try
            {
                Random random = new Random();
                g.Clear(System.Drawing.Color.White);
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);

                    int x2 = random.Next(image.Width);

                    int y1 = random.Next(image.Height);

                    int y2 = random.Next(image.Height);

                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Silver), x1, y1, x2, y2);
                }
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic));

                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 0, image.Width, image.Height), System.Drawing.Color.Blue, System.Drawing.Color.DarkRed, 1.2f, true);

                g.DrawString(checkCode, font, brush, 2, 2);

                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);

                    int y = random.Next(image.Height);

                    image.SetPixel(x, y, System.Drawing.Color.FromArgb(random.Next()));

                }
                g.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                Response.ClearContent();
                Response.ContentType = "image/Gif";
                Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
    }
}