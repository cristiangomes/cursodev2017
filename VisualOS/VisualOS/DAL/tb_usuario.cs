
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
    
public partial class tb_usuario
{

    public tb_usuario()
    {

        this.tb_ordemservico = new HashSet<tb_ordemservico>();

        this.rl_agenda = new HashSet<rl_agenda>();

        this.rl_cargo_usuario = new HashSet<rl_cargo_usuario>();

        this.rl_servico_os = new HashSet<rl_servico_os>();

    }


    public int ID { get; set; }

    public int CPF { get; set; }

    public System.DateTime DataNascimento { get; set; }

    public int DDD { get; set; }

    public string Email { get; set; }

    public string NomeCompleto { get; set; }

    public string Senha { get; set; }

    public int Telefone { get; set; }



    public virtual ICollection<tb_ordemservico> tb_ordemservico { get; set; }

    public virtual ICollection<rl_agenda> rl_agenda { get; set; }

    public virtual ICollection<rl_cargo_usuario> rl_cargo_usuario { get; set; }

    public virtual ICollection<rl_servico_os> rl_servico_os { get; set; }

}

}
