using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_soria
{
    public class ProductoController
    {
        private readonly ProductoRepository _repo;
        private readonly ProductoView _view;

        public ProductoController(ProductoRepository repo, ProductoView view)
        {
            _repo = repo;
            _view = view;
        }

        public void Alta()
        {
            var producto = _view.CrearProducto();
            _repo.Agregar(producto);
            _view.MostrarMensaje("Producto agregado.");
        }

        public void Baja()
        {
            int id = _view.PedirId();
            _repo.Eliminar(id);
            _view.MostrarMensaje("Producto eliminado (si existía).");
        }

        public void Modificar()
        {
            int id = _view.PedirId();
            var producto = _repo.BuscarPorId(id);
            if (producto != null)
            {
                _view.EditarProducto(producto);
                _view.MostrarMensaje("Producto actualizado.");
            }
            else
            {
                _view.MostrarMensaje("Producto no encontrado.");
            }
        }

        public void Consultar()
        {
            var lista = _repo.ObtenerTodos();
            _view.MostrarProductos(lista);
        }

        public void Guardar()
        {
            _repo.Guardar();
        }
    }
}
