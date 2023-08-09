services.AddDbContext<AddDbContext>(options=>
options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
