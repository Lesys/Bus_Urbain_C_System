using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ApplicationBus
{
	public class Passager
	{
		#region Propriétés

		private Bus bus;
		private bool possedeTicket;
		private bool veutDescendre;

		#endregion

		#region Constructeurs

		public Passager()
		{
		}

		#endregion

		#region Accesseurs

		public bool getPossedeTicket()
		{
			return this.possedeTicket;
		}

		#endregion

		#region Méthodes

		public void MonterTitreTransport()
		{

		}

		#endregion
	}
}
