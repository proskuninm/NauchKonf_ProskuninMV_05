//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NauchKonf_ProskuninMV_05
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderuserlist
    {
        public int orderuserlistid { get; set; }
        public int userid { get; set; }
        public int orderid { get; set; }
    
        public virtual order order { get; set; }
        public virtual user user { get; set; }
    }
}