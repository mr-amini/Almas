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
        DAL.DAC _DA = new DAL.DAC();

        public bool InsertPicture(string code, Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] image_byte = ms.GetBuffer();
            return _DA.insert_picture_2DB(code, image_byte);
        }

        public Image GettingPicture(string code)
        {
            
            if (_DA.Do_Command_Execute_Scaler("SELECT COUNT(code) FROM image WHERE code='" + code + "'").ToString() == "1")
            {
                DataTable res = _DA.Do_Table(_DA.Do_Sql_Adapter("select image from image where code='" + code + "'"));
                byte[] image = (byte[])(res.Rows[0]["image"]);
                MemoryStream ms = new MemoryStream(image);
                return Image.FromStream(ms);
            }
            else
            {
                return null;
            }
            
        }
        public bool DeletePicture(string code)
        {
            int res = int.Parse(_DA.Do_Command_Execute_None("delete from image where code='" + code + "'",false).ToString());
            return res == 1 ? true : false;
        }
    }
}
