namespace HM_Migration
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VisitorContext : DbContext
    {
        // Контекст настроен для использования строки подключения "VisitorContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "HM_Migration.VisitorContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "VisitorContext" 
        // в файле конфигурации приложения.
        public VisitorContext()
            : base("name=VisitorContext")
        {
        }

        public DbSet<Visitor> Visitors { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}