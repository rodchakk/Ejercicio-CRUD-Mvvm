

using CommunityToolkit.Mvvm.ComponentModel;
using CRUDProducto.Models;
using CRUDProducto.Services;
using System.Collections.ObjectModel;

namespace CRUDProducto.ViewModels
{
    public partial class ProductoMainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Producto> productoCollection = new ObservableCollection<Producto>();

        private readonly ProductoService productoService;

        public ProductoMainViewModel()
        {
            productoService = new ProductoService();
        }
    }
}
