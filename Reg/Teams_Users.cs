//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reg
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teams_Users
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int team_id { get; set; }
    
        public virtual Teams Teams { get; set; }
        public virtual Users Users { get; set; }
    }
}
