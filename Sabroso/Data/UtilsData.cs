using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Sabroso
{
    public static class UtilsData
    {

        public static int SaveContext(ref Context context)
        {
            int count = 0;
            try
            {
                count = context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(ve.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return count;
                    }
                }
            }
            catch (Exception ex2)
            {
                string mensaje = GetMensajeError(ex2);
                MessageBox.Show(mensaje, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return count;
        }
        private static string GetMensajeError(Exception ex)
        {
            if (ex.InnerException != null)
            {
                return GetMensajeError(ex.InnerException);
            }
            return ex.Message;
        }

        public static int MaxId<T>() where T : Entity
        {
            int max = 0;
            try
            {
                using (Context context = new Context())
                {
                    max = context.Set<T>().Max(e => e.Id);
                }
            }
            catch { }
            return max;
        }

        public static T Get<T>(int id) where T : Entity
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Where(e => e.Id == id).FirstOrDefault();
            }
        }

    }
}
