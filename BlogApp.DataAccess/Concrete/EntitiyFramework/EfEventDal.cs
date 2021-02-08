﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks.Dataflow;
using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Configuration;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
    public class EfEventDal :  EfRepositoryBase<Event,BlogContext> , IEventDal
    {

      

        public Event GetByStringId(Expression<Func<Event, bool>> filter = null)
        {
            using var context = new BlogContext();
            {
                return context.Set<Event>().SingleOrDefault(filter);
            }
        }

        public List<EventCategoryDTO> GetEventCategory()
        {
            using (var context = new BlogContext())
            {

                var result = (from e in context.Events
                    join ev in context.EventCategories on e.EventCategoryId equals ev.Id 
                    select new EventCategoryDTO
                    {
                        Id = e.Id,
                        Title = e.Title,
                        Date = e.Date,
                        Color = e.Color,
                        Time = e.Time,
                        EventCategoryName = ev.Name
                    }).ToList();

                return result;
            }
            

        }

        public List<EventCategoryDTO> GetWeekEvent(DateTime currentdDate)
        {
            var onweeklater = currentdDate.AddDays(7);
            using (var context = new BlogContext())
            {


                var result = (from e in context.Events
                    join ec in context.EventCategories on e.EventCategoryId equals ec.Id
                    where e.Date.Day >= currentdDate.Day && e.Date.Day <= onweeklater.Day
                    select new EventCategoryDTO
                    {
                        Id = e.Id,
                        Date = e.Date,
                        Title = e.Title,
                        Color = e.Color,
                        EventCategoryName = ec.Name,
                        Time = e.Time
                    }).ToList();

                return result;
            }

        }


        //public List<Event> GetallEventCategory()
        //{
        //    using (var context = new BlogContext())
        //    {
        //        var result = context.Events.Include("EventCategory").Select(e => new Event
        //        {
        //            Id = e.Id, Date = e.Date, Color = e.Color, Time = e.Time, Title = e.Title,
        //            EventCategory = e.EventCategory
        //        }).ToList();
        //        return result;
        //    }
            
        //}
    }
}
