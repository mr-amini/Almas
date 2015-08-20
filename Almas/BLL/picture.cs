using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;

namespace Almas.BLL
{
    class picture
    {
        DAL.DAC DA = new DAL.DAC();

        public bool InsertPicture(string code, Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] image_byte = ms.GetBuffer();
            return DA.insert_picture_2DB(code, image_byte);
        }

        public Image GettingPicture(string code)
        {
            DataTable res = DA.Do_Table(DA.Do_Sql_Adapter("select image from image where code='" + code + "'"));
            byte[] image = (byte[])(res.Rows[0]["image"]);
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);

        }
        public bool DeletePicture(string code)
        {
            int res = int.Parse(DA.Do_Command_Execute_None("delete from image where code='" + code + "'",false).ToString());
            return res == 1 ? true : false;
        }
    }
}
