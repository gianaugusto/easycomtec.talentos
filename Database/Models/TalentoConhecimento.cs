using System;

namespace Database.Models
{
    public class TalentoConhecimento: EntityBase
    {

        public TalentoConhecimento(
            Guid conhecimentoID, 
            Guid talentoID,
            NivelConhecimento nivel = NivelConhecimento.NaoConheco
                                  )
        {
            Id = new Guid();
            ConhecimentoID = conhecimentoID;
            TalentoID = talentoID;
            Nivel = nivel;
        }

        public TalentoConhecimento(
            Guid id,
            Guid conhecimentoID,
           Guid talentoID,
           NivelConhecimento nivel = NivelConhecimento.NaoConheco
                                 )
        {
            Id = id;
            ConhecimentoID = conhecimentoID;
            TalentoID = talentoID;
            Nivel = nivel;
        }

        public Guid TalentoID { get; private set; }

        public Guid ConhecimentoID { get; private set; }

        public NivelConhecimento Nivel{ get; private set; }

        public virtual Talento Talento { get; set; }

        public virtual Conhecimento Conhecimento { get; set; }

    }
}