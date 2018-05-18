﻿using BeautySalonService.BindingModels;
using BeautySalonService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonService.Interfaces
{
   public interface IMainService
    {
        List<OrderViewModel> GetList();
        void TakeOrderInWork(int id);
        void FinishOrder(int id);
        void PayOrder(int id);
        void PutComponent(DeliveryResourceBindingModel model);
    }
}
