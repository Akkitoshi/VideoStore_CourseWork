using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using VideoStore_Model;

namespace VideoStore_Controller
{
    public class ArchieveController
    {
        private VideoDbContext context;
        public ArchieveController(VideoDbContext context)
        {
            this.context = context;
        }

        //удаление договора из БД
        public void delElementClientContract(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    ClientContract element = context.ClientContracts.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.ClientContracts.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        //сохранение удаленного договора в Json файл
        public async Task SaveToJsonAsyncClientContract(string fileName)
        {
            DataContractJsonSerializer formatterPeople = new DataContractJsonSerializer(typeof(List<ClientContract>));
            MemoryStream msClient = new MemoryStream();
            formatterPeople.WriteObject(msClient, await context.ClientContracts.ToListAsync());
            msClient.Position = 0;
            StreamReader srArch = new StreamReader(msClient);
            string historyJSON = srArch.ReadToEnd();
            srArch.Close();
            msClient.Close();

            File.WriteAllText(fileName, "{\n" +
                "    \"ClientContract\": " + historyJSON + ",\n" +
                "}");
        }

        //удаление клиента из БД
        public void delElementClient(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    ClientCard element = context.ClientCards.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        context.ClientCards.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        //сохранение удаленного элемента в Json файл
        public async Task SaveToJsonAsyncClient(string fileName)
        {
            DataContractJsonSerializer formatterPeople = new DataContractJsonSerializer(typeof(List<ClientCard>));
            MemoryStream msClient = new MemoryStream();
            formatterPeople.WriteObject(msClient, await context.ClientCards.ToListAsync());
            msClient.Position = 0;
            StreamReader srArch = new StreamReader(msClient);
            string historyJSON = srArch.ReadToEnd();
            srArch.Close();
            msClient.Close();

            File.WriteAllText(fileName, "{\n" +
                "    \"ClientCard\": " + historyJSON + ",\n" +
                "}");
        }
    }
}
