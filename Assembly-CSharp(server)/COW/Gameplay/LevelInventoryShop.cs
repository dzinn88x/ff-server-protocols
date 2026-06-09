using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002864 RID: 10340
	[Token(Token = "0x2002864")]
	public class LevelInventoryShop : BaseLevelObject
	{
		// Token: 0x0600DA47 RID: 55879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DA47")]
		[Address(RVA = "0x1EB5AD8", Offset = "0x1EB5AD8", VA = "0x7BBC6B5AD8", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA48")]
		[Address(RVA = "0x1EB5B20", Offset = "0x1EB5B20", VA = "0x7BBC6B5B20", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA49")]
		[Address(RVA = "0x1EB5BE4", Offset = "0x1EB5BE4", VA = "0x7BBC6B5BE4")]
		public void OnLocalPlayerEnterTrigger()
		{
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA4A")]
		[Address(RVA = "0x1EB5D90", Offset = "0x1EB5D90", VA = "0x7BBC6B5D90")]
		public void OnLocalPlayerExitTrigger()
		{
		}

		// Token: 0x0600DA4B RID: 55883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA4B")]
		[Address(RVA = "0x1EB5C00", Offset = "0x1EB5C00", VA = "0x7BBC6B5C00")]
		public void HighLight(bool K`OU\u0080vI)
		{
		}

		// Token: 0x0600DA4C RID: 55884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA4C")]
		[Address(RVA = "0x1EB5CC8", Offset = "0x1EB5CC8", VA = "0x7BBC6B5CC8")]
		private void E\u0082k]}Wt(bool K`OU\u0080vI)
		{
		}

		// Token: 0x0600DA4D RID: 55885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA4D")]
		[Address(RVA = "0x1EB5E44", Offset = "0x1EB5E44", VA = "0x7BBC6B5E44")]
		public LevelInventoryShop()
		{
		}

		// Token: 0x04010A21 RID: 68129
		[Token(Token = "0x4010A21")]
		[FieldOffset(Offset = "0x68")]
		public List<uint> ItemList;

		// Token: 0x04010A22 RID: 68130
		[Token(Token = "0x4010A22")]
		[FieldOffset(Offset = "0x70")]
		public ae}jEl\u0082 ShopType;

		// Token: 0x04010A23 RID: 68131
		[Token(Token = "0x4010A23")]
		[FieldOffset(Offset = "0x74")]
		public U\u0080vInZ\u007F ItemShopType;

		// Token: 0x04010A24 RID: 68132
		[Token(Token = "0x4010A24")]
		[FieldOffset(Offset = "0x78")]
		public GameObject HLGO;
	}
}
