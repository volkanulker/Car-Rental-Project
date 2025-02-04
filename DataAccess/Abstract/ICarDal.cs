﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDetailsWithImageDto> GetCarDetailsWithImage(int carId);
        List<CarDetailDto> GetFilteredCars(int brandId, int colorId, int minDailyPrice, int maxDailyPrice);

        List<CarCardDto> GetFilteredCarCards(int brandId, int colorId, int minDailyPrice, int maxDailyPrice);

        List<CarCardDto> GetCarCards();

    }
}
