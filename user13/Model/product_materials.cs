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
    
    public partial class product_materials
    {
        public int id { get; set; }
        public int product_type_id { get; set; }
        public int material_id { get; set; }
        public decimal count_material { get; set; }
    
        public virtual materials materials { get; set; }
        public virtual products products { get; set; }
    }
}
