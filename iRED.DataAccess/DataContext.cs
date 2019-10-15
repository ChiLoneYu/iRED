﻿using iRED.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WalkingTec.Mvvm.Core;

namespace iRED.DataAccess
{
    public class DataContext : FrameworkContext
    {
        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }
        public DbSet<WeiXinUser> WeiXinUser { get; set; }
    }

    /// <summary>
    /// 为EF的Migration准备的辅助类，填写完整连接字符串和数据库类型
    /// 就可以使用Add-Migration和Update-Database了
    /// </summary>
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            return new DataContext("Server=.;Database=iRED_dev;UID=sa;PWD=123456;", DBTypeEnum.SqlServer);
        }
    }

}
