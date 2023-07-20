
namespace FitnessApp.Web.Infrastructure.ModelBinders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using System.Threading.Tasks;

    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
}
