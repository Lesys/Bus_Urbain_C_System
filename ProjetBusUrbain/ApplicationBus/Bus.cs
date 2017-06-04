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
		private bool demandeArret;
		private Semaphore porteAvant;
		private Semaphore porteArriere;

		#endregion

		#region Constructeurs

		// Constructeur par défaut sans paramètre
		public Bus()
		{
			Random rand = new Random();
			this.nbPlaces = rand.Next(25, 31);
			this.demandeArret = false;
			this.porteAvant = new Semaphore(1, 1);
			this.porteArriere = new Semaphore(2, 2);
		}

		// Constructeur avec le nombre de place en saisie
		public Bus(int nbPlaces)
		{
			this.nbPlaces = nbPlaces;
			this.demandeArret = false;
			this.porteAvant = new Semaphore(1, 1);
			this.porteArriere = new Semaphore(2, 2);
		}

		#endregion

		#region Accesseurs

		// Récupère le nombre de place que le bus peut atteindre au maximum
		public int getNbPlaces()
		{
			return this.nbPlaces;
		}

		// Diminue le nombre de place occupées dans le bus de 1
		public void decNbPlaces()
		{
			Interlocked.Decrement(ref this.nbPlaces);
		}

		// Récupère la porte avant du bus
		public Semaphore getMutexPorteAvant()
		{
			return this.porteAvant;
		}

		#endregion

		#region Méthodes

		// Augmente le nombre de place occupées dans le bus de 1
		public void incNbPlaces()
		{
			Interlocked.Increment(ref this.nbPlaces);
		}

		// Récupère les portes arrières du bus
		public Semaphore getMutexPorteArriere()
		{
			return this.porteArriere;
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