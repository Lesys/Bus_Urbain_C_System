using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Bus
{
	public Bus()
	{
        private Random nbplaces;
        private Mutex porteAvant;
        private Mutex porteArriere;
        private boolean demandeArret;
        
    public int getNbPlaces()
        {
            return nbPlaces;
        }

    public void incNbPlaces()
        {
            Interlocked.Increment(ref nbPlaces);
        }

    public void decNbPlaces()
    {
        Interlocked.Decrement(ref nbPlaces);
    }
    public Mutex getMutexPA()
    {
        return PorteAvant;
    }
    public Mutex getMutexPA()
    {
        return porteArriere;
    }
    public ControlerPassager()
    {
        if (lePassager.getBillet() == true)
        {
            sleep(500);
        }
        else
        {
            sleep(2000);
            lePassager.nouveaubillet();
        }

        return 0;
    }
    public quitterArret()
    {
        //quitter
    }
}
}
