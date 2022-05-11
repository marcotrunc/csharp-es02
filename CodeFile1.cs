namespace MyApp
{
    public static class calculator
    {
        public static int Sum(int iPrimoNumero, int iSecondoNumero)
        {
            int iSomma;
            iSomma = iPrimoNumero + iSecondoNumero;
            return iSomma;
        }
        public static int Sub(int iPrimoNumero, int iSecondoNumero)
        {
            int iSomma;
            iSomma = iPrimoNumero - iSecondoNumero;
            return iSomma;
        }
        public static int Moltiplicator(int iPrimoNumero, int iSecondoNumero)
        {
            int iRes;
            iRes = iPrimoNumero * iSecondoNumero;
            return iRes;
        }
        public static int Square(int iNum)
        {
            int iRes;
            iRes = iNum * iNum;
            return iRes;
        }
        public static double Division(double iPrimoNumero, double iSecondoNumero)
        {
            double iRes;
            iRes = iPrimoNumero / iSecondoNumero;
            return iRes;
        }
        public static int Exp(int iNum, int iExp)
        {
            int iRes = 1;
            for(int i = 0; i < iExp; i++)
            {
                iRes = iRes * iNum;
            }

            return iRes;
        }
        public static double Average(string[] sVect)
        {
            double dAvg = 0.0;
            int iEle = 0;
            foreach (string sNum in sVect)
            {
                double num = 0;
                if (double.TryParse(sNum, out num))
                {
                    dAvg += num;
                    iEle++;
                }
            }
            double med = 0.0; 
            return med = dAvg / iEle;
        }
    }
}