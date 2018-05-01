using System;

namespace WebApi.Model
{
    public class TalentoConhecimentoModel
    {
        public TalentoConhecimentoModel(Guid conhecimentoID, 
                                        Guid talentoID,
                                        int nivel
                                  )
        {
            ConhecimentoID = conhecimentoID;
            TalentoID = talentoID;
            Nivel = nivel;
        }

        public Guid? Id { get; private set; }

        public Guid? TalentoID { get; private set; }

        public Guid ConhecimentoID { get; private set; }

        public int Nivel { get; private set; }

    }
}