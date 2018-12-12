https://blog.csdn.net/sd7o95o/article/details/78771269

迁移命令描述  CMD命令   PMC命令
创建迁移：migrationname为迁移名称 dotnet ef migrations add migrationname  add-migration migrationname
移除迁移(删除最近的一次迁移) dotnet ef migrations remove remove-migration
应用最新的迁移(使迁移文件应用到数据库)    dotnet ef database update   update-database
应用指定的迁移 dotnet ef database update migrationname update-database migrationname
查看迁移列表  dotnet ef migrations list   
查看数据库上下文信息  dotnet ef dbcontext info



>dotnet ef migrations add <Name>
