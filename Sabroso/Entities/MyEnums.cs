using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sabroso
{
    public enum Categoria
    {
        [CustomAttribute(0, "-- Seleccione --")]
        Seleccione,
        [CustomAttribute(1, "Producto Terminado")]
        ProductoTerminado,
        [CustomAttribute(2, "Plato")]
        Plato,
        [CustomAttribute(3, "Jugo")]
        Jugo,
        [CustomAttribute(4, "Comida Rapida")]
        ComidaRapida,
        [CustomAttribute(5, "Insumo")]
        Insumo
    }

    public enum Status
    {
        [CustomAttribute(1, "Activo")]
        Activo,
        [CustomAttribute(2, "Inactivo")]
        Inactivo
        
    }

    public enum Actions
    {
        [CustomAttribute(1, "Nuevo")]
        New,
        [CustomAttribute(2, "Editar")]
        Edit,
        [CustomAttribute(3, "Cancelar")]
        Cancel,
        [CustomAttribute(4, "Guardar")]
        Save,
        [CustomAttribute(5, "Borrar")]
        Delete,
        [CustomAttribute(6, "Sin datos")]
        Neutro,
    }

    public enum BanderaGuardar
    {
        [CustomAttribute(1, "Nuevo")]
        New,
        [CustomAttribute(2, "Editar")]
        Edit,
        [CustomAttribute(3, "Lectura")]
        Read,
        [CustomAttribute(3, "Sin datos")]
        Zero
    }

    public enum Medida
    {
        [CustomAttribute(0, "-- Seleccione --")]
        Seleccione,
        [CustomAttribute(1, "Unidad")]
        Unidad,
        [CustomAttribute(2, "Docena")]
        Docena,
        [CustomAttribute(3, "SixPack")]
        SixPack,
        [CustomAttribute(4, "Paca de 8")]
        Paca8,
        [CustomAttribute(5, "Paca de 4")]
        Paca4,
        [CustomAttribute(7, "Caja")]
        Caja
    }

    public enum TipoEntidad
    {
        Producto,
        Proveedor,
        Cliente
    }

    public static class MyEnums
    {
        public static CustomAttribute GetFromEnum<T>(T t) where T : struct, IConvertible
        {
            MemberInfo memberInfo = typeof(T).GetMember(t.ToString()).FirstOrDefault();
            if (memberInfo != null)
            {
                CustomAttribute attribute = (CustomAttribute)
                    memberInfo.GetCustomAttributes(typeof(CustomAttribute), false).FirstOrDefault();
                return attribute;
            }
            return null;
        }

        public static Categoria GetFromAttribute(CustomAttribute attribute)
        {
            return Categoria.ProductoTerminado;
        }
    }

}
