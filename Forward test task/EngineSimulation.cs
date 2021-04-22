using System;

namespace Forward_test_task
{
    class EngineSimulation
    {
        #region Fields

        public float TempAmbient;                // Температура окружающей среды
        public float TempEngine;                 // Температура двигателя

        public readonly float I;                 // Момент инерции
        public readonly Pair<float, float>[] MV; // Кусочно-линейная зависимость крутящего момента M, вырабатываемого двигателем, от скорости вращения коленвала V
        public readonly float T;                 // Температура перегрева
        public readonly float Hm;                // Коэффициент зависимости скорости нагрева от крутящего момента
        public readonly float Hv;                // Коэфыфициент зависимости скорости нагрева от скорости вращения коленвала
        public readonly float C;                 // Коэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды

        public int gear = 0;

        #endregion



        #region Ctor

        public EngineSimulation(SourceData data)
        {
            I = data.I;
            MV = data.MV;
            T = data.T;
            Hm = data.Hm;
            Hv = data.Hv;
            C = data.C;
        }

        #endregion



        #region Methods

        public float a =>           // Ускорение
            MV[gear].FirstItem / I;

        public float Vh =>          // Скорость нагрева двигателя
            (float)(MV[gear].FirstItem * Hm + Math.Pow(MV[gear].SecondItem, 2) * Hv);

        public float Vc =>          // Скорость охлаждения двигателя
            C * (TempAmbient - TempEngine);

        #endregion
    }
}
