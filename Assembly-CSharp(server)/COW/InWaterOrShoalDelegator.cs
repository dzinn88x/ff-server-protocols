using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001273 RID: 4723
	[Token(Token = "0x2001273")]
	public class InWaterOrShoalDelegator : StatedTaggedTriggerDelegator
	{
		// Token: 0x0600491C RID: 18716 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x600491C")]
		[Address(RVA = "0x185D558", Offset = "0x185D558", VA = "0x7BBC05D558", Slot = "4")]
		protected override bool CheckCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x185D62C", Offset = "0x185D62C", VA = "0x7BBC05D62C")]
		public InWaterOrShoalDelegator()
		{
		}
	}
}
