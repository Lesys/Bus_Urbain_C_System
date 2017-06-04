using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ApplicationBus
{
	public class Bus
	{
		#region Propriétés

		private int nbPlaces;
		private Mutex porteAvant;
		private Mutex porteArriere;
		private bool demandeArret;

		#endregion

		#region Constructeurs

		public Bus()
		{
		}

		#endregion

		#region Méthodes

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
		public Mutex getMutexPorteAvant()
		{
			return porteAvant;
		}
		public Mutex getMutexPorteArriere()
		{
			return porteArriere;
		}
		/*public void ControlerPassager()
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
		public void quitterArret()
		{
			//quitter
		}*/

		#endregion
	}
}