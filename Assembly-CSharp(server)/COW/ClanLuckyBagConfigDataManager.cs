using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CBE RID: 7358
	[Token(Token = "0x2001CBE")]
	internal class ClanLuckyBagConfigDataManager : SingletonModule<ClanLuckyBagConfigDataManager>
	{
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x0600A084 RID: 41092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A95")]
		public ClanLuckyBagConfigData ClanLuckyBagConfigData
		{
			[Token(Token = "0x600A084")]
			[Address(RVA = "0x14F90D0", Offset = "0x14F90D0", VA = "0x7BBBCF90D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A085")]
		[Address(RVA = "0x14F90D8", Offset = "0x14F90D8", VA = "0x7BBBCF90D8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A086")]
		[Address(RVA = "0x14F91C0", Offset = "0x14F91C0", VA = "0x7BBBCF91C0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A087")]
		[Address(RVA = "0x14F91C4", Offset = "0x14F91C4", VA = "0x7BBBCF91C4")]
		public ClanLuckyBagConfigDataManager()
		{
		}

		// Token: 0x0400A744 RID: 42820
		[Token(Token = "0x400A744")]
		[FieldOffset(Offset = "0x18")]
		private ClanLuckyBagConfigData m_Data;
	}
}
