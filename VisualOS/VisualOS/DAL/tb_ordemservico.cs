
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
    
public partial class tb_ordemservico
{

    public tb_ordemservico()
    {

        this.rl_agenda = new HashSet<rl_agenda>();

        this.rl_servico_os = new HashSet<rl_servico_os>();

    }


    public int ID { get; set; }

    public int ID_Usuario_Responsavel { get; set; }

    public System.DateTime Data_abertura { get; set; }

    public System.DateTime Data_conclusao { get; set; }

    public string Tipo_OS { get; set; }



    public virtual ICollection<rl_agenda> rl_agenda { get; set; }

    public virtual ICollection<rl_servico_os> rl_servico_os { get; set; }

    public virtual tb_usuario tb_usuario { get; set; }

}

}