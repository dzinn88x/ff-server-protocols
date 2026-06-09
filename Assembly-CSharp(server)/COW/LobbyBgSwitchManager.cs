using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200112F RID: 4399
	[Token(Token = "0x200112F")]
	public class LobbyBgSwitchManager : SingletonModule<LobbyBgSwitchManager>
	{
		// Token: 0x060044C2 RID: 17602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C2")]
		[Address(RVA = "0x14085B8", Offset = "0x14085B8", VA = "0x7BBBC085B8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C3")]
		[Address(RVA = "0x1408804", Offset = "0x1408804", VA = "0x7BBBC08804", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x60044C4")]
		[Address(RVA = "0x1408864", Offset = "0x1408864", VA = "0x7BBBC08864")]
		public ResourceID GetLobbyBgByRegion(string region)
		{
			return default(ResourceID);
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x14089B4", Offset = "0x14089B4", VA = "0x7BBBC089B4")]
		public LobbyBgSwitchManager()
		{
		}

		// Token: 0x040054F0 RID: 21744
		[Token(Token = "0x40054F0")]
		[FieldOffset(Offset = "0x18")]
		private List<LobbyBgSwitchData> m_Data;

		// Token: 0x040054F1 RID: 21745
		[Token(Token = "0x40054F1")]
		[FieldOffset(Offset = "0x20")]
		private LobbyBgSwitchData m_DefaultData;

		// Token: 0x02001130 RID: 4400
		[Token(Token = "0x2001130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC64", Offset = "0x10EAC64")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060044C6 RID: 17606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60044C6")]
			[Address(RVA = "0x14089AC", Offset = "0x14089AC", VA = "0x7BBBC089AC")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x060044C7 RID: 17607 RVA: 0x000150D8 File Offset: 0x000132D8
			[Token(Token = "0x60044C7")]
			[Address(RVA = "0x1408A4C", Offset = "0x1408A4C", VA = "0x7BBBC08A4C")]
			internal bool <GetLobbyBgByRegion>b__0(LobbyBgSwitchData x)
			{
				return default(bool);
			}

			// Token: 0x040054F2 RID: 21746
			[Token(Token = "0x40054F2")]
			[FieldOffset(Offset = "0x10")]
			public string region;
		}
	}
}
