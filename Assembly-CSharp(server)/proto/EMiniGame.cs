using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006BB RID: 1723
	[Token(Token = "0x20006BB")]
	[ProtoContract]
	public class EMiniGame
	{
		// Token: 0x060023DE RID: 9182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x21B9880", Offset = "0x21B9880", VA = "0x7BBC9B9880")]
		public EMiniGame()
		{
		}

		// Token: 0x020006BC RID: 1724
		[Token(Token = "0x20006BC")]
		[ProtoContract]
		public enum MiniGame
		{
			// Token: 0x040021D7 RID: 8663
			[Token(Token = "0x40021D7")]
			MiniGame_NONE,
			// Token: 0x040021D8 RID: 8664
			[Token(Token = "0x40021D8")]
			MiniGame_BOOYAH_CHESS,
			// Token: 0x040021D9 RID: 8665
			[Token(Token = "0x40021D9")]
			MiniGame_MONOPOLY
		}

		// Token: 0x020006BD RID: 1725
		[Token(Token = "0x20006BD")]
		[ProtoContract]
		public enum HexagonStatus
		{
			// Token: 0x040021DB RID: 8667
			[Token(Token = "0x40021DB")]
			HexagonStatus_NONE,
			// Token: 0x040021DC RID: 8668
			[Token(Token = "0x40021DC")]
			HexagonStatus_PLAYER,
			// Token: 0x040021DD RID: 8669
			[Token(Token = "0x40021DD")]
			HexagonStatus_ENEMY,
			// Token: 0x040021DE RID: 8670
			[Token(Token = "0x40021DE")]
			HexagonStatus_CHEST,
			// Token: 0x040021DF RID: 8671
			[Token(Token = "0x40021DF")]
			HexagonStatus_BOOYAH
		}

		// Token: 0x020006BE RID: 1726
		[Token(Token = "0x20006BE")]
		[ProtoContract]
		public enum GameStatus
		{
			// Token: 0x040021E1 RID: 8673
			[Token(Token = "0x40021E1")]
			GameStatus_NONE,
			// Token: 0x040021E2 RID: 8674
			[Token(Token = "0x40021E2")]
			GameStatus_INGAME
		}

		// Token: 0x020006BF RID: 1727
		[Token(Token = "0x20006BF")]
		[ProtoContract]
		public enum MonopolyNodeType
		{
			// Token: 0x040021E4 RID: 8676
			[Token(Token = "0x40021E4")]
			MonopolyNodeType_NONE,
			// Token: 0x040021E5 RID: 8677
			[Token(Token = "0x40021E5")]
			MonopolyNodeType_BOX,
			// Token: 0x040021E6 RID: 8678
			[Token(Token = "0x40021E6")]
			MonopolyNodeType_DICE,
			// Token: 0x040021E7 RID: 8679
			[Token(Token = "0x40021E7")]
			MonopolyNodeType_FORWWARD,
			// Token: 0x040021E8 RID: 8680
			[Token(Token = "0x40021E8")]
			MonopolyNodeType_BACKWARD,
			// Token: 0x040021E9 RID: 8681
			[Token(Token = "0x40021E9")]
			MonopolyNodeType_BUFF,
			// Token: 0x040021EA RID: 8682
			[Token(Token = "0x40021EA")]
			MonopolyNodeType_TOKEN,
			// Token: 0x040021EB RID: 8683
			[Token(Token = "0x40021EB")]
			MonopolyNodeType_EVENT,
			// Token: 0x040021EC RID: 8684
			[Token(Token = "0x40021EC")]
			MonopolyNodeType_START
		}

		// Token: 0x020006C0 RID: 1728
		[Token(Token = "0x20006C0")]
		[ProtoContract]
		public enum MonopolyEventResultType
		{
			// Token: 0x040021EE RID: 8686
			[Token(Token = "0x40021EE")]
			MonopolyEventResultType_NONE,
			// Token: 0x040021EF RID: 8687
			[Token(Token = "0x40021EF")]
			MonopolyEventResultType_TOKEN,
			// Token: 0x040021F0 RID: 8688
			[Token(Token = "0x40021F0")]
			MonopolyEventResultType_ACTIVITY
		}

		// Token: 0x020006C1 RID: 1729
		[Token(Token = "0x20006C1")]
		[ProtoContract]
		public enum MonopolyPlayerStatus
		{
			// Token: 0x040021F2 RID: 8690
			[Token(Token = "0x40021F2")]
			MonopolyPlayerStatus_NONE,
			// Token: 0x040021F3 RID: 8691
			[Token(Token = "0x40021F3")]
			MonopolyPlayerStatus_WAITINGEVENT
		}
	}
}
