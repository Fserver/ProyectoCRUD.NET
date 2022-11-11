// See https://aka.ms/new-console-template for more information
using EntregaCRUD.Controladores;

int id, opcion = 0, opcArea = 0, opcEmpleado = 0, opcNomina = 0, idArea, idEmpleado;
decimal sueldo, diasLaborados;
string nombre, apellido, telefono, direccion;
DateTime fecha;

AreaController areaController = new AreaController();
EmpleadoController empleadoController = new EmpleadoController();
NominasController nominasController = new NominasController();
do
{
    Console.Clear();
    Console.WriteLine("Taller CRUD. En cualquier momento presiona 0 para salir de la ejecución");
    Console.WriteLine("Selecciona un item del Menú para realizar acciones:" +
    "\n1. Áreas \n2. Empleados \n3. Nómina");
    try
    {
        opcion = Convert.ToInt16(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                do
                {
                    Console.Clear();
                    Console.WriteLine("Taller CRUD. En cualquier momento presiona 0 para salir de la ejecución");
                    Console.WriteLine("Menú de Área" +
                    "\n1. Registar \n2. Ver  \n3. Modificar \n4. Eliminar");
                    opcArea = Convert.ToInt16(Console.ReadLine());
                    switch (opcArea)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Escriba el nombre del área a registrar");
                            string area = Console.ReadLine();
                            areaController.post(area);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Listado de registros");
                            areaController.get();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Escriba el id");
                            id = Convert.ToInt16(Console.ReadLine());
                            Console.Write($"Valor actual: ");
                            areaController.getById(id);
                            //AreaController.getById(id);
                            Console.WriteLine("Escriba el nuevo nombre");
                            nombre = Console.ReadLine();
                            areaController.put(id, nombre);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Escriba id a eliminar");
                            id = Convert.ToInt16(Console.ReadLine());
                            areaController.delete(id);
                            break;
                    }
                } while (opcArea != 0);

                break;
            case 2:
                do
                {
                    //Console.Clear();
                    Console.WriteLine("Taller CRUD. En cualquier momento presiona 0 para salir de la ejecución");
                    Console.WriteLine("Menú de Empleados" +
                    "\n1. Registar \n2. Ver  \n3. Modificar \n4. Eliminar");
                    opcEmpleado = Convert.ToInt16(Console.ReadLine());
                    switch (opcEmpleado)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Escriba el nombre del empleado a registrar");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Escriba el apellido");
                            apellido = Console.ReadLine();
                            Console.WriteLine("Escriba el telefono");
                            telefono = Console.ReadLine();
                            Console.WriteLine("Escriba la dirección");
                            direccion = Console.ReadLine();
                            Console.WriteLine("Escriba la fecha de ingreso");
                            fecha = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Escriba el Área del empleado");
                            idArea = Convert.ToInt16(Console.ReadLine());
                            empleadoController.post(nombre, apellido, direccion, telefono, fecha, idArea);

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Listado de registros");
                            empleadoController.get();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Escriba el id");
                            id = Convert.ToInt16(Console.ReadLine());
                            Console.Write($"Valor actual: ");
                            empleadoController.getById(id);
                            Console.WriteLine("Escriba el nombre del empleado a registrar");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Escriba el apellido");
                            apellido = Console.ReadLine();
                            Console.WriteLine("Escriba el telefono");
                            telefono = Console.ReadLine();
                            Console.WriteLine("Escriba la dirección");
                            direccion = Console.ReadLine();
                            Console.WriteLine("Escriba la fecha de ingreso");
                            fecha = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Escriba el Área del empleado");
                            idArea = Convert.ToInt16(Console.ReadLine());
                            empleadoController.put(id, nombre, apellido, direccion, telefono, fecha, idArea);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Escriba id a eliminar");
                            id = Convert.ToInt16(Console.ReadLine());
                            empleadoController.delete(id);
                            break;
                    }
                } while (opcEmpleado != 0);

                break;
            case 3:
                do
                {
                    Console.Clear();
                    Console.WriteLine("Taller CRUD. En cualquier momento presiona 0 para salir de la ejecución");
                    Console.WriteLine("Menú de Nómina" +
                    "\n1. Registar \n2. Ver  \n3. Modificar \n4. Eliminar");
                    opcNomina = Convert.ToInt16(Console.ReadLine());
                    switch (opcNomina)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Escriba la fecha de la nómina");
                            fecha = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Escriba el ID del Empleado");
                            idEmpleado = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Escriba el sueldo");
                            sueldo = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Escriba los días laborados");
                            diasLaborados = Convert.ToDecimal(Console.ReadLine());
                            nominasController.post(fecha, idEmpleado, sueldo, diasLaborados);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Listado de registros");
                            nominasController.get();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Escriba el id");
                            id = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Escriba la fecha de la nómina");
                            fecha = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Escriba el ID del Empleado");
                            idEmpleado = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Escriba el sueldo");
                            sueldo = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Escriba los días laborados");
                            diasLaborados = Convert.ToDecimal(Console.ReadLine());
                            nominasController.put(id, fecha, idEmpleado, sueldo, diasLaborados);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Escriba id a eliminar");
                            id = Convert.ToInt16(Console.ReadLine());
                            nominasController.delete(id);
                            break;
                    }
                } while (opcNomina != 0);

                break;
        }
    }
    catch (Exception e) { }
} while (opcion != 0);