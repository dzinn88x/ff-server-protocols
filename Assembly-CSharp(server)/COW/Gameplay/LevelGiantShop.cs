using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x0200285B RID: 10331
	[Token(Token = "0x200285B")]
	public class LevelGiantShop : BaseLevelObject
	{
		// Token: 0x0600D9F9 RID: 55801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D9F9")]
		[Address(RVA = "0x1EB01B4", Offset = "0x1EB01B4", VA = "0x7BBC6B01B4", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D9FA RID: 55802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9FA")]
		[Address(RVA = "0x1EB01FC", Offset = "0x1EB01FC", VA = "0x7BBC6B01FC")]
		public void OnLocalPlayerEnterTrigger()
		{
		}

		// Token: 0x0600D9FB RID: 55803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9FB")]
		[Address(RVA = "0x1EB03B8", Offset = "0x1EB03B8", VA = "0x7BBC6B03B8")]
		public void OnLocalPlayerExitTrigger()
		{
		}

		// Token: 0x0600D9FC RID: 55804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9FC")]
		[Address(RVA = "0x1EB04D8", Offset = "0x1EB04D8", VA = "0x7BBC6B04D8")]
		public LevelGiantShop()
		{
		}
	}
}
