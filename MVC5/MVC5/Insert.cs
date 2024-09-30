using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MVC5
{
    public class Insert
    {
        public string Img(string name, string imageName)
        {
            using (var imgContext = new MVCEntities()) 
            {
                var imgData = new Img() 
                {
                    Name = name,
                    ImageName = imageName 
                };

                imgContext.Imgs.Add(imgData);
                int result = imgContext.SaveChanges();

                return "result";
            }
        }
    }
    }