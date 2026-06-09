using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001189 RID: 4489
	[Token(Token = "0x2001189")]
	public class SnowManDataManager : SingletonModule<SnowManDataManager>
	{
		// Token: 0x060045E8 RID: 17896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x1B39FB8", Offset = "0x1B39FB8", VA = "0x7BBC339FB8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x1B3A058", Offset = "0x1B3A058", VA = "0x7BBC33A058", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x1B3A05C", Offset = "0x1B3A05C", VA = "0x7BBC33A05C")]
		public List<uint> GetCurrentLevelClothIDs(uint level)
		{
			return null;
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EB")]
		[Address(RVA = "0x1B3A328", Offset = "0x1B3A328", VA = "0x7BBC33A328")]
		public SnowManDataManager()
		{
		}
	}
}
