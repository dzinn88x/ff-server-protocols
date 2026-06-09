using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF5 RID: 7413
	[Token(Token = "0x2001CF5")]
	internal class PCClothConfigDataManager : SingletonModule<PCClothConfigDataManager>
	{
		// Token: 0x0600A1A4 RID: 41380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A4")]
		[Address(RVA = "0x20386B0", Offset = "0x20386B0", VA = "0x7BBC8386B0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A5")]
		[Address(RVA = "0x2038734", Offset = "0x2038734", VA = "0x7BBC838734", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A6")]
		[Address(RVA = "0x2038A90", Offset = "0x2038A90", VA = "0x7BBC838A90")]
		public PCClothConfigDataManager()
		{
		}

		// Token: 0x0400A80D RID: 43021
		[Token(Token = "0x400A80D")]
		[FieldOffset(Offset = "0x18")]
		public List<uint> MaleClothList;

		// Token: 0x0400A80E RID: 43022
		[Token(Token = "0x400A80E")]
		[FieldOffset(Offset = "0x20")]
		public List<uint> FeMaleClothList;
	}
}
