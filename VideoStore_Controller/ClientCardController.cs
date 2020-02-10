using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_Controller
{
    public class ClientCardController
    {
        private VideoStoreDbContext context;

        public ClientCardController(VideoStoreDbContext context)
        {
            this.context = context;
        }

        // список всех клиентов
        public List<ClientCardViewModel> GetList()
        {
            List<ClientCardViewModel> result = context.ClientCards.Select(rec => new
           ClientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportNumber = rec.PassportNumber,
                Penalties = rec.Penalties,
                Frequency = rec.Frequency
            })
            .ToList();
            return result;
        }
        // добавление нового клиента
        public void AddElement(ClientCard model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    ClientCard element = context.ClientCards.FirstOrDefault(rec =>
                   rec.PassportNumber == model.PassportNumber);
                    if (element != null)
                    {
                        throw new Exception("Уже есть клиент с такими номером паспорта");
                    }
                    element = new ClientCard
                    {
                        FIO = model.FIO,
                        PassportNumber = model.PassportNumber,
                        Penalties = model.Penalties,
                        Frequency = model.Frequency
                    };
                    context.ClientCards.Add(element);
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

        //обновление данных о пени
        public void UpdElement(ClientCard model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    ClientCard element = context.ClientCards.FirstOrDefault(rec => rec.FIO ==
              model.FIO);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Penalties = model.Penalties;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        //поиск клиента по номеру паспорта 
        public List<ClientCardViewModel> getByPassportNumber(string numberOfPassport)
        {
            List<ClientCardViewModel> result = context.ClientCards.Where(rec => rec.PassportNumber.StartsWith(numberOfPassport)).Select(rec => new
           ClientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportNumber = rec.PassportNumber,
                Penalties = rec.Penalties,
                Frequency = rec.Frequency
            })
            .ToList();
            return result;
        }

        //поиск клиента по ФИО
        public List<ClientCardViewModel> getClientByFIO(string fio)
        {
            List<ClientCardViewModel> result = context.ClientCards.Where(rec => rec.FIO.StartsWith(fio)).Select(rec => new
             ClientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportNumber = rec.PassportNumber,
                Penalties = rec.Penalties,
                Frequency = rec.Frequency
            })
              .ToList();
            return result;
        }
        //выборка данных клиентов пени

        public List<ClientCardViewModel> getClientWithPenalties()
        {
            List<ClientCardViewModel> result = context.ClientCards.Where(rec => rec.Penalties == 0).Select(rec => new
             ClientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportNumber = rec.PassportNumber,
                Penalties = rec.Penalties,
                Frequency = rec.Frequency
            })
              .ToList();
            return result;
        }
        //выборка данных клиентов  пени
        public List<ClientCardViewModel> getClientWithoutPenalties()
        {
            List<ClientCardViewModel> result = context.ClientCards.Where(rec => rec.Penalties != 0).Select(rec => new
             ClientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportNumber = rec.PassportNumber,
                Penalties = rec.Penalties,
                Frequency = rec.Frequency
            })
              .ToList();
            return result;
        }

        //выборка данных клиентов с сортировкой по количеству обращений
        public List<ClientCardViewModel> getClientFrequency()
        {
            List<ClientCardViewModel> result = context.ClientCards.Select(rec => new
             ClientCardViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportNumber = rec.PassportNumber,
                Penalties = rec.Penalties,
                Frequency = rec.Frequency
            }).OrderByDescending(rec => rec.Frequency)
              .ToList();
            return result;
        }
    }
}
