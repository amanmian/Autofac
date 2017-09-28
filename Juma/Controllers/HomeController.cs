using System.Web.Mvc;

namespace CsharpAutofacDemo.Controllers
{
    /// <summary>
    /// MVC Controller class
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Private _container field
        /// </summary>
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: /Customer/

        /// <summary>
        /// Method for index action.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //@model AutofacDemo.Customer
            var customer = _customerRepository.GetCustomerDetails();

            // View Index.cshtml
            return View(customer);
        }


    }
}