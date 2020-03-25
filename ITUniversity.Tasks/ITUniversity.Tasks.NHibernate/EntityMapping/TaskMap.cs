using System;
using System.Collections.Generic;
using System.Text;
using ITUniversity.Tasks.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace ITUniversity.Tasks.NHibernate.EntityMapping
{
    public class TaskMap : ClassMapping<TaskBase>
    {
        public TaskMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Increment);
                x.Type(NHibernateUtil.Int64);
                x.Column("Id");
            });

            Property(b => b.Subject, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Property(b => b.Description, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Property(b => b.CreationDate, x =>
            {
                x.Type(NHibernateUtil.DateTime);
                x.NotNullable(true);

            });

            Property(b => b.Status, x =>
            {
                x.Type(NHibernateUtil.Int32);

            });

            Table(TaskBase.TableName);
        }
    }

}
