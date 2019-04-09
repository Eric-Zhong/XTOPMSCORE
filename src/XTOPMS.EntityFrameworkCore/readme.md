# 查看数据库上下文
``` shell
dotnet ef dbcontext info
```


# 清理数据库
``` shell
dotnet ef database drop
```

# 更新数据库
``` shell
dotnet ef database update
```

# 更新数据库
``` shell
dotnet ef database update
```

# 查看Migration列表
``` shell
dotnet ef migrations list
```

# 创建Migration
``` shell
dotnet ef migrations add <Name>
```


# 删除Migration
``` shell
dotnet ef migrations remove <Name>
```

# 执行ABP中的SEED
通过命令行执行完数据库创建之后，只要运行（F5）这套程序之后，Seed 中定义的初始化的数据，就会创建到数据库中。  
用这个方法，可以初始化好系统运行所需要的必要数据。


# 参考资料
有关命令行的操作，可以参考这里的描述：
https://blog.csdn.net/sd7o95o/article/details/78771269  
  
