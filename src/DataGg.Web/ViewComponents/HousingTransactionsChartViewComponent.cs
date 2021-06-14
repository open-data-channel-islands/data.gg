﻿using DataGg.Core.Types;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.ViewComponents
{
    public class HousingTransactionsChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public HousingTransactionsChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new AreaChartViewModel() { TitleText = "Transactions", YAxisTitleText = "Transaction Count", Id = "chartTransactions" };

            var data = new List<AreaSeriesData>();
            model.Data = new List<Series>() { new AreaSeries { Name = "Guernsey", ShowInLegend = false, Data = data } };
            model.Labels = new List<string>();

            foreach (var qtr in dataCache.HouseLocalPrices.OrderBy(y => y.Year).ThenBy(y => y.Quarter))
            {
                if (!qtr.Transactions.HasValue)
                {
                    continue;
                }

                data.Add(new()
                {
                    Y = qtr.Transactions
                });

                model.Labels.Add($"{qtr.Quarter} {qtr.Year}");

            }

            return View(model);
        }
    }
}
