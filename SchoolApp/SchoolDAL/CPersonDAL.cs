using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolEntities;
using System.Data.Entity;

namespace SchoolDAL
{
    public class CPersonDAL
    {
        public List<CPerson> Listar()
        {
            using (SchoolEntities1 contexto = new SchoolEntities1())
            {
                var query = contexto.Person.Select( p => new CPerson
                {
                    PersonID = p.PersonID,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                });
                return query.ToList();
            }
        }

        public CPerson MostrarPersona(int ID)
        {
            using (SchoolEntities1 contexto = new SchoolEntities1())
            {
                var query = contexto.Person.Select(p => new CPerson
                {
                    PersonID = p.PersonID,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                }).Where(x => x.PersonID == ID).FirstOrDefault();
                return query;
            }
        }

        public int InsertarPersona(CPerson per)
        {
            using (SchoolEntities1 contexto = new SchoolEntities1())
            {
                try
                {
                    Person person = new Person();
                    person.PersonID = per.PersonID;
                    person.FirstName = per.FirstName;
                    person.LastName = per.LastName;
                    //person.HireDate = per.HireDate;
                    //person.EnrollmentDate = per.EnrollmentDate;
                    contexto.Person.Add(person);
                    int resultado = contexto.SaveChanges();
                    return resultado;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }

        public int ModificarPersona(CPerson per)
        {
            using (SchoolEntities1 contexto = new SchoolEntities1())
            {
                try
                {
                    var query = contexto.Person.Select(p => new CPerson
                    {
                        PersonID = p.PersonID,
                        LastName = p.LastName,
                        FirstName = p.FirstName
                    }).Where(x => x.PersonID == per.PersonID).First();

                    query.FirstName = per.FirstName;
                    query.LastName = per.LastName;
                    //query.HireDate = per.HireDate;
                    //query.EnrollmentDate = per.EnrollmentDate;

                    int resultado = contexto.SaveChanges();
                    Console.Write("Resultado: " + resultado);
                    return resultado;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }
    }
}
