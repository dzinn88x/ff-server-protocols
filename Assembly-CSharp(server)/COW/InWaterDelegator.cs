using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001272 RID: 4722
	[Token(Token = "0x2001272")]
	public class InWaterDelegator : StatedTaggedTriggerDelegator
	{
		// Token: 0x0600491A RID: 18714 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x600491A")]
		[Address(RVA = "0x185D4AC", Offset = "0x185D4AC", VA = "0x7BBC05D4AC", Slot = "4")]
		protected override bool CheckCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491B")]
		[Address(RVA = "0x185D550", Offset = "0x185D550", VA = "0x7BBC05D550")]
		public InWaterDelegator()
		{
		}
	}
}
