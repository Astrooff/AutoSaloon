//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoSaloon
{
    using System;
    using System.Collections.Generic;
    
    public partial class DealSet
    {
        public int Id { get; set; }
        public int IdSupply { get; set; }
        public int IdDemand { get; set; }
    
        public virtual CarSet CarSet { get; set; }
        public virtual WorkersSet WorkersSet { get; set; }
    }
}