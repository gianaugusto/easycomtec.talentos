using System;
using Database.Models;

namespace WebApi.Model
{
    public class TalentoConhecimentoModel
    {
        public TalentoConhecimentoModel(Guid conhecimentoID, 
            Guid talentoID,
            NivelConhecimento nivel
                                  )
        {
            ConhecimentoID = conhecimentoID;
            TalentoID = talentoID;
            Nivel = nivel;
        }

    public Guid? TalentoID { get; private set; }

    public Guid ConhecimentoID { get; private set; }

    public NivelConhecimento Nivel { get; private set; }

    public virtual TalentoModel Talento { get; set; }

    public virtual ConhecimentoModel Conhecimento { get; set; }
    }
}