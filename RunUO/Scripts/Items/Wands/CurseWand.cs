using System;
using Server;
using Server.Spells.Fourth;
using Server.Targeting;
using Server.Network;

namespace Server.Items
{
	public class CurseWand : BaseWand
	{
		[Constructable]
		public CurseWand() : base( WandEffect.None, 0, 0 )
		{
		}

		public CurseWand( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void OnWandUse( Mobile from )
		{
			Cast( new CurseSpell( from, this ) );
		}
	}
}