//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace user13.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class materials
    {
        public materials()
        {
            this.product_materials = new HashSet<product_materials>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int material_type_id { get; set; }
        public decimal price_unit { get; set; }
        public decimal count_in_storage { get; set; }
        public decimal min_count { get; set; }
        public int count_in_box { get; set; }
        public int unit_type_id { get; set; }
    
        public virtual material_type material_type { get; set; }
        public virtual unit unit { get; set; }
        public virtual ICollection<product_materials> product_materials { get; set; }
    }
}
