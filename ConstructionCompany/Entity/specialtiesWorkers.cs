//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructionCompany.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class specialtiesWorkers
    {
        public int idWorker { get; set; }
        public int idSpecialty { get; set; }
        public string @null { get; set; }
    
        public virtual Specialty Specialty { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
