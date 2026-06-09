using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002099 RID: 8345
	[Token(Token = "0x2002099")]
	public class UICustomSortTable : UITable
	{
		// Token: 0x0600BB89 RID: 48009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB89")]
		[Address(RVA = "0x1BAC054", Offset = "0x1BAC054", VA = "0x7BBC3AC054", Slot = "4")]
		protected override void Sort(List<Transform> list)
		{
		}

		// Token: 0x0600BB8A RID: 48010 RVA: 0x00035130 File Offset: 0x00033330
		[Token(Token = "0x600BB8A")]
		[Address(RVA = "0x1BAC0F4", Offset = "0x1BAC0F4", VA = "0x7BBC3AC0F4")]
		private int SortBySortId(Transform g1, Transform g2)
		{
			return 0;
		}

		// Token: 0x0600BB8B RID: 48011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB8B")]
		[Address(RVA = "0x1BAC1A0", Offset = "0x1BAC1A0", VA = "0x7BBC3AC1A0")]
		public UICustomSortTable()
		{
		}
	}
}
