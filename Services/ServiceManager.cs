using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;
        private readonly IAuthService  _authSevice;

        public ServiceManager(IProductService productService, ICategoryService categoryService, IOrderService orderService, IAuthService authSevice)
        {
            _productService = productService;
            _categoryService = categoryService;
            _orderService = orderService;
            _authSevice = authSevice;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        public IOrderService OrderService => _orderService;

        public IAuthService AuthService => _authSevice;
    }
}