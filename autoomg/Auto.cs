namespace autoomg
{
    public class Auto
    {
        private string znacka;
        private double spotreba=1;
        private int ujetoCelkem;
        private DateTime okamzikRozjezdu;
        private TimeSpan dobaJizdyCelkem;
        private bool jede;
        private double spotrebacelkem;

        public Auto(string znacka, int spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            jede= false;
        }

        public bool Jede
        {
            get
            {
               
                return jede;
            }
        }
        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }
        public void Rozjezd()
        {
            jede = true;
            okamzikRozjezdu = DateTime.Now;
        }
        public void Zastav(int km)
        {
            jede = false;
            ujetoCelkem = ujetoCelkem + km;
            dobaJizdyCelkem = dobaJizdyCelkem +(DateTime.Now - okamzikRozjezdu);

        }
        public double CelkovaSpotreba()
        {
            spotrebacelkem = (spotreba/100) * ujetoCelkem;
            return spotrebacelkem;
        }

        public override string ToString()
        {
            return "Auto se značkou: " + znacka + "\nSpotřebou za: "+ujetoCelkem+"km " + spotrebacelkem + "\nCelkovou ujetou vzdaleností: " + ujetoCelkem + "\nCelkovou dobou jízdy: " + Math.Round(Convert.ToDouble(dobaJizdyCelkem.TotalSeconds), 1) + "s\nAuto Jede? "+ Jede;
        }
    }
}
