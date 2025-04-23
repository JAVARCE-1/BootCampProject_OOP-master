using InventoryManagement.Modelos;

namespace InventoryManagement;

public class SistemaInventario // Heredar esa interfaz para sobrescribir esos metodos
{
    private List<TipoEmpleado> _tiposEmpleados = new List<TipoEmpleado>();
    private List<Empleado> _empleados = new List<Empleado>();
    private List<Producto> _productos = new List<Producto>();
    private List<MovimientoStock> _movimientos = new List<MovimientoStock>();
    private List<CategoriaProducto> _categoriaProducto = new List<CategoriaProducto>();
    
    // Metodo para agregar un tipo empleado
    public void AgregarTipoEmpleado(TipoEmpleado tipoEmpleado)
    {
        _tiposEmpleados.Add(tipoEmpleado);
    }
    
    // Metodo para listar todos los tipos de empleados
    public List<TipoEmpleado> ObtenerTipoEmpleados()
    {
        return _tiposEmpleados.ToList();
    }
    
    // Metodo para obtener un solo empleado y quiero que sea por Id
    public TipoEmpleado ObtenerTipoEmpleadoPorId(int id)
    {
        return _tiposEmpleados.FirstOrDefault(t => t.Id == id);
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        _empleados.Add(empleado);
    }

    public List<Empleado> ObtenerEmpleados()
    {
        return _empleados.ToList();
    }
    
    public Empleado ObtenerEmpleadoPorId(int id)
    {
        return _empleados.FirstOrDefault(t => t.Id == id);
    }

    // Agregar el resto de metodos
    public void AgregarProducto(Producto producto)
    {
        _productos.Add(producto);
    }
    public List<Producto> ObtenerProductos()
    {
        return _productos.ToList();
    }
    public Producto ObtenerProductoPorId(int id)
    {
        return _productos.FirstOrDefault(t => t.Id == id);
    }

    public List<CategoriaProducto> ObtenerCategoriaProductos()
    {
        return _categoriaProducto.ToList();
    }

}