
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace VisualOS.DAL
{

using System;
    using System.Collections.Generic;
    
public partial class tb_cargo
{

    public tb_cargo()
    {

        this.rl_cargo_usuario = new HashSet<rl_cargo_usuario>();

    }


    public int ID { get; set; }

    public string Nome { get; set; }

    public string Descricao { get; set; }



    public virtual ICollection<rl_cargo_usuario> rl_cargo_usuario { get; set; }

}

}
