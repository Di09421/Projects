using MVC4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MVC4
{
    public class Database
    {
        public int DataInsert(DBInsert data)
        {
            using (var DbContext = new MVCEntities())
            {
                var entityData = new Btpsmvc()
                {
                    Name = data.Name,
                    Age = data.Age,
                    Phone = data.Phone,

                };
                DbContext.Btpsmvcs.Add(entityData);
                int result = DbContext.SaveChanges();
                return result;
            }
        }

        public Btpsmvc Login(DBInsert data)
        {
            using (var DbContext = new MVCEntities())
            {
                var user = DbContext.Btpsmvcs.FirstOrDefault(u => u.Name == data.Name
                                                                && u.Phone == data.Phone
                                                                && u.Age == data.Age);
                return user;
            }
        }

        public List<Btpsmvc> SelectAllData()
        {
            using (var DbContext = new MVCEntities())
            {
                var data = DbContext.Btpsmvcs.ToList();
                return data;
            }
        }
        public Btpsmvc SelectData(int id)
        {
            using (var DbContext = new MVCEntities())
            {
                var data =DbContext.Btpsmvcs.Where(x => x.id == id).FirstOrDefault();
                return data;
            }
        }
        public int UpdateData(DBInsert userdata)
        {
            using(var DbContext =new MVCEntities())
            {
                var data = SelectData(userdata.id);
                if(data!=null)
                {
                    data.Name = userdata.Name;
                    data.Age = userdata.Age;
                    data.Phone = userdata.Phone;
                    DbContext.Btpsmvcs.AddOrUpdate(data);
                    int i = DbContext.SaveChanges();
                    return i;
                }
                return 0;
            }
        }
        public int DeleteData(int id)
        {
            using (var DbContext = new MVCEntities())
            {
                var data = DbContext.Btpsmvcs.Find(id);
                if (data != null)
                {
                    DbContext.Btpsmvcs.Remove(data);
                }
                else
                {
                    throw new InvalidOperationException("Entity not found");
                }
                return DbContext.SaveChanges();
            }
        }
    }
}
