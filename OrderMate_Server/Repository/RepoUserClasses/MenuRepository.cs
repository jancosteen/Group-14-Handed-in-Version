﻿using Contacts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.RepoUserClasses
{
    public class MenuRepository: RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(OrderMateDbFinalContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateMenu(Menu menu)
        {
            Create(menu);
        }

        public void DeleteMenu(Menu menu)
        {
            Delete(menu);
        }

        public IEnumerable<Menu> GetAllMenus()
        {
            return FindAll()
                .OrderBy(m => m.RestaurantIdFk)
                .ToList();
        }

        public Menu GetMenuById(int menuId)
        {
            return FindByCondition(m => m.MenuId.Equals(menuId))
                .FirstOrDefault();
        }

        public Menu GetMenuByResId(int resId)
        {
            return FindByCondition(m => m.RestaurantIdFk.Equals(resId))
                .Include(m => m.MenuItem).ThenInclude(m => m.MenuItemPrice)
                .FirstOrDefault();
        }

        public Menu GetMenuWithDetails(int menuId)
        {
            return FindByCondition(m => m.MenuId.Equals(menuId))
                .Include(m => m.RestaurantIdFkNavigation)
                .FirstOrDefault();
        }

        public void UpdateMenu(Menu menu)
        {
            Update(menu);
        }
    }
}
