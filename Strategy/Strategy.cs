using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    enum Peso
    {
        AbaixoPeso,
        PesoNormal,
        LigeiramenteAcimaPeso,
        AcimaPeso,
        Obeso
    }
    interface IStrategyPesoIdeal
    {
        Peso PesoIdeal(float peso, float altura);
    }

    class PesoIdealHomens : IStrategyPesoIdeal
    {
        public Peso PesoIdeal(float peso, float altura)
        {
            float imc = peso / (altura * altura);

            if (imc < 20.7)
                return Peso.AbaixoPeso;
            else if (imc < 26.4)
                return Peso.PesoNormal;
            else if (imc < 27.8)
                return Peso.LigeiramenteAcimaPeso;
            else if (imc < 31.1)
                return Peso.AcimaPeso;
            else
                return Peso.Obeso;
        }
    }
    class PesoIdealMulheres : IStrategyPesoIdeal
    {
        public Peso PesoIdeal(float peso, float altura)
        {
            float imc = peso/(altura*altura);

            if (imc < 19.1)
                return Peso.AbaixoPeso;
            else if (imc < 25.8)
                return Peso.PesoNormal;
            else if (imc < 27.3)
                return Peso.LigeiramenteAcimaPeso;
            else if (imc < 32.3)
                return Peso.AcimaPeso;
            else
                return Peso.Obeso;
        }
    }
}
