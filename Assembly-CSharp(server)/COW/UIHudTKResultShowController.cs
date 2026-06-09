using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200197E RID: 6526
	[Token(Token = "0x200197E")]
	internal class UIHudTKResultShowController : UIHudBigHeadResultShowController
	{
		// Token: 0x060084F9 RID: 34041 RVA: 0x000240F0 File Offset: 0x000222F0
		[Token(Token = "0x60084F9")]
		[Address(RVA = "0x167AEFC", Offset = "0x167AEFC", VA = "0x7BBBE7AEFC")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60084FA")]
		[Address(RVA = "0x167AF4C", Offset = "0x167AF4C", VA = "0x7BBBE7AF4C", Slot = "38")]
		protected override List<PlayerData> CreateResultData()
		{
			return null;
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084FB")]
		[Address(RVA = "0x167B210", Offset = "0x167B210", VA = "0x7BBBE7B210")]
		public UIHudTKResultShowController()
		{
		}
	}
}
