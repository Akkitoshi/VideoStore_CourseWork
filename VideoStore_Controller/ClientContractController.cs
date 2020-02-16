using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_Controller
{
    public class ClientContractController
    {
        private VideoStoreDbContext context;

        public ClientContractController(VideoStoreDbContext context)
        {
            this.context = context;
        }

        // список всех договоров
        public List<ClientContractViewModel> GetList()
        {
            List<ClientContractViewModel> result = context.ClientContracts.Select(rec => new
           ClientContractViewModel
            {
                Id = rec.Id,
                ClientId = rec.ClientId,
                UserId = rec.UserId,
                ServiceId = rec.ServiceId,
                ProductId = rec.ProductId,
                ProductAmount = rec.ProductAmount,
                SummaryPrice = rec.SummaryPrice,
                DateOfConclusion = rec.DateOfConclusion,
                RentalPeriodEnd = rec.RentalPeriodEnd,
                ReturnDate = rec.ReturnDate
            })
            .ToList();
            return result;
        }
        // добавление нового договора
        public void AddElement(ClientContract model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    ClientContract element = context.ClientContracts.FirstOrDefault(rec =>
                   rec.Id == model.Id);
                    if (element != null)
                    {
                        throw new Exception("Договор с данным идентификатором уже существует");
                    }
                    element = new ClientContract
                    {
                        ClientId = model.ClientId,
                        UserId = model.UserId,
                        ServiceId = model.ServiceId,
                        ProductId = model.ProductId,
                        ProductAmount = model.ProductAmount,
                        SummaryPrice = model.SummaryPrice,
                        DateOfConclusion = model.DateOfConclusion,
                        RentalPeriodEnd = model.RentalPeriodEnd,
                        ReturnDate = model.ReturnDate
                    };
                    context.ClientContracts.Add(element);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        //поиск договора по номеру договора 
        public List<ClientContractViewModel> getByNumber(int number)
        {
            List<ClientContractViewModel> result = context.ClientContracts.Where(rec => rec.Id.Equals(number)).Select(rec => new
           ClientContractViewModel
            {
                Id = rec.Id,
                ClientId = rec.ClientId,
                UserId = rec.UserId,
                ServiceId = rec.ServiceId,
                ProductId = rec.ProductId,
                ProductAmount = rec.ProductAmount,
                SummaryPrice = rec.SummaryPrice,
                DateOfConclusion = rec.DateOfConclusion,
                RentalPeriodEnd = rec.RentalPeriodEnd,
                ReturnDate = rec.ReturnDate
            })
            .ToList();
            return result;
        }

        //поиск договора по ФИО клиента
        public List<ClientContractViewModel> getContractByFIO(string fio)
        {
            ClientCard element1 = context.ClientCards.FirstOrDefault(rec => rec.FIO == fio);
            if (element1 != null)
            {
                int ClientIdd = element1.Id;
                List<ClientContractViewModel> result = context.ClientContracts.Where(rec => rec.ClientId.Equals(ClientIdd)).Select(rec => new
             ClientContractViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    UserId = rec.UserId,
                    ServiceId = rec.ServiceId,
                    ProductId = rec.ProductId,
                    ProductAmount = rec.ProductAmount,
                    SummaryPrice = rec.SummaryPrice,
                    DateOfConclusion = rec.DateOfConclusion,
                    RentalPeriodEnd = rec.RentalPeriodEnd,
                    ReturnDate = rec.ReturnDate
                })
              .ToList();
                return result;
            }
            else
            {
                throw new Exception("Ошибка при поиске по ФИО клиента");
            }
        }
        //поиск действующих договоров
        public List<ClientContractViewModel> getByActive()
        {
            List<ClientContractViewModel> result = context.ClientContracts.Where(rec => rec.RentalPeriodEnd >= DateTime.Now && rec.ReturnDate == null).Select(rec => new
           ClientContractViewModel
            {
                Id = rec.Id,
                ClientId = rec.ClientId,
                UserId = rec.UserId,
                ServiceId = rec.ServiceId,
                ProductId = rec.ProductId,
                ProductAmount = rec.ProductAmount,
                SummaryPrice = rec.SummaryPrice,
                DateOfConclusion = rec.DateOfConclusion,
                RentalPeriodEnd = rec.RentalPeriodEnd,
                ReturnDate = rec.ReturnDate
            })
            .ToList();
            return result;
        }
        //поиск просроченных договоров
        public List<ClientContractViewModel> getByNoActive()
        {
            List<ClientContractViewModel> result = context.ClientContracts.Where(rec => rec.ReturnDate > rec.RentalPeriodEnd || rec.ReturnDate==null && rec.RentalPeriodEnd < DateTime.Now).Select(rec => new
           ClientContractViewModel
            {
                Id = rec.Id,
                ClientId = rec.ClientId,
                UserId = rec.UserId,
                ServiceId = rec.ServiceId,
                ProductId = rec.ProductId,
                ProductAmount = rec.ProductAmount,
                SummaryPrice = rec.SummaryPrice,
                DateOfConclusion = rec.DateOfConclusion,
                RentalPeriodEnd = rec.RentalPeriodEnd,
                ReturnDate = rec.ReturnDate
            })
            .ToList();
            return result;
        }

        //задать дату возврата
        public void UpdElement(DateTime returnDate, int id)
        {
            ClientContract element = context.ClientContracts.FirstOrDefault(rec => rec.Id ==
          id);
            if (element.ReturnDate == null)
            {
                element.ReturnDate = returnDate;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Дата возврата уже отмечена");
            }
        }
        //начислить обращение клиенту
        public void UpdFrequency(int frq, int clientId)
        {
            ClientCard element = context.ClientCards.FirstOrDefault(rec => rec.Id ==
          clientId);
                element.Frequency = element.Frequency+frq;
                context.SaveChanges();
        }

        // рассчитать сумму договора
        public int GetPrice(int id)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Id == id);
            int price = element.Price;
            return price;
        }
        //удалить контракт
        public void delElement(int id)
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
    }
}
