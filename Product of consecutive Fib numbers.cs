public class ProdFib {
      public static ulong[] productFib(ulong prod) 
      {
          ulong Fn=0,Fnn = 1;
          while (Fn*Fnn<prod)
          {
            Fnn+=Fn;
            Fn=Fnn-Fn;
          }
        if (Fn*Fnn == prod) return new ulong[] {Fn,Fnn,1};
        return new ulong[] {Fn,Fnn,0};
      }
}
