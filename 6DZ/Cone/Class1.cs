namespace ConeSpace
{
    public class Cone
    {
        double h;
        double r;
        
         public Cone(double r,double h) 
        {
            this.r = r;
            this.h = h;
        }
        public double PloshadiOsnov()
        {
            return Math.Round(Math.PI * Math.Pow(r,2),3);
        }

        public double PloshadiPolnai()
        {
            double l = Math.Sqrt(Math.Pow(this.r, 2) + Math.Pow(this.h, 2));
            return Math.Round(Math.PI * r*l + Math.PI * Math.Pow(r, 2),3);
        }
    }
}
